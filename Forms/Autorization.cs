using CourseWorkAt4.ClassLogic;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Logging;
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
	public partial class Autorization : Form
	{
		private Hospital User = new Hospital();
		public Autorization()
		{
			InitializeComponent();
			ClassLogic.Hospital.AddAdminAccount();
		}

		private void Autorization_FormClosed(object sender, FormClosedEventArgs e)
		{
			User.Destruction();

		}

		private void tableLayoutPanelGeneric_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tableLayoutPanelGeneric_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void buttonLogIn_Click_1(object sender, EventArgs e)
		{
			string login = textBoxLogin.Text;
			string password = textBoxPassword.Text;
			if (!(login.IsNullOrEmpty()) && !(password.IsNullOrEmpty()))
			{
				string resultAutorization = User.Autorization(login, password);
				if (resultAutorization == "110")            // Пользователь успешно авторизовался и это Medical Secritary
				{
					UserMedS f = new UserMedS(this, login);
					f.Show();
					labelMsg.Text = "";
					Hide();
				}
				else if (resultAutorization == "111")   // Пользователь успешно авторизовался и это Doctor
				{
					UserDoctor f = new UserDoctor(this, login);
					f.Show();
					labelMsg.Text = "";
					Hide();
				}
				else if (resultAutorization == "112")   // Пользователь успешно авторизовался и это Patient
				{
					UserPatient f = new UserPatient(this, login);
					f.Show();
					labelMsg.Text = "";
					Hide();
				}
				else if (resultAutorization == "113")   // Пользователь успешно авторизовался и это Admin
				{
					UserAdmin f = new UserAdmin(this);
					f.Show();
					labelMsg.Text = "";
					Hide();
				}
				else if (resultAutorization == "100")   // Login и Password верны, но пользователь уже в сети
				{
					labelMsg.Text = "Этот пользователь уже в сети";
				}
				else if (resultAutorization == "000")   // Login или Password не верны
				{
					labelMsg.Text = "Логин или пароль не верны";
				}
				else
				{
					labelMsg.Text = "Неизвестная ошибка";
				}
			}
			else labelMsg.Text = "";

		}

		private void buttonSignUp_Click(object sender, EventArgs e)
		{
			RegistrationPatient f = new RegistrationPatient(this);
			f.Show();
			labelMsg.Text = "";
			Hide();
		}

		private void textBoxLogin_Enter(object sender, EventArgs e)
		{

		}
	}
}
