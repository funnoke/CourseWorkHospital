using CourseWorkAt4.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkAt4.ClassLogic
{
	public class Patient : Hospital
	{
		public Patient(string login)
		{
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				// Получение данных из бд
				var dbAcc = db.Accounts
					.Include(p => p.PatientId)
					.Where(p => p.LoginAcc == login)
					.SingleOrDefault();
				if (dbAcc is not null)
				{
					dbAcc.OnlineAcc = true;
					AccId = dbAcc.PkIdAcc;
					UserId = dbAcc.PatientId!.PkIdPatient;
				}
				db.SaveChanges();
			}
		}
		public new void Destruction()
		{
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				// Получение данных из бд
				var dbAcc = db.Accounts.Where(p => p.PkIdAcc == AccId);
				foreach (Account acc in dbAcc)
				{
					if (acc.PkIdAcc == AccId)
					{
						acc.OnlineAcc = false;
					}
				}
				db.SaveChanges();
			}
		}
	}
}
