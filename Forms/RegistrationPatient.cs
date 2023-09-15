using CourseWorkAt4.ClassLogic;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class RegistrationPatient : Form
	{
		private Form ParentForm;
		private Database.Patient DBPatient;
		private Hospital User;
		public RegistrationPatient(Form parentForm)
		{
			InitializeComponent();
			ParentForm = parentForm;
			User = new Hospital();
		}

		private void buttonEnter_Click(object sender, EventArgs e)
		{
			List<string> enterDataPatient;
			if (!textBoxLogin.Text.IsNullOrEmpty() &&
				!textBoxPassword.Text.IsNullOrEmpty() &&
				!textBoxName.Text.IsNullOrEmpty() &&
				!textBoxSurname.Text.IsNullOrEmpty() &&
				!textBoxPatronymic.Text.IsNullOrEmpty() &&
				!textBoxMedH.Text.IsNullOrEmpty())
			{
				enterDataPatient = new List<string>() { textBoxLogin.Text,
					textBoxPassword.Text, textBoxName.Text,
					textBoxSurname.Text, textBoxPatronymic.Text,
					textBoxMedH.Text};

				bool resultRegistration = User.RegistrationPatient(enterDataPatient);
				if (resultRegistration)
				{
					labelMsg.Text = "Регистрация прошла успешно";
				}
				else
				{
					labelMsg.Text = "Регистрация не удалась";
				}
			}
			else
			{
				labelMsg.Text = "Введите все данные";
			}
		}

		private void RegistrationPatient_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}
	}

}
