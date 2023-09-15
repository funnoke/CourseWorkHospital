//-----------------------ClassLogic.Hospital
using CourseWorkAt4.Database;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CourseWorkAt4.ClassLogic
{
	public class Hospital
	{
		protected int? AccId;
		public int? UserId;
		public static void AddAdminAccount()
		{
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				var dbAcc = db.Accounts.Where(p => p.LoginAcc == "admin").SingleOrDefault();
				if (dbAcc == null)
				{
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

					Account admAcc = new Account()
					{
						PkIdAcc = idAcc,
						LoginAcc = "admin",
						PasswordAcc = "pass",
						OnlineAcc = false,
						TypeAcc = "Admin"
					};
					db.Accounts.Add(admAcc);
					db.SaveChanges();
				}
			}
		}

		//	Проверка строки на содержание цифр
		//	true - в строке только цифры
		//	false - в строке есть что-то кроме цифр
		protected bool CheckStringOnDigit(string str)
		{
			Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
			Match matches = regex.Match(str);
			if (matches.Success)
			{   // в поле содержится что-то кроме цифр
				return false;
			}
			return true;
		}

		//	Функция проверяет, существует ли пользователь с указанным ID
		public List<string> CheckUserIdOnBe(int typeUser, int userId)
		{
			/*	Функция проверяет, существует ли пользователь с указанным ID
			 *	Принимает:
			 *		typeUser - тип пользователя
			 *			0 - Doctor
			 *			1 - Patient
			 *			2 - MedicalSecretary
			 *		userId - идентификатор пользователя
			 *			(либо мед. полис для typeUser = 1)
			 *	Возвращает:
			 *		Возвращает список строк
			 *		[0] = 0/1 - верны ли данные (1 - верны, 0 - не верны)
			 *		Если [0] = 0, то
			 *				[1] = Сообщение об ошибке
			 *				[2] = флаг, показывающий, что данная ошибка не является валидной
			 *						при вызове функции из SaveChanges
			 *		 Если [0] = 1, то
			 *				[1] = Поле Name
			 *				[2] = Специальность врача (для пользователей с типом 'Doctor')]
			 */
			if (typeUser == 0) // Doctor
			{
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var docUser = db.Doctors.Where(p => p.PkIdDoctor == userId).SingleOrDefault();
					if (docUser != null)
					{   // Пользователь найден
						return new List<string> { "1", docUser.NameD, docUser.Speciality };
					}
					else// Пользователя с таким идентификатором не существует
						return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует.\n") };
				}
			}
			else if (typeUser == 1) // Patient
			{
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var patUser = db.Patients.Where(p => p.HealthInsurance == userId).SingleOrDefault();
					if (patUser != null)
					{   // Пользователь найден
						return new List<string> { "1", patUser.NamePatient };
					}
					else// Пользователя с таким идентификатором не существует
						return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует.\n") };
				}
			}
			else if (typeUser == 2) // Medical Secretary
			{
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var medSUser = db.MedicalSecretaries.Where(p => p.PkIdMedS == userId).SingleOrDefault();
					if (medSUser != null)
					{   // Пользователь найден
						return new List<string> { "1", medSUser.NameMedS };
					}
					else// Пользователя с таким идентификатором не существует
						return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует.\n") };
				}
			}
			else
				return new List<string> { "0", "Некорректный тип пользователя" };

		}
		public Hospital()
		{
			//AddAdminAccount();
		}

		public string Autorization(string login, string password)
		{
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				/* Функция возвращает трехзначное число xyz в виде строки
				 * x = 0/1, 0 - Логин и пароль не правильны, 1 - логин и пароль верны
				 * y = 0/1, 0 - такой пользователь уже в сети, 1 - пользователя с такими данными еще нет в сети
				 * z = 0/1/2 - тип пользователя:
				 *				0 - Medical Secretary
				 *				1 - Doctor
				 *				2 - Patient
				 *				3 - Admin
				 */
				
				// Получение данных из бд
				var dbAcc = db.Accounts.ToList();
				// Проверка данных
				foreach (Account acc in dbAcc)
				{
					if (acc.LoginAcc == login && acc.PasswordAcc == password)
					{
						if (acc.OnlineAcc == false)
						// Если введенные данные верны
						{
							//acc.OnlineAcc = true;
							//db.SaveChanges();
							this.AccId = acc.PkIdAcc;
							if (acc.TypeAcc == "MedicalSecretary")
								return "110";
							else if (acc.TypeAcc == "Doctor")
								return "111";
							else if (acc.TypeAcc == "Patient")
								return "112";
							else if (acc.TypeAcc == "Admin")
								return "113";
							else
								return "000";
						}
						else
						{
							return "100";
						}
					}
				}
				return "000";
			}

		}

		// !!!Сделать функцию регистрации универсальной!!!
		public bool RegistrationPatient(List<string> dataPatient)
		{
			/*	Функция регистрации Пациентов возвращает значение bool
			 *	true - регистрация прошла успешна
			 *	false - регистрация не удалась
			 */

		//Проверка на корректность полученного списка
			if(dataPatient.IsNullOrEmpty() || dataPatient.Count!= 6 )
			{ return false; }
		//Проверка данных на корректность пациента для добавления в бд
			string login = dataPatient[0];
			string password = dataPatient[1];
			string name = dataPatient[2].ToString() + " " + dataPatient[3].ToString() + " " + dataPatient[4].ToString();
			string MedH = dataPatient[5];
		// Проверка на налицие цифр поля name
			Regex regexName = new Regex(@"(\d)", RegexOptions.IgnoreCase);
			Match matchesName = regexName.Match(name);
			if (matchesName.Success)
				return false;
		// Проверка мед полиса на наличие чего-то кроме цифр
			Regex regexMedH = new Regex(@"(\D)", RegexOptions.IgnoreCase);
			Match matchesMedH = regexMedH.Match(MedH);
			if (matchesMedH.Success)
				return false;
		// Проверка идентичности Login
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				var dbAcc = db.Accounts.Where(p => p.LoginAcc == login).ToList();
				if (dbAcc.Count != 0)
				{
					return false;
				}
			}
			Database.Patient patient = new Database.Patient();
		// Проверка на наличие пациента в бд и добавление пациента в случае его отсутствия
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				var dbPat = db.Patients.Where(p => p.HealthInsurance == int.Parse(MedH)).SingleOrDefault();
				if (dbPat != null)
				{
					// Проверка на наличия аккаунта у такого пациента
					// Если найдется такой пациент, значит у него уже есть аккаунт
					var dbAccPat = db.Accounts.Where(p => p.PatientId!.PkIdPatient == dbPat.PkIdPatient).SingleOrDefault();
					if (dbAccPat != null)
						return false;
					// Если пациент уже есть в базе данных, но у него нет учетной записи,
					// то его не нужно добавлять в бд повторно
					else
					{
						patient = dbPat;
					}
				}
				else
				// Если пациента еще нет в базе данных, то его не нужно добавить
				{
					//Добавление пациента в бд
					using (HospitalAt2Context db2 = new HospitalAt2Context())
					{
						//Генерация Primary Key
						// Получаем самый большой по значению первичный ключ
						var dbPatId = db2.Patients.OrderBy(p => p.PkIdPatient).LastOrDefault();
						// Если первичного ключа нет, то объявляем его как наименьший - '0'
						// Иначе увеличиваем наибольший первичный ключ на 1
						if (dbPatId != null)
							patient.PkIdPatient = dbPatId.PkIdPatient + 1;
						else
							patient.PkIdPatient = 0;
						patient.NamePatient = name;
						patient.HealthInsurance = int.Parse(MedH);
						db2.Patients.Add(patient);
						db2.SaveChanges();
					}
				}
			}
		// Добавление Account 
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
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
				Account newUser = new Account()
				{
					PkIdAcc = idAcc,
					LoginAcc = login,
					PasswordAcc = password,
					OnlineAcc = false,
					TypeAcc = "Patient",
					//FKIdPatient = patient.PkIdPatient,
					/* сделать добавление внешнего ключа на 
						* на уже существующий элемент
						*/
					//PatientId = patient
				};
				using (HospitalAt2Context db2 = new HospitalAt2Context())
				{
					db2.Accounts.Add(newUser);
					db2.SaveChanges();
				}
				newUser.FKIdPatient = patient.PkIdPatient;
				newUser.PatientId = patient;
				db.Accounts.Update(newUser);
				db.SaveChanges();
				return true;
			}

		}

		//	Проверка типа пользователя и ID
		public List<string> CheckUserTypeAndId(int checkType, string checkId)
		{
			/* Функция проверяет корректность типа пользователя и его идентификатора
			 *		при добавлении пользователя или аккаунта
			 * Принимает:
			 *		checkType - тип пользователя
			 *			0 - Doctor
			 *			1 - Patient
			 *			2 - MedicalSecretary
			 *		checkId	- ID пользователя
			 *			(у пациента это мед. полис)
			 * Возвращает список строк
			 * [0] = 0/1 - верны ли данные (1 - верны, 0 - не верны)
			 * Если [0] = 0, то
			 *		[1] = Сообщение об ошибке
			 *		[2] = флаг, показывающий, что данная ошибка не является валидной
			 *				при вызове функции из SaveChanges
			 * Если [0] = 1, то
			 *		[1] = Поле Name
			 *		[2] = Специальность врача (для пользователей с типом 'Doctor')]
			 */
			//	Проверим, переданы ли данные
			if(!(checkType == -1 || checkId.IsNullOrEmpty()))
			{
				//	Если данные введены, то
				//	Проверим, состоит ли Id только из цифр
				if(CheckStringOnDigit(checkId)) 
				{
					//	Если ID состоит только из цифр
					return CheckUserIdOnBe(checkType, Int32.Parse(checkId));
				}
				else
				{
					return new List<string> { "0", "ID пользователя может содержать \nтолько цифры" };
				}
			}
			else
			{
				return new List<string> { "0", "Выберите тип пользователя и введите ID" };
			}
		}
		public virtual void Destruction() { }
	}
}
