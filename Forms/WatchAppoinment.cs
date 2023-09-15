using CourseWorkAt4.Database;
using Microsoft.EntityFrameworkCore;
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
	public partial class WatchAppoinment : Form
	{
		Form ParentForm;
		Database.Doctor Doc;
		DateTime DateApp;
		Database.Schedule Sch;
		public WatchAppoinment(Form parentForm, Database.Doctor doctor,Database.Schedule schedule, DateTime dateApp)
		{
			InitializeComponent();
			ParentForm = parentForm;
			Doc = doctor;
			DateApp = dateApp;
			Sch = schedule;

			labelName.Text = doctor.NameD;
			labelDate.Text = dateApp.ToString(@"dd-MM-yyyy");
			labelTime.Text = schedule.TimeStart.GetValueOrDefault().ToString(@"hh\:mm")
										+ " - "
										+ schedule.TimeEnd.GetValueOrDefault().ToString(@"hh\:mm");
			using(HospitalAt2Context db = new HospitalAt2Context())
			{
				var dbApp = db.Appointments
					.Include(p => p.DoctorId)
					.Include(p => p.PatientId)
					.Where(p => p.FkIdDoctor == doctor.PkIdDoctor)
					.ToList();
				if (dbApp != null)
				{
					foreach (var oneApp in dbApp)
					{
						if (oneApp.DateAndTime.GetValueOrDefault().Date == dateApp.Date)
						{
							ListViewItem app = listViewApp.Items.Add(new ListViewItem(oneApp.PatientId.NamePatient));
							app.SubItems.Add(oneApp.DateAndTime.GetValueOrDefault().ToString(@"HH:mm"));
						}
					}
				}
			}
		}

		private void WatchAppoinment_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}
	}
}
