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
	public partial class AdministrationAcc : Form
	{
		private Form ParentForm;
		private ClassLogic.Hospital User;
		private string TypeUser;
		public AdministrationAcc(Form parentForm, string typeUser, ClassLogic.Hospital user)
		{
			InitializeComponent();
			ParentForm = parentForm;
			TypeUser = typeUser;
			User = user;
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
			 *		[2] = Специальность врача (для пользователей с типом 'Doctor')]
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
									return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует.\n") };
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
									return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует.\n") };
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
									return new List<string> { "0", ("Пользователя с таким идентификатором еще не существует.\n") };
							}
						}
						else
							return new List<string> { "0", "Некорректный тип пользователя" };
					}
				}
				else
					// если идентификатор не введен, то пользователя пытаются создать
					return new List<string> { "0", "Введите идентификатор пользователя"
											, "ThisErrorIsNotForSaveChanges"};
			}
			else
				return new List<string> { "0", "Выберите тип пользователя" };
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			List<string> resultCheck = User.CheckUserTypeAndId(comboBoxUserType.SelectedIndex, textBoxId.Text);
			if (resultCheck[0] == "1")
			{
				labelName.Text = resultCheck[1];
				labelMsg.Text = string.Empty;
			}
			else
			{
				if (resultCheck.Count > 1)
				{
					labelMsg.Text = resultCheck[1];
					labelName.Text = string.Empty;
				}
			}

		}

		private void buttonCreateUser_Click(object sender, EventArgs e)
		{
			AdministrationUser f = new AdministrationUser(this, TypeUser, User);
			f.Show();
			Hide();
		}

		private void AdministrationAcc_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}

		private List<string> CheckUserAccToBe(string typeUser, string idUser)
		{
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				if (typeUser == "Doctor")
				{
					var user = db.Accounts
						.Include(p => p.DoctorId)
						.Where(p => p.DoctorId!.PkIdDoctor == Int32.Parse(idUser))
						.SingleOrDefault();
					if (user is null)
						return new List<string> { "0" };
					else
						return new List<string> { "1", user.PkIdAcc.ToString() };
				}
				else if (typeUser == "Patient")
				{
					var user = db.Accounts
						.Include(p => p.PatientId)
						.Where(p => p.PatientId!.HealthInsurance == Int32.Parse(idUser))
						.SingleOrDefault();
					if (user is null)
						return new List<string> { "0" };
					else
						return new List<string> { "1", user.PkIdAcc.ToString() };
				}
				else
				{
					var user = db.Accounts
						.Include(p => p.MedicalSecretaryId)
						.Where(p => p.MedicalSecretaryId!.PkIdMedS == Int32.Parse(idUser))
						.SingleOrDefault();
					if (user is null)
						return new List<string> { "0" };
					else
						return new List<string> { "1", user.PkIdAcc.ToString() };
				}
				return new List<string> { "0" };
			}
		}

		private void buttonSaveChanges_Click(object sender, EventArgs e)
		{
			string enteredUserType = comboBoxUserType.Text;
			string selectUserType = comboBoxUserType.SelectedIndex.ToString();

			if (!textBoxLogin.Text.IsNullOrEmpty() && !textBoxPassword.Text.IsNullOrEmpty())
			{
				List<string> resultCheck = User.CheckUserTypeAndId(comboBoxUserType.SelectedIndex, textBoxId.Text);
				if (resultCheck[0] == "1")
				{   // Пользователь с таким Id существует, поэтому мы можем создать либо изменить его аккаунт
					List<string> resultCheckAcc = CheckUserAccToBe(enteredUserType, textBoxId.Text);
					if (resultCheckAcc[0] == "1")
					// Аккаунт существует и нужно его изменить
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							// Проверим, есть ли в базе данных аккаунт с логином
							// таким же, как и введенный в форме
							var dbAccLog = db.Accounts
								.Where(p => p.LoginAcc == textBoxLogin.Text)
								.ToList();
							if (dbAccLog.Count != 0)
							{
								labelMsg.Text = "Такой логин уже занят, попробуйте другой";
								return;
							}

							Database.Account? userAcc = db.Accounts
								.Where(p => p.PkIdAcc == Int32.Parse(resultCheckAcc[1]))
								.SingleOrDefault();
							if (userAcc != null)
							{
								ConfirmActions f = new ConfirmActions(this
																	, new List<string>	// config
																		{ "Account"
																		, "Edit"
																		, enteredUserType}
																	, new List<string>  // after
																		{ textBoxLogin.Text
																		, textBoxPassword.Text
																		, userAcc.PkIdAcc.ToString()
																		}
																	, new List<string>  // before
																		{ userAcc.LoginAcc
																		, userAcc.PasswordAcc
																		, userAcc.PkIdAcc.ToString()
																		}
																	);
								f.Show();
							}
							else
								labelMsg.Text = "Что-то не так пошло где-то...";
						}

					}
					else
					// Аккаунта нет, его нужно создать
					{
						using (HospitalAt2Context db = new HospitalAt2Context())
						{
							// Проверим, есть ли в базе данных аккаунт с логином
							// таким же, как и введенный в форме
							var dbAccLog = db.Accounts
								.Where(p => p.LoginAcc == textBoxLogin.Text)
								.ToList();
							if (dbAccLog.Count != 0)
							{
								labelMsg.Text = "Такой логин уже занят, попробуйте другой";
								return;
							}
						}

						string id = textBoxId.Text;
						if (enteredUserType == "Patient")
						{
							using (HospitalAt2Context db = new HospitalAt2Context())
							{
								Patient dbPat = db.Patients.Where(p => p.HealthInsurance == Int32.Parse(textBoxId.Text)).SingleOrDefault();
								id = dbPat!.PkIdPatient.ToString();
							}
						}
						ConfirmActions f = new ConfirmActions(this
															, new List<string>  // config
																{ "Account"
																, "Create"
																, enteredUserType}
															, new List<string>  // after
																{ textBoxLogin.Text
																, textBoxPassword.Text
																, id
																, labelName.Text}
															);
						f.Show();

					}


				}
				else
				{   // Возникла какая-то ошибка
					labelMsg.Text = resultCheck[1];
				}
			}
			else
			{
				labelMsg.Text = "Введите логин и пароль.";
			}
		}
	}
}
