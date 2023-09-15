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
	public partial class WatchAttandance : Form
	{
		Form ParentForm;
		ClassLogic.Patient? UserPat = null;
		public WatchAttandance(Form parentForm)
		{
			InitializeComponent();
			ParentForm = parentForm;
			labelId.Text = "ID врача";
		}
		public WatchAttandance(Form parentForm, ClassLogic.Patient user)
		{
			InitializeComponent();
			ParentForm = parentForm;
			UserPat = user;
			int? HIUser =null;
			using(HospitalAt2Context db = new HospitalAt2Context())
			{ 
				// Найдем мед полис пациента
				var dbHIUser = db.Patients
					.Where(p => p.PkIdPatient == user.UserId)
					.SingleOrDefault();
				if (dbHIUser != null)
				{
					HIUser = dbHIUser.HealthInsurance;
				}
				else
				{
					this.Close();
					return;
				}
			}
			textBoxHI.Text = HIUser!.ToString();
			textBoxHI.ReadOnly= true;
			labelMsg.Text = "Введите дату и время, когда у вас был прием";
			textBoxId.ReadOnly= true;
			labelId.Text = "Специальность и имя врача";
		}


		private void WatchAttandance_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}

		private void buttonCheck_Click_1(object sender, EventArgs e)
		{
			Database.Patient patient;
			Database.Doctor doctor;
			DateTime dateTime;
			string MedFind;
			// Проверим все данные на корректность
			// Проверим на заполненность
			if (!textBoxHI.Text.IsNullOrEmpty()
				&& maskedTextBoxDateTime.Text.Length == 16)
			{
				MedFind = textBoxMedFind.Text;
				// Проверим на корректность ID и мед. полис
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
					if (UserPat is not null)
					{
						using(HospitalAt2Context db = new HospitalAt2Context())
						{
							// Проверим, есть ли запись в Attandance
							// С таким пользователем и таким временем
							var dbAt = db.Attandances
								.Include(p => p.DoctorId)
								.Include(p => p.PatientId)
								.Where(p => p.PatientId!.PkIdPatient == patient.PkIdPatient
											&& p.DateAndTime == dateTime)
								.SingleOrDefault();
							if(dbAt is not null)
							{
								// Запись есть и мы можем определить врача
								doctor = dbAt.DoctorId!;
								textBoxId.Text = dbAt.DoctorId!.Speciality  + ", " + dbAt.DoctorId!.NameD;
							}
							else
							{
								labelMsg.Text = "На этот день записи нет";
								return;
							}
						}
					}
					else
					{
						if (!textBoxId.Text.IsNullOrEmpty())
						{
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
						}
						else
						{
							labelMsg.Text = "Введите все данные";
							return;
						}
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

		private void buttonDateNow_Click(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.Now;
			string dateTimeStr = dateTime.ToString(@"dd-MM-yyyy HH:mm");
			maskedTextBoxDateTime.Text = dateTimeStr;
		}
	}
}
