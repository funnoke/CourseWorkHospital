using CourseWorkAt4.Database;
using CourseWorkAt4.ClassLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Numerics;
using System.Text.RegularExpressions;

namespace CourseWorkAt4.Forms
{
	public partial class SignUpAppointment : Form
	{
		private ClassLogic.MedicalSecretary UserMed;
		private ClassLogic.Patient UserPat;
		private Form ParentForm; // ссылка на форму, которая вызвала текущую форму
		public SignUpAppointment(
			Form parentForm, ClassLogic.MedicalSecretary user)
		{
			InitializeComponent();
			ParentForm = parentForm;
			UserMed = user;
		}
		public SignUpAppointment(
			Form parentForm, ClassLogic.Patient user)
		{
			InitializeComponent();
			ParentForm = parentForm;
			UserPat = user;
		}

		private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
		{
		}

		private void maskedTextName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}


		private void buttonWatchSchedule_Click(object sender, EventArgs e)
		{
			WatchSchedule f = new WatchSchedule(this);
			f.Show();

		}

		private void buttonSaveChanges_Click(object sender, EventArgs e)
		{
			Database.Doctor? doctor = null;
			Database.Patient? patient= null;
			DateTime dateApp;
			//Проверим поля на заполненность
			if (maskedTextBoxTime.Text.Length == 16
				&& !textBoxHIPatient.Text.IsNullOrEmpty()
				&& !textBoxId.Text.IsNullOrEmpty())
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

				//	Проверка на корректность поля Name
				//	Проверка на наличие чего-то кроме букв
				if (!textBoxName.Text.IsNullOrEmpty())
				{
					Regex regex = new Regex(@"(\d)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxName.Text);
					Regex regex2 = new Regex(@"(\W)", RegexOptions.IgnoreCase);
					Match matches2 = regex.Match(textBoxName.Text);
					if (matches.Success || matches2.Success)
					{
						labelMsg.Text = "Имя может содержать только буквы";
						return;
					}
				}


				try
				{
					dateApp = DateTime.ParseExact(maskedTextBoxTime.Text, "dd-MM-yyyy HH:mm",
									   System.Globalization.CultureInfo.InvariantCulture);

					//Проверим, есть ли запись на это время
					using(HospitalAt2Context db = new HospitalAt2Context())
					{
						var dbApp = db.Appointments.Where(p => p.DateAndTime== dateApp).SingleOrDefault();
						if(dbApp is not null)
						{
							labelMsg.Text = "Запись на это время уже есть";
							return;
						}
					}


					// Проверим, есть ли врач с такими данными
					if (!textBoxName.Text.IsNullOrEmpty())
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							var dbDoc = db.Doctors.Where(p => p.NameD == textBoxName.Text).ToList();
							if (dbDoc is null)
							{
								labelMsg.Text = "Такого врача нет в системе";
								return;
							}
							else if (dbDoc.Count() > 1)
							{
								if (!textBoxId.Text.IsNullOrEmpty())
								{
									var dbDoc2 = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
									if (dbDoc2 is null)
									{
										labelMsg.Text = "Врачей с таким именем и ID не найдено.";
										return;
									}
									else
									{
										doctor = dbDoc2;
									}
								}
								else
								{
									labelMsg.Text = "Врачей с таким именем несколько, введите дополнительно ID";
									return;
								}
							}
							else if (dbDoc.Count == 1)
							{
								Database.Doctor doc = dbDoc.Single();
								doctor = doc;
							}
						}
					}
					else if (!textBoxId.Text.IsNullOrEmpty())
					{
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
						labelMsg.Text = "Введите данные о враче";
						return;
					}

					// Есть ли пациент с таким мед. полисом
					using(HospitalAt2Context db = new HospitalAt2Context())
					{
						var dbPat = db.Patients.Where(p => p.HealthInsurance == Int32.Parse(textBoxHIPatient.Text)).SingleOrDefault();
						if(dbPat is null)
						{
							labelMsg.Text = "Пациента с таким мед. полисом нет";
							return;
						}
						else
						{
							patient = dbPat;
						}
					}

					// Проверим корректность заданного времени приема
					DayOfWeek f = dateApp.DayOfWeek;
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
					using(HospitalAt2Context db = new HospitalAt2Context() )
					{
						DateTime? maxDateInsert = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId!.PkIdDoctor == doctor!.PkIdDoctor
								&& p.DayOfWeek == myDayOfWeek)
							.Max(p => p.DateInsert);
						if(maxDateInsert is null)
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
						TimeSpan locTimeApp = dateApp.TimeOfDay;
						Schedule? dbSch = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId!.PkIdDoctor == doctor!.PkIdDoctor
							&& p.DayOfWeek == myDayOfWeek
							&& p.DateInsert == maxDateInsert)
							.SingleOrDefault();
						if(dbSch is null)
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
						else
						{
							if(!(locTimeApp<dbSch.TimeEnd && locTimeApp>dbSch.TimeStart))
							{
								labelMsg.Text = "Неправильное время приема";
								return;
							}
						}
					}

					// Все данные верны, есть:
					//		врач
					//		пациент
					//		Время для записи
					// Добавим запись в базу данных

					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						Database.Doctor? locDoc = db.Doctors
							.Where(p => p.PkIdDoctor == doctor.PkIdDoctor)
							.SingleOrDefault();
						Database.Patient? locPat = db.Patients
							.Where(p => p.PkIdPatient == patient.PkIdPatient)
							.SingleOrDefault();

						//Генерация Primary Key
						// Получаем самый большой по значению первичный ключ
						var dbAccId = db.Appointments.OrderBy(p => p.PkIdAppointment).LastOrDefault();
						// Если первичного ключа нет, то объявляем его как наименьший - '0'
						// Иначе увеличиваем наибольший первичный ключ на 1
						int idAcc;
						if (dbAccId != null)
							idAcc = dbAccId.PkIdAppointment + 1;
						else
							idAcc = 0;
						Appointment newApp = new Appointment()
						{
							PkIdAppointment = idAcc
							,DateAndTime = dateApp
							,FkIdDoctor = locDoc!.PkIdDoctor
							,DoctorId = locDoc
							,FkIdPatient = locPat.PkIdPatient
							,PatientId = locPat
						};
						db.Appointments.Add(newApp);
						db.SaveChanges();
						labelMsg.Text = "Данные успешно сохранены";
					}
				}
				catch 
				{
					labelMsg.Text = "Время введено неверно";
				}
			}
			else
			{
				labelMsg.Text = "Введенные данные не корректны";
			}
		}

		private void buttonWatchAppoinment_Click(object sender, EventArgs e)
		{
			// Для просмотра записей на прием нужны данные:
			//		Врача, к которому производится запись
			//		День, на который планируется запись
			
			Database.Doctor? doctor = null;
			DateTime dateApp;
			Database.Schedule? schedule = null;
			// Проверим, есть ли врач с такими данными
			if (!textBoxName.Text.IsNullOrEmpty())
			{
				{
					Regex regex = new Regex(@"(\d)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxName.Text);
					Regex regex2 = new Regex(@"(\W)", RegexOptions.IgnoreCase);
					Match matches2 = regex.Match(textBoxName.Text);
					if (matches.Success || matches2.Success)
					{
						labelMsg.Text = "Имя может содержать только буквы";
						return;
					}
				}
				if(!textBoxId.Text.IsNullOrEmpty())
				{
					Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxId.Text);
					if (matches.Success)
					{   // в поле содержится что-то кроме цифр
						labelMsg.Text = "Поле с индентификатором должно содержать\nтолько цифры.";
						return;
					}

				}

				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var dbDoc = db.Doctors.Where(p => p.NameD == textBoxName.Text).ToList();
					if (dbDoc is null)
					{
						labelMsg.Text = "Такого врача нет в системе";
						return;
					}
					else if (dbDoc.Count() > 1)
					{
						if (!textBoxId.Text.IsNullOrEmpty())
						{
							var dbDoc2 = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
							if (dbDoc2 is null)
							{
								labelMsg.Text = "Врачей с таким именем и ID не найдено.";
								return;
							}
							else
							{
								doctor = dbDoc2;
							}
						}
						else
						{
							labelMsg.Text = "Врачей с таким именем несколько, введите дополнительно ID";
							return;
						}
					}
					else if (dbDoc.Count == 1)
					{
						Database.Doctor doc = dbDoc.Single();
						doctor = doc;
					}
				}
			}
			else if (!textBoxId.Text.IsNullOrEmpty())
			{
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
				labelMsg.Text = "Введите данные о враче";
				return;
			}
			try
			{
				dateApp = DateTime.ParseExact(maskedTextBoxTime.Text, "dd-MM-yyyy HH:mm",
								   System.Globalization.CultureInfo.InvariantCulture);
				// Проверим корректность заданного времени приема
				//		Время записи должно находится в рамках времени приема
				DayOfWeek f = dateApp.DayOfWeek;
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
					TimeSpan locTimeApp = dateApp.TimeOfDay;
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
						schedule = dbSch;
						if (!(locTimeApp < dbSch.TimeEnd && locTimeApp > dbSch.TimeStart))
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
					}
				}

				WatchAppoinment form = new WatchAppoinment(this, doctor, schedule, dateApp);
				form.Show();
			}
			catch
			{
				labelMsg.Text = "Время введено неверно";
			}
		}
	}
	
}
