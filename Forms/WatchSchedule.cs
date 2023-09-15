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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkAt4.Forms
{
	public partial class WatchSchedule : Form
	{
		private class DaySchedule
		{
			public string? TimeOfWork { get; set; }
			public int? DayOfWeek { get; set; }
		}
		private Form ParentForm; // ссылка на форму, которая вызвала текущую форму
		public WatchSchedule(
			Form parentForm)
		{
			InitializeComponent();
			ParentForm = parentForm;

			// Заполнение элементами comboBoxSpeciality
			using(HospitalAt2Context db = new HospitalAt2Context())
			{
				var specialityList = db.Doctors.Select(x => x.Speciality).Distinct().ToList();
				foreach(var speciality in specialityList)
				{
					comboBoxSpeciality.Items.Add(speciality);
				}
			}


			}

		private void comboBoxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Заполнение элементами comboBoxName
			string specialitySelect = comboBoxSpeciality.SelectedItem.ToString();

			// заполняем расписание врачей с выбранной специальностью
			using(HospitalAt2Context db = new HospitalAt2Context())
			{
				listViewSchedule.Items.Clear();
				var doctorList = db.Doctors.Where(p => p.Speciality == specialitySelect).ToList();
				foreach (var doctor in doctorList)
				{
					// weekSchedule содержит расписание текущего врача, которое есть в базе данных
					List<DaySchedule> weekSchedule = new List<DaySchedule>();
					var dbDOW = db.Schedules
						.Include(p => p.DoctorId)
						.Where(p => p.DoctorId.PkIdDoctor == doctor.PkIdDoctor)
						.Select(p => new
						{
							DayOfWeek = p.DayOfWeek!
						})
						.Distinct()
						.OrderBy(p => p.DayOfWeek)
						.ToList();
					foreach(var day in dbDOW)
					{
						var maxDI = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId.PkIdDoctor == doctor.PkIdDoctor
								&& p.DayOfWeek == day.DayOfWeek)
							.Max(p => p.DateInsert);
						// Определено:
						//		Врач
						//		День недели
						//		Момент последнего добавления расписания
						var dbDaySch = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId.PkIdDoctor == doctor.PkIdDoctor
								&& p.DayOfWeek == day.DayOfWeek
								&& p.DateInsert == maxDI)
							.SingleOrDefault();

						weekSchedule.Add(new DaySchedule()
						{
							//TimeOfWork = string.Format("{0:t}", (dbDaySch!.TimeStart.ToString()))
							//			+ ":" + string.Format("{0:t}", (dbDaySch.TimeEnd.ToString()))
							TimeOfWork = dbDaySch!.TimeStart.GetValueOrDefault().ToString(@"hh\:mm")
										+ " - " 
										+ dbDaySch.TimeEnd.GetValueOrDefault().ToString(@"hh\:mm")
							,DayOfWeek = day.DayOfWeek
						});
					}

					// Добавляем данные на экран
					ListViewItem doctorView = listViewSchedule.Items.Add(new ListViewItem(doctor.NameD));
					for (int i = 0; i <7; i++)
					{
						string? timeOfWork = null;
						foreach(var loc in weekSchedule)
						{
							if(i == loc.DayOfWeek)
								timeOfWork= loc.TimeOfWork;
						}
						if (!timeOfWork.IsNullOrEmpty())
							doctorView.SubItems.Add(timeOfWork);
						else
							doctorView.SubItems.Add("-");
					}

				}
			}
		}

	}
}
