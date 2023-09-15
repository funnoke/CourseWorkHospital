//-----------------------ClassLogic.Doctor
using CourseWorkAt4.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkAt4.ClassLogic
{
	public class Doctor : Hospital
	{
		public Doctor(string login)
		{
			using (HospitalAt2Context db = new HospitalAt2Context())
			{
				// Получение данных из бд
				IEnumerable<Account> dbAcc = db.Accounts.Where(p => p.LoginAcc == login);
				foreach (Account acc in dbAcc)
				{
					acc.OnlineAcc = true;
					AccId = acc.PkIdAcc;
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
