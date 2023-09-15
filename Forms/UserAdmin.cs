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
	public partial class UserAdmin : Form
	{
		private Form ParentForm;
		private ClassLogic.Hospital User;
		public UserAdmin(Form parentForm)
		{
			InitializeComponent();
			ParentForm = parentForm;
			User= new ClassLogic.Hospital();
		}

		private void UserAdmin_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}

		private void buttonAddUser_Click(object sender, EventArgs e)
		{
			AdministrationUser f = new AdministrationUser(this, "Admin", User);
			f.Show();
		}

		private void buttonAddAcc_Click(object sender, EventArgs e)
		{
			AdministrationAcc f = new AdministrationAcc(this, "Admin", User);
			f.Show();
		}
	}
}
