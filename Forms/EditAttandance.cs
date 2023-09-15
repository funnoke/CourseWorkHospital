using CourseWorkAt4.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAt4.Forms
{
	public partial class EditAttandance : Form
	{
		Form ParentForm;
		public EditAttandance(Form parentForm)
		{
			InitializeComponent();
			ParentForm = parentForm;
		}

		private void EditAttandance_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}

		private void buttonDateNow_Click(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			string dateTimeStr = dateTime.ToString(@"dd-MM-yyyy HH:mm");
			maskedTextBoxDateTime.Text = dateTimeStr;
		}

		private void buttonSaveСhange_Click(object sender, EventArgs e)
		{
			Database.Patient patient;
			Database.Doctor doctor;
			DateTime dateTime;
			string MedFind;
			// Проверим все данные на корректность
			// Проверим на заполненность
			if (!textBoxId.Text.IsNullOrEmpty()
				&& !textBoxHI.Text.IsNullOrEmpty()
				&& maskedTextBoxDateTime.Text.Length == 16
				&& !textBoxMedFind.Text.IsNullOrEmpty())
			{
				MedFind = textBoxMedFind.Text;
				// Проверим на корректность ID и мед. полис
				// Проверим, состоит ли Id только из цифр
				{
					Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxId.Text);
					if (matches.Success)
					{   // в поле содержится что-то кроме цифр
						labelMsg.Text = "Поле с индентификатором должно содержать\nтолько цифры.";
						return;
					}
				}
				// Проверим, состоит ли мед. полис только из цифр
				{
					Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxHI.Text);
					if (matches.Success)
					{   // в поле содержится что-то кроме цифр
						labelMsg.Text = "Поле с индентификатором должно содержать\nтолько цифры.";
						return;
					}
				}
				// Проверим, существует ли врач с таким ID
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var dbDoc = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
					if (dbDoc is not null)
					{
						doctor = dbDoc;
					}
					else
					{
						labelMsg.Text = "Врача с таким ID нет";
						return;
					}
				}
				// Проверим, существует ли пациент с таким мед. полисом
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var dbPat = db.Patients.Where(p => p.HealthInsurance == Int32.Parse(textBoxHI.Text)).SingleOrDefault();
					if (dbPat is null)
					{
						labelMsg.Text = "Пациента с таким мед. полисом нет";
						return;
					}
					else
					{
						patient = dbPat;
					}
				}

				// Если все верно, то поля
				//		doctor - содержит информацию о враче
				//		patient - содержит информацию о пациенте
				try
				{
					// Проверим поле DateTime на корректность
					dateTime = DateTime.ParseExact(maskedTextBoxDateTime.Text, "dd-MM-yyyy HH:mm",
									   System.Globalization.CultureInfo.InvariantCulture);
					DayOfWeek f = dateTime.DayOfWeek;
					int? myDayOfWeek;
					switch (f)
					{
						case DayOfWeek.Monday:
							myDayOfWeek = 0;
							break;
						case DayOfWeek.Tuesday:
							myDayOfWeek = 1;
							break;
						case DayOfWeek.Wednesday:
							myDayOfWeek = 2;
							break;
						case DayOfWeek.Thursday:
							myDayOfWeek = 3;
							break;
						case DayOfWeek.Friday:
							myDayOfWeek = 4;
							break;
						case DayOfWeek.Saturday:
							myDayOfWeek = 5;
							break;
						default:
							myDayOfWeek = 6;
							break;
					}
					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						DateTime? maxDateInsert = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId!.PkIdDoctor == doctor!.PkIdDoctor
								&& p.DayOfWeek == myDayOfWeek)
							.Max(p => p.DateInsert);
						if (maxDateInsert is null)
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
						TimeSpan locTimeApp = dateTime.TimeOfDay;
						Schedule? dbSch = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId!.PkIdDoctor == doctor!.PkIdDoctor
							&& p.DayOfWeek == myDayOfWeek
							&& p.DateInsert == maxDateInsert)
							.SingleOrDefault();
						if (dbSch is null)
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
						else
						{
							if (!(locTimeApp <= dbSch.TimeEnd && locTimeApp >= dbSch.TimeStart))
							{
								labelMsg.Text = "Неправильное время приема";
								return;
							}
						}
					}
					// Время введено верно

					// Все данные верны, можно добавить запись в бд
					using (HospitalAt2Context db = new HospitalAt2Context())
					{

						Database.Doctor? locDoc = db.Doctors
							.Where(p => p.PkIdDoctor == doctor.PkIdDoctor)
							.SingleOrDefault();
						Database.Patient? locPat = db.Patients
							.Where(p => p.PkIdPatient == patient.PkIdPatient)
							.SingleOrDefault();

						// Проверим, есть ли уже такая запись
						var dbAt = db.Attandances
							.Include(p => p.DoctorId)
							.Include(p => p.PatientId)
							.Where(p => p.FkIdPatient == locPat.PkIdPatient
										&& p.DateAndTime == dateTime)
							.SingleOrDefault();
						if(dbAt is not null)
						{
							if(dbAt.DoctorId!.PkIdDoctor != locDoc.PkIdDoctor)
							{
								labelMsg.Text = "В это время пациент был у другого врача\n"
									+ "кажется вы неверно ввели данные о враче";
								return;
							}
							dbAt.MedicalFindings = MedFind;
							db.Attandances.Update(dbAt);
							db.SaveChanges();
							labelMsg.Text = "Запись успешно изменена";
						}
						else
						{
							//Генерация Primary Key
							int idAcc;
							{
								// Получаем самый большой по значению первичный ключ
								var dbAccId = db.Attandances.OrderBy(p => p.PkIdAttandance).LastOrDefault();
								// Если первичного ключа нет, то объявляем его как наименьший - '0'
								// Иначе увеличиваем наибольший первичный ключ на 1
								if (dbAccId != null)
									idAcc = dbAccId.PkIdAttandance + 1;
								else
									idAcc = 0;
							}

							Database.Attandance newAt = new Database.Attandance()
							{
								PkIdAttandance = idAcc,
								DateAndTime = dateTime,
								MedicalFindings = MedFind,
								FkIdDoctor = locDoc.PkIdDoctor,
								DoctorId = locDoc,
								FkIdPatient = locPat.PkIdPatient,
								PatientId = locPat
							};
							db.Attandances.Add(newAt);
							db.SaveChanges();
							labelMsg.Text = "Запись успешно добавлена";
						}

					}
				}
				catch
				{
					labelMsg.Text = "Введенное время некорректно";
					return;
				}

			}
			else
			{
				labelMsg.Text = "Заполните все данные";
				return;
			}
		}


		private void buttonCheck_Click(object sender, EventArgs e)
		{
			Database.Patient patient;
			Database.Doctor doctor;
			DateTime dateTime;
			string MedFind;
			// Проверим все данные на корректность
			// Проверим на заполненность
			if (!textBoxId.Text.IsNullOrEmpty()
				&& !textBoxHI.Text.IsNullOrEmpty()
				&& maskedTextBoxDateTime.Text.Length == 16)
			{
				MedFind = textBoxMedFind.Text;
				// Проверим на корректность ID и мед. полис
				// Проверим, состоит ли Id только из цифр
				{
					Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxId.Text);
					if (matches.Success)
					{   // в поле содержится что-то кроме цифр
						labelMsg.Text = "Поле с индентификатором должно содержать\nтолько цифры.";
						return;
					}
				}
				// Проверим, состоит ли мед. полис только из цифр
				{
					Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxHI.Text);
					if (matches.Success)
					{   // в поле содержится что-то кроме цифр
						labelMsg.Text = "Поле с индентификатором должно содержать\nтолько цифры.";
						return;
					}
				}
				// Проверим, существует ли врач с таким ID
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var dbDoc = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
					if (dbDoc is not null)
					{
						doctor = dbDoc;
					}
					else
					{
						labelMsg.Text = "Врача с таким ID нет";
						return;
					}
				}
				// Проверим, существует ли пациент с таким мед. полисом
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var dbPat = db.Patients.Where(p => p.HealthInsurance == Int32.Parse(textBoxHI.Text)).SingleOrDefault();
					if (dbPat is null)
					{
						labelMsg.Text = "Пациента с таким мед. полисом нет";
						return;
					}
					else
					{
						patient = dbPat;
					}
				}

				// Если все верно, то поля
				//		doctor - содержит информацию о враче
				//		patient - содержит информацию о пациенте
				try
				{
					// Проверим поле DateTime на корректность
					dateTime = DateTime.ParseExact(maskedTextBoxDateTime.Text, "dd-MM-yyyy HH:mm",
									   System.Globalization.CultureInfo.InvariantCulture);
					DayOfWeek f = dateTime.DayOfWeek;
					int? myDayOfWeek;
					switch (f)
					{
						case DayOfWeek.Monday:
							myDayOfWeek = 0;
							break;
						case DayOfWeek.Tuesday:
							myDayOfWeek = 1;
							break;
						case DayOfWeek.Wednesday:
							myDayOfWeek = 2;
							break;
						case DayOfWeek.Thursday:
							myDayOfWeek = 3;
							break;
						case DayOfWeek.Friday:
							myDayOfWeek = 4;
							break;
						case DayOfWeek.Saturday:
							myDayOfWeek = 5;
							break;
						default:
							myDayOfWeek = 6;
							break;
					}
					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						DateTime? maxDateInsert = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId!.PkIdDoctor == doctor!.PkIdDoctor
								&& p.DayOfWeek == myDayOfWeek)
							.Max(p => p.DateInsert);
						if (maxDateInsert is null)
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
						TimeSpan locTimeApp = dateTime.TimeOfDay;
						Schedule? dbSch = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId!.PkIdDoctor == doctor!.PkIdDoctor
							&& p.DayOfWeek == myDayOfWeek
							&& p.DateInsert == maxDateInsert)
							.SingleOrDefault();
						if (dbSch is null)
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
						else
						{
							if (!(locTimeApp <= dbSch.TimeEnd && locTimeApp >= dbSch.TimeStart))
							{
								labelMsg.Text = "Неправильное время приема";
								return;
							}
						}
					}
					// Время введено верно

					// Все данные верны, можно вывести заключение
					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						Database.Doctor? locDoc = db.Doctors
							.Where(p => p.PkIdDoctor == doctor.PkIdDoctor)
							.SingleOrDefault();
						Database.Patient? locPat = db.Patients
							.Where(p => p.PkIdPatient == patient.PkIdPatient)
							.SingleOrDefault();

						var dbAt = db.Attandances
							.Include(p => p.DoctorId)
							.Include(p => p.PatientId)
							.Where(p => p.FkIdDoctor == locDoc.PkIdDoctor
										&& p.FkIdPatient == locPat.PkIdPatient
										&& p.DateAndTime == dateTime)
							.SingleOrDefault();
						if (dbAt is not null)
						{
							textBoxMedFind.Text = dbAt.MedicalFindings;
							labelMsg.Text = "Запись найдена";
						}
						else
						{
							labelMsg.Text = "Запись не найдена";
						}
					}
				}
				catch
				{
					labelMsg.Text = "Введенное время некорректно";
					return;
				}

			}
			else
			{
				labelMsg.Text = "Заполните все данные";
				return;
			}
		}
	}
}
