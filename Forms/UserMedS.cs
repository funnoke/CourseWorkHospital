using CourseWorkAt4.Forms;
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

namespace CourseWorkAt4.Forms
{
	public partial class UserMedS : Form
	{
		private MedicalSecretary User;
		private Form ParentForm; // ссылка на форму, которая вызвала текущую форму
		public UserMedS(Form parentForm, string login)
		{
			InitializeComponent();
			User = new MedicalSecretary(login);
			ParentForm = parentForm;
		}

		private void UserMedS_FormClosed(object sender, FormClosedEventArgs e)
		{
			User.Destruction();
			//Application.OpenForms[0].Show();
			ParentForm.Show();
		}

		private void buttonSingUpAppointment_Click(object sender, EventArgs e)
		{
			SignUpAppointment f = new SignUpAppointment(this, User);
			f.Show();
		}

		private void buttonWatchSchedule_Click(object sender, EventArgs e)
		{
			WatchSchedule f = new WatchSchedule(this);
			f.Show();
		}

		private void buttonAddAcc_Click(object sender, EventArgs e)
		{
			AdministrationAcc f = new AdministrationAcc(this, "Medical Secretary", User);
			f.Show();
		}

		private void buttonAddUser_Click(object sender, EventArgs e)
		{
			AdministrationUser f = new AdministrationUser(this, "Medical Secretary", User);
			f.Show();
		}

		private void buttonEditSchedule_Click(object sender, EventArgs e)
		{
			EditSchedule f = new EditSchedule(this);
			f.Show();
		}

		private void buttonCheckSchedule_Click(object sender, EventArgs e)
		{
			CheckIn f = new CheckIn(this);
			f.Show();
		}
	}
}