using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace Cineplex_prototype_01
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new main_Menu ());
			
		/// Creating connection with Database
			SqlCeConnection myconnection = new SqlCeConnection ("Data source = prototype_Database01");
			//myconnection.Open ();


		

			//myconnection.Close ();

		}
	}
}
