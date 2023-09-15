using CourseWorkAt4.ClassLogic;
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
	public partial class UserPatient : Form
	{
		private ClassLogic.Patient User;
		private Form ParentForm; // ссылка на форму, которая вызвала текущую форму
		public UserPatient(Form parentForm, string login)
		{
			InitializeComponent();
			User = new Patient(login);
			ParentForm = parentForm;
		}
		private void buttonSingUpAppointment_Click(object sender, EventArgs e)
		{
			SignUpAppointment f = new SignUpAppointment(this, User);
			f.Show();
		}

		private void UserPatient_FormClosed(object sender, FormClosedEventArgs e)
		{
			User.Destruction();
			ParentForm.Show();
		}

		private void buttonWatchSchedule_Click(object sender, EventArgs e)
		{
			WatchSchedule f = new WatchSchedule(this);
			f.Show();
		}

		private void buttonEditService_Click(object sender, EventArgs e)
		{
			try
			{
				WatchAttandance f = new WatchAttandance(this, User);
				f.Show();
			}
			catch
			{

			}
		}
	}
}
