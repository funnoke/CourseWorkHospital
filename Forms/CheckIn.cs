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
	public partial class CheckIn : Form
	{
		Form ParentForm;
		public CheckIn(Form parentForm)
		{
			InitializeComponent();
			ParentForm = parentForm;
		}

		private void buttonDateNow_Click(object sender, EventArgs e)
		{
			DateTime dateTime= DateTime.Now;
			string dateTimeStr = dateTime.ToString(@"dd-MM-yyyy");
			maskedTextBoxTime.Text = dateTimeStr;
		}

		private void CheckIn_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}

		private void buttonWatchAppoint_Click(object sender, EventArgs e)
		{
			Database.Doctor doctor;
			DateTime dateSch;
			Database.Schedule schedule;
			// Проверим корректность введенных данных
			// Заполнены ли все поля
			if (!textBoxId.Text.IsNullOrEmpty()
				&& !maskedTextBoxTime.Text.IsNullOrEmpty())
			{
				// Проверм корректность введенного ID,
				// состоит ли Id только из цифр
				{
					Regex regex = new Regex(@"(\D)", RegexOptions.IgnoreCase);
					Match matches = regex.Match(textBoxId.Text);
					if (matches.Success)
					{   // в поле содержится что-то кроме цифр
						labelMsg.Text = "Поле с индентификатором должно содержать\nтолько цифры.";
						return;
					}
				}
				// ID состоит только из цифр
				// Проверим, существует ли врач с таким ID
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var dbDoc = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
					if (dbDoc is not null)
					{
						doctor = dbDoc;
					}
					else
					{
						labelMsg.Text = "Врача с таким ID нет";
						return;
					}
				}
				// Врач существует

				dateSch = DateTime.ParseExact(maskedTextBoxTime.Text, "dd-MM-yyyy",
								   System.Globalization.CultureInfo.InvariantCulture);
				// Проверим, есть ли у него часы приема на указанную дату
				try
				{
					DayOfWeek f = dateSch.DayOfWeek;
					int? myDayOfWeek;
					switch (f)
					{
						case DayOfWeek.Monday:
							myDayOfWeek = 0;
							break;
						case DayOfWeek.Tuesday:
							myDayOfWeek = 1;
							break;
						case DayOfWeek.Wednesday:
							myDayOfWeek = 2;
							break;
						case DayOfWeek.Thursday:
							myDayOfWeek = 3;
							break;
						case DayOfWeek.Friday:
							myDayOfWeek = 4;
							break;
						case DayOfWeek.Saturday:
							myDayOfWeek = 5;
							break;
						default:
							myDayOfWeek = 6;
							break;
					}
					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						// Находим последнюю дату добавления
						var schDate = db.Schedules
							.Include(p => p.DoctorId)
							.Where(p => p.DoctorId!.PkIdDoctor == doctor!.PkIdDoctor
								&& p.DayOfWeek == myDayOfWeek)
							.OrderBy(p => p.DateInsert)
							.LastOrDefault();
						// Если не нашли, значит врач в этот день не принимает
						if (schDate is null)
						{
							labelMsg.Text = "Неправильное время приема";
							return;
						}
						else
						{
							schedule = schDate;
						}

					}
					// Часы приема на указанную дату есть

					// Добавим данных для вставки в бд
					bool check = true;
					DateTime dateNow = DateTime.Now;

					// Все данные есть и верны:
					//		Ссылка на расписание - schedule
					//		отметка - check
					//		Сегодняшняя дата - dateNow

					// Вставим данные в бд
					using(HospitalAt2Context db = new HospitalAt2Context())
					{

						//Генерация Primary Key
						// Получаем самый большой по значению первичный ключ
						var dbAccId = db.CheckInDoctors.OrderBy(p => p.PkIdCheckInDoctor).LastOrDefault();
						// Если первичного ключа нет, то объявляем его как наименьший - '0'
						// Иначе увеличиваем наибольший первичный ключ на 1
						int idAcc;
						if (dbAccId != null)
							idAcc = dbAccId.PkIdCheckInDoctor + 1;
						else
							idAcc = 0;

						Database.Schedule? locSch = db.Schedules
							.Where(p => p.PkIdSchedule == schedule.PkIdSchedule)
							.SingleOrDefault();

						Database.CheckInDoctor newCheck = new Database.CheckInDoctor()
						{
							PkIdCheckInDoctor= idAcc,
							DateCheckIn = dateNow,
							CheckIn= check,
							FkIdSchedule= locSch.PkIdSchedule,
							ScheduleId = locSch
						};
						db.CheckInDoctors.Add(newCheck);
						db.SaveChanges();
					}
					labelMsg.Text = "Отметка успешно добавлена";

				}
				catch
				{
					labelMsg.Text = "Время введено неверно";
				}
			}
			else
			{
				labelMsg.Text = "Введите все данные";
			}
		}
	}
}
