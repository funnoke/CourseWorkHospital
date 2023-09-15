using CourseWorkAt4.Database;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CourseWorkAt4.Forms
{
	public partial class AdministrationUser : Form
	{
		private Form ParentForm;
		private ClassLogic.Hospital User;
		private string TypeUser;
		public AdministrationUser(Form parentForm, string typeUser, ClassLogic.Hospital user)
		{
			InitializeComponent();
			ParentForm = parentForm;
			TypeUser = typeUser;

			if (typeUser == "Admin")
				comboBoxUserType.Items.AddRange(new string[] { "Doctor", "Patient", "Medical Secretary" });
			else
				comboBoxUserType.Items.AddRange(new string[] { "Doctor", "Patient" });
			User = user;
		}

		private List<string> CheckUserTypeAndId(string enteredUserType, string selectUserType)
		{
			/* Функция проверяет корректность типа пользователя и его идентификатора
			 * Возвращает список строк
			 * [0] = 0/1 - верны ли данные (1 - верны, 0 - не верны)
			 * Если [0] = 0, то
			 *		[1] = Сообщение об ошибке
			 *		[2] = флаг, показывающий, что данная ошибка не является валидной
			 *				при вызове функции из SaveChanges
			 * Если [0] = 1, то
			 *		[1] = Поле Name
			 *		[[2] = Специальность врача (для пользователей с типом 'Doctor')]
			 */
			// Проверим введены ли данные в поля
			if (!(selectUserType == "-1") && !enteredUserType.IsNullOrEmpty())
			{
				string enteredId = textBoxId.Text;
				if (!enteredId.IsNullOrEmpty())
				{
					// Проверим, состоит ли Id только из цифр
					Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(enteredId);
					if (matches.Success)
					{   // в поле содержится что-то кроме цифр
						return new List<string> { "0", "Поле с индентификатором должно содержать\nтолько цифры." };
					}
					else
					{
						if (selectUserType == "0"
							|| enteredUserType == "Doctor") // Doctor
						{
							using (HospitalAt2Context db = new HospitalAt2Context())
							{
								var docUser = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(enteredId)).SingleOrDefault();
								if (docUser != null)
								{   // Пользователь найден
									return new List<string> { "1", docUser.NameD, docUser.Speciality };
								}
								else// Пользователя с таким идентификатором не существует
									return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует\n"
															+ "Вы можете создать пользователя с таким ID")
															, "ThisErrorIsNotForSaveChanges"};
							}
						}
						else if (selectUserType == "1"
							|| enteredUserType == "Patient") // Patient
						{
							using (HospitalAt2Context db = new HospitalAt2Context())
							{
								var patUser = db.Patients.Where(p => p.HealthInsurance == Int32.Parse(enteredId)).SingleOrDefault();
								if (patUser != null)
								{   // Пользователь найден
									return new List<string> { "1", patUser.NamePatient };
								}
								else// Пользователя с таким идентификатором не существует
									return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует\n"
															+ "Вы можете создать пользователя с таким ID")
															, "ThisErrorIsNotForSaveChanges"};
							}
						}
						else if (selectUserType == "2"
							|| enteredUserType == "Medical Secretary") // Medical Secretary
						{
							using (HospitalAt2Context db = new HospitalAt2Context())
							{
								var medSUser = db.MedicalSecretaries.Where(p => p.PkIdMedS == Int32.Parse(enteredId)).SingleOrDefault();
								if (medSUser != null)
								{   // Пользователь найден
									return new List<string> { "1", medSUser.NameMedS };
								}
								else// Пользователя с таким идентификатором не существует
									return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует\n"
															+ "Вы можете создать пользователя с таким ID")
															, "ThisErrorIsNotForSaveChanges"};
							}
						}
						else
							return new List<string> { "0", "Некорректный тип пользователя" };
					}
				}
				else
					// если идентификатор не введен, то пользователя пытаются создать
					return new List<string> { "0", "Введите идентификатор пользователя" };
			}
			else
				return new List<string> { "0", "Выберите тип пользователя" };
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			List<string> resultCheck = User.CheckUserTypeAndId(comboBoxUserType.SelectedIndex, textBoxId.Text);
			if (resultCheck[0] == "1")
			{
				textBoxName.Text = resultCheck[1];
				if (resultCheck.Count > 2)
				{
					textBoxSpeciality.Text = resultCheck[2];
				}
				labelMsg.Text = "";
			}
			else
			{
				if (resultCheck.Count > 1)
				{
					labelMsg.Text = resultCheck[1];
				}
			}

		}

		private List<string> CheckNameAndSpeciality(string userType, string name, string specialityOrHI)
		{
			/*	Функция проверяет корректность имени пользователя (и/или специальности (для врача))
			 *														(и/или мед. полис (для пациента))
			 *	Вовращает список типа string
			 *	[0] = 0/1 - не корректные либо корректные данные
			 *	Если [0] = 0, то
			 *		[1] = Сообщение об ошибке
			 */
			if (name != null)
			{   // Имя пользователя введено

				//	Проверка на корректность поля Name
				//	Проверка на наличие чего-то кроме букв
				{
					Regex regex = new Regex(@"(\d)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(name);
					Regex regex2 = new Regex(@"(\W)", RegexOptions.IgnoreCase);
					Match matches2 = regex.Match(name);
					if (matches.Success || matches2.Success)
						return new List<string> { "0", "Имя может содержать только буквы" };

				}

				if (userType == "Doctor")
				{   // Тип пользователя - Врач
					// Проверим Speciality на корректность
					if (specialityOrHI == null)
						return new List<string> { "0", "Специальность врача не введена" };
					else
					{   // Проверка на налицие цифр 
						Regex regexName = new Regex(@"(\d)", RegexOptions.IgnoreCase);
						Match matchesName = regexName.Match(specialityOrHI);
						if (matchesName.Success)
							return new List<string> { "0", "Специальность врача может содержать только буквы" };
					}
					return new List<string> { "1" };
				}
				else if (userType == "Patient")
				{   // Тип пользователя - Пациент
					return new List<string> { "1" };
				}
				else
				{   // Тип пользователя - Регистратор
					return new List<string> { "1" };
				}
			}
			else
				return new List<string> { "0", "Имя пользователя не введено" };
		}
		private void buttonSaveChanges_Click(object sender, EventArgs e)
		{
			string enteredUserType = comboBoxUserType.Text;
			string selectUserType = comboBoxUserType.SelectedIndex.ToString();

			List<string> resultSaveChanges = CheckNameAndSpeciality(enteredUserType, textBoxName.Text, textBoxSpeciality.Text);
			if (resultSaveChanges[0] == "1")
			{
				List<string> resultCheck = CheckUserTypeAndId(enteredUserType, selectUserType);
				if (resultCheck[0] == "1")
				{   // Пользователь с таким Id существует, поэтому мы изменяем данные, а не создаем нового пользователя
					if (enteredUserType == "Doctor")
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							Doctor? userDoc = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
							if (userDoc != null)
							{
								ConfirmActions f = new ConfirmActions(this
																	, new List<string>	// config
																		{ "User"
																		, "Doctor" }
																	, new List<string>  // after
																		{ textBoxName.Text
																		, textBoxSpeciality.Text
																		, userDoc.PkIdDoctor.ToString()}
																	, new List<string>  // before
																		{ userDoc.NameD
																		, userDoc.Speciality
																		, userDoc.PkIdDoctor.ToString()}
																	);
								f.Show();
							}
							else
								labelMsg.Text = "Что-то не так пошло где-то...";
						}
					}
					else if (enteredUserType == "Patient")
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							Patient? userPat = db.Patients.Where(p => p.HealthInsurance == Int32.Parse(textBoxId.Text)).SingleOrDefault();
							if (userPat != null)
							{
								ConfirmActions f = new ConfirmActions(this
																	, new List<string>	// config
																		{ "User"
																		, "Patient" }
																	, new List<string>	// after
																		{ textBoxName.Text
																		, textBoxId.Text
																		, textBoxId.Text}
																	, new List<string>	// before
																		{ userPat.NamePatient
																		, userPat.HealthInsurance.ToString()
																		, userPat.HealthInsurance.ToString()}
																	);
								f.Show();
							}
							else
								labelMsg.Text = "Что-то не так пошло где-то...";
						}
					}
					else
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							MedicalSecretary? userMedS = db.MedicalSecretaries.Where(p => p.PkIdMedS == Int32.Parse(textBoxId.Text)).SingleOrDefault();
							if (userMedS != null)
							{
								ConfirmActions f = new ConfirmActions(this
																	, new List<string>	// config
																		{ "User"
																		, "Medical Secretary" }
																	, new List<string>	// after
																		{ textBoxName.Text
																		, ""
																		, userMedS.PkIdMedS.ToString()}
																	, new List<string>	// before
																		{ userMedS.NameMedS
																		, ""
																		, userMedS.PkIdMedS.ToString()}
																	);
								f.Show();
							}
							else
								labelMsg.Text = "Что-то не так пошло где-то...";
						}
					}

				}
				else if (resultCheck.Count == 2)
				{   // Возникла какая-то ошибка
					labelMsg.Text = resultCheck[1];
				}
				else
				{   // Идентификатор пользователя не введен, значит мы создаем пользователя
					if (enteredUserType == "Doctor")
					{
						ConfirmActions f = new ConfirmActions(this
															, new List<string>	// config
																{ "User"
																, "Doctor" }
															, new List<string>  // new
																{ textBoxName.Text
																, textBoxSpeciality.Text
																, textBoxId.Text}
															);
						f.Show();
					}
					else if (enteredUserType == "Patient")
					{
						ConfirmActions f = new ConfirmActions(this
															, new List<string>	// config
																{ "User"
																, "Patient" }
															, new List<string>  // new
																{ textBoxName.Text
																, textBoxId.Text
																, textBoxId.Text}
															);
						f.Show();
					}
					else
					{
						ConfirmActions f = new ConfirmActions(this
															, new List<string>	// config
																{ "User"
																, "Medical Secretary" }
															, new List<string>  // new
																{ textBoxName.Text
																, ""
																, textBoxId.Text}
															);
						f.Show();
					}
				}
			}
			else
			{
				labelMsg.Text = resultSaveChanges[1];
			}
		}

		private void AdministrationUser_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}


	}
}
