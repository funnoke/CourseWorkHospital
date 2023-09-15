using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using CourseWorkAt4;
using CourseWorkAt4.Forms;

//Scaffold-DbContext "Server=DESKTOP-NL3TB6V;Database=HospitalAt2;Trusted_Connection=True;TrustServerCertificate=True" --force Microsoft.EntityFrameworkCore.SqlServer

namespace TestForm
{
	internal static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Autorization());

		}
	}
}

