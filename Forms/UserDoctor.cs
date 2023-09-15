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
	public partial class UserDoctor : Form
	{
		private Doctor user;
		private Form ParentForm; // ссылка на форму, которая вызвала текущую форму
		public UserDoctor(Form parentForm, string login)
		{
			InitializeComponent();
			user = new Doctor(login);
			ParentForm = parentForm;
		}
		private void buttonSingUpAppointment_Click(object sender, EventArgs e)
		{
			//SignUpAppointment f = new SignUpAppointment(this, User);
			//f.Show();
		}
		private void UserDoctor_FormClosed(object sender, FormClosedEventArgs e)
		{
			user.Destruction();
			ParentForm.Show();
		}

		private void buttonWatchSchedule_Click(object sender, EventArgs e)
		{
			WatchSchedule f = new WatchSchedule(this);
			f.Show();
		}

		private void buttonWatchAttandance_Click(object sender, EventArgs e)
		{
			WatchAttandance f = new WatchAttandance(this);
			f.Show();
		}

		private void buttonEditAttandance_Click(object sender, EventArgs e)
		{
			EditAttandance f = new EditAttandance(this);
			f.Show();
		}
	}
}
