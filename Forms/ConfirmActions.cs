using CourseWorkAt4.ClassLogic;
using CourseWorkAt4.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAt4.Forms
{
	public partial class ConfirmActions : Form
	{
		private Form ParentForm;
		List<string> Config;
		List<string> After;
		public ConfirmActions(Form parentForm,  List<string> config,List<string> after, List<string>? before = null)
		{
			InitializeComponent();
			ParentForm = parentForm;
			Config = config;
			After = after;

			labelChangeAsk.Text = string.Empty;
			labelBefore.Text = string.Empty;
			labelAfter.Text = string.Empty;
			if (config[0] == "User")
			{
				string[] tempUser = new string[] { "Имя: ", "\n", "Спец. или мед.п.: ", "\n", "ID: ", "\n" };
				// Заполнение поля After
				for(int i = 0; i <after.Count; i++)
				{
					tempUser[i*2+1] = "\t" + after[i] + "\n";
				}
				labelAfter.Text = string.Join("", tempUser);
			}
			else
			{
				string[] tempUser = new string[] { "Логин: ", "\n", "Пароль: ", "\n", "ID: ", "\n", "Имя: ", "\n" };
				// Заполнение поля After
				for (int i = 0; i < after.Count; i++)
				{
					tempUser[i * 2 + 1] = "\t" + after[i] + "\n";
				}
				labelAfter.Text = string.Join("", tempUser);
			}

			if (before is null)
			{
				if (config[0] == "User")
				{
					labelChangeAsk.Text += "cоздать пользователя с следующими данными:\n";
				}
				else
				{
					labelChangeAsk.Text += "cоздать аккаунт с следующими данными:\n";
				}
			}
			else
			{
				if (config[0] == "User")
				{
					labelChangeAsk.Text += "редактировать пользователя с следующими данными:\n";

				}
				else
				{
					labelChangeAsk.Text += "редактировать аккаунт с следующими данными:\n";
				}
				string[] tempUser = new string[] { "Имя: ", "\n", "Спец. или мед.п.: ", "\n", "ID: ", "\n" };
				// Заполнение поля After
				for (int i = 0; i < before.Count; i++)
				{
					tempUser[i*2 + 1] = before[i] + "\n";
				}
				labelBefore.Text = string.Join("", tempUser);
			}
		}

		private void buttonYes_Click(object sender, EventArgs e)
		{
			// Записать данные в базу данных и выйти
			if (Config[0] == "User")
				// Работа с пользователями
			{
				if (Config[1] == "Doctor")
				{
					// Проверяем, есть ли пользователь с таким id
					using(HospitalAt2Context db = new HospitalAt2Context())
					{
						var user = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(After[2])).SingleOrDefault();
						if(user is null)
							// Пользователя не существует, поэтому создаем его
						{
							using (HospitalAt2Context db2 = new HospitalAt2Context())
							{
								Database.Doctor userDoc = new Database.Doctor()
								{
									NameD = After[0],
									Speciality = After[1],
									PkIdDoctor = Int32.Parse(After[2])
								};
								db2.Doctors.Add(userDoc);
								db2.SaveChanges();
							}

						}
						else
							// Пользователь существует, поэтому просто меняем данные
						{
							using (HospitalAt2Context db2 = new HospitalAt2Context())
							{
								Database.Doctor userDoc = new Database.Doctor()
								{
									NameD = After[0],
									Speciality = After[1],
									PkIdDoctor = Int32.Parse(After[2])
								};
								db2.Doctors.Update(userDoc);
								db2.SaveChanges();
							}

						}
					}

				}
				else if (Config[1] == "Patient")
				{
					// Проверяем, есть ли пользователь с таким id
					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						var user = db.Patients.Where(p => p.HealthInsurance == Int32.Parse(After[2])).SingleOrDefault();
						if (user is null)
						// Пользователя не существует, поэтому создаем его
						{
							using (HospitalAt2Context db2 = new HospitalAt2Context())
							{
								//Генерация Primary Key
								// Получаем самый большой по значению первичный ключ
								var dbAccId = db.Patients.OrderBy(p => p.PkIdPatient).LastOrDefault();
								// Если первичного ключа нет, то объявляем его как наименьший - '0'
								// Иначе увеличиваем наибольший первичный ключ на 1
								int idAcc;
								if (dbAccId != null)
									idAcc = dbAccId.PkIdPatient + 1;
								else
									idAcc = 0;
								Database.Patient userPat = new Database.Patient()
								{
									NamePatient = After[0],
									HealthInsurance = Int32.Parse(After[1]),
									PkIdPatient = idAcc
								};
								db2.Patients.Add(userPat);
								db2.SaveChanges();
							}
						}
						else
						// Пользователь существует, поэтому меняем данные
						{
							using (HospitalAt2Context db2 = new HospitalAt2Context())
							{
								Database.Patient userPat = new Database.Patient()
								{
									NamePatient = After[0],
									HealthInsurance = Int32.Parse(After[1]),
									PkIdPatient = user.PkIdPatient
									
								};
								db2.Patients.Update(userPat);
								db2.SaveChanges();
							}
						}
					}
				}
				else
				{
					// Проверяем, есть ли пользователь с таким id
					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						var user = db.MedicalSecretaries.Where(p => p.PkIdMedS == Int32.Parse(After[2])).SingleOrDefault();
						if (user is null)
						// Пользователя не существует, поэтому создаем его
						{
							using (HospitalAt2Context db2 = new HospitalAt2Context())
							{
								Database.MedicalSecretary userMedS = new Database.MedicalSecretary()
								{
									NameMedS = After[0],
									PkIdMedS = Int32.Parse(After[2])
								};
								db2.MedicalSecretaries.Add(userMedS);
								db2.SaveChanges();
							}
						}
						else
						// Пользователь существует, поэтому обновляем данные
						{
							using (HospitalAt2Context db2 = new HospitalAt2Context())
							{
								Database.MedicalSecretary userMedS = new Database.MedicalSecretary()
								{
									NameMedS = After[0],
									PkIdMedS = Int32.Parse(After[2])
								};
								db2.MedicalSecretaries.Update(userMedS);
								db2.SaveChanges();
							}
						}
					}
				}
			}
			else
				// Работа с Аккаунтами
			{
				if (Config[1] == "Edit")
					// Редактировать аккаунт
				{
					using(HospitalAt2Context db = new HospitalAt2Context())
					{
						var user = db.Accounts.Where(p => p.PkIdAcc == Int32.Parse(After[2])).SingleOrDefault();
						if(user is not null)
						{
							user.LoginAcc = After[0];
							user.PasswordAcc= After[1];
							db.Accounts.Update(user); 
							db.SaveChanges();
						}	
					}
				}
				else
					// Создать аккаунт
				{
					if (Config[2] == "Patient")
					{
						using(HospitalAt2Context db = new HospitalAt2Context())
						{
							Database.Patient dbPat = db.Patients
								.Where(p => p.PkIdPatient == Int32.Parse(After[2]))
								.SingleOrDefault();

							//Генерация Primary Key
							// Получаем самый большой по значению первичный ключ
							var dbAccId = db.Accounts.OrderBy(p => p.PkIdAcc).LastOrDefault();
							// Если первичного ключа нет, то объявляем его как наименьший - '0'
							// Иначе увеличиваем наибольший первичный ключ на 1
							int idAcc;
							if (dbAccId != null)
								idAcc = dbAccId.PkIdAcc + 1;
							else
								idAcc = 0;

							Database.Account newAcc = new Database.Account()
							{
								PkIdAcc = idAcc,
								LoginAcc = After[0],
								PasswordAcc = After[1],
								PatientId = dbPat,
								OnlineAcc = false,
								TypeAcc = "Patient"
							};
							db.Accounts.Add(newAcc);
							db.SaveChanges();
						}
					}
					else if (Config[2] == "Doctor")
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							Database.Doctor dbDoc = db.Doctors
								.Where(p => p.PkIdDoctor == Int32.Parse(After[2]))
								.SingleOrDefault();

							//Генерация Primary Key
							// Получаем самый большой по значению первичный ключ
							var dbAccId = db.Accounts.OrderBy(p => p.PkIdAcc).LastOrDefault();
							// Если первичного ключа нет, то объявляем его как наименьший - '0'
							// Иначе увеличиваем наибольший первичный ключ на 1
							int idAcc;
							if (dbAccId != null)
								idAcc = dbAccId.PkIdAcc + 1;
							else
								idAcc = 0;

							Database.Account newAcc = new Database.Account()
							{
								PkIdAcc = idAcc,
								LoginAcc = After[0],
								PasswordAcc = After[1],
								DoctorId = dbDoc,
								OnlineAcc = false,
								TypeAcc = "Doctor"
							};
							db.Accounts.Add(newAcc);
							db.SaveChanges();
						}
					}
					else
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							Database.MedicalSecretary dbMedS = db.MedicalSecretaries
								.Where(p => p.PkIdMedS == Int32.Parse(After[2]))
								.SingleOrDefault();

							//Генерация Primary Key
							// Получаем самый большой по значению первичный ключ
							var dbAccId = db.Accounts.OrderBy(p => p.PkIdAcc).LastOrDefault();
							// Если первичного ключа нет, то объявляем его как наименьший - '0'
							// Иначе увеличиваем наибольший первичный ключ на 1
							int idAcc;
							if (dbAccId != null)
								idAcc = dbAccId.PkIdAcc + 1;
							else
								idAcc = 0;

							Database.Account newAcc = new Database.Account()
							{
								PkIdAcc = idAcc,
								LoginAcc = After[0],
								PasswordAcc = After[1],
								MedicalSecretaryId = dbMedS,
								OnlineAcc = false,
								TypeAcc = "MedicalSecretary"
							};
							db.Accounts.Add(newAcc);
							db.SaveChanges();
						}
					}
				}
			}

			this.Close();
		}

		private void buttonNo_Click(object sender, EventArgs e)
		{
			// Выйти из формы
			this.Close();
		}
	}
}
