using CourseWorkAt4.Database;
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
	public partial class EditSchedule : Form
	{
		private Form ParentForm;
		public EditSchedule(Form parentForm)
		{
			InitializeComponent();
			ParentForm = parentForm;

			// Заполним textBox с днями недели
			comboBoxDayOfWeek.Items.AddRange(new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" });
		}

		private void buttonSaveChanges_Click(object sender, EventArgs e)
		{
			
			int? docId = null;
			// Проверим содержимое Name и ID
			if (textBoxName.Text.IsNullOrEmpty())
			{
				if (!textBoxId.Text.IsNullOrEmpty())
				{
					using (HospitalAt2Context db = new HospitalAt2Context())
					{
						var dbDoc = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
						if (dbDoc is not null)
						{
							docId = dbDoc.PkIdDoctor;
						}
					}
				}
				else
				{
					labelMsg.Text = "Введите имя врача..";
					return;
				}
			}
			// Проверим если ли врач с таким именем
			// и если их несколько, то проверим еще ID
			else
			{
				using (HospitalAt2Context db = new HospitalAt2Context())
				{
					var dbDoc = db.Doctors.Where(p => p.NameD == textBoxName.Text).ToList();
					if (dbDoc is null)
					{
						labelMsg.Text = "Такого врача нет в системе";
						return;
					}
					else if (dbDoc.Count() > 1)
					{
						if (!textBoxId.Text.IsNullOrEmpty())
						{
							var dbDoc2 = db.Doctors.Where(p => p.PkIdDoctor == Int32.Parse(textBoxId.Text)).SingleOrDefault();
							if (dbDoc2 is null)
							{
								labelMsg.Text = "Врачей с таким именем и ID не найдено.";
								return;
							}
							else
							{
								docId = dbDoc2.PkIdDoctor;
							}
						}
						else
						{
							labelMsg.Text = "Врачей с таким именем несколько, введите дополнительно ID";
							return;
						}
					}
					else if(dbDoc.Count ==1) 
					{
						Database.Doctor doc = dbDoc.Single();
						docId = doc.PkIdDoctor;
					}
				}
			}

			// Проверим поля с временем
			if (maskedTextBoxEndTime.Text.IsNullOrEmpty()
				|| maskedTextBoxEndTime.Text.Length != 5
				|| maskedTextBoxStartTime.Text.IsNullOrEmpty()
				|| maskedTextBoxStartTime.Text.Length != 5)
			{
				labelMsg.Text = "Введите время";
				return;
			}

			
			// Проверим поле DayOfWeek
			if (comboBoxDayOfWeek.SelectedIndex == -1)
			{
				labelMsg.Text = "Выберете день недели";
				return;
			}

			// Проверим интервал времени
			if(maskedTextBoxRangeTime.Text.IsNullOrEmpty()
				|| maskedTextBoxRangeTime.Text.Length != 5)
			{
				labelMsg.Text = "Введите интервал времени приема";
				return;
			}

			// Все данные проверены и корректны
			// Добавим запись в базу данных
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				Database.Doctor? dbDoc;
				// Если docId = null, то врача определяем по имени
				if (docId is null)
				{
					dbDoc = db.Doctors.Where(p => p.NameD == textBoxName.Text).SingleOrDefault();
				}
				// Иначе по id
				else
				{
					dbDoc = db.Doctors.Where(p => p.PkIdDoctor == docId).SingleOrDefault();
				}

				// Определяем переменные для добавления
				TimeSpan startTime;
				TimeSpan endTime;
				int dayOfWeek;
				TimeSpan rangeTime;
				try
				{
					startTime = TimeSpan.Parse(maskedTextBoxStartTime.Text);
					endTime = TimeSpan.Parse(maskedTextBoxEndTime.Text);
					dayOfWeek = comboBoxDayOfWeek.SelectedIndex;
					rangeTime = TimeSpan.Parse(maskedTextBoxRangeTime.Text);
					var dbCheck = db.Schedules
							.Where(p => p.DoctorId == dbDoc
								&& p.TimeStart == startTime
								&& p.TimeEnd == endTime
								&& p.DayOfWeek == dayOfWeek
								&& p.RangeTime == rangeTime).SingleOrDefault();
					if (dbCheck != null)
					{
						dbCheck.DateInsert = DateTime.Now;
						db.Schedules.Update(dbCheck);
						db.SaveChanges();
					}
					else
					{
						int idAcc;
						//Генерация Primary Key
						// Получаем самый большой по значению первичный ключ
						var dbScheduleId = db.Schedules.OrderBy(p => p.PkIdSchedule).LastOrDefault();
						// Если первичного ключа нет, то объявляем его как наименьший - '0'
						// Иначе увеличиваем наибольший первичный ключ на 1
						if (dbScheduleId != null)
							idAcc = dbScheduleId.PkIdSchedule + 1;
						else
							idAcc = 0;

						Schedule newSchedule = new Schedule()
						{
							PkIdSchedule = idAcc,
							TimeStart = startTime,
							TimeEnd = endTime,
							DayOfWeek = dayOfWeek,
							DateInsert = DateTime.Now,
							RangeTime = rangeTime,
							FkIdDoctor = dbDoc!.PkIdDoctor,
							DoctorId = dbDoc,
						};
						db.Schedules.Add(newSchedule);
						db.SaveChanges();
					}

					labelMsg.Text = "Запись успешно добавлена\nВ расписание";

				}
				catch
				{
					labelMsg.Text = "Время введено неверно";
				}
			}
		}

		private void EditSchedule_FormClosed(object sender, FormClosedEventArgs e)
		{
			ParentForm.Show();
		}
	}
}
