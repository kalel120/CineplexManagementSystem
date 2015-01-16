using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cineplex_prototype_01
{
	public partial class form_Admin : Form
	{
		public form_Admin()
		{
			InitializeComponent ();
		}

		private void back2mmFrom_Admin_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void button3_Click( object sender, EventArgs e )
		{
			//form_Customer objTS = new form_Customer();
			//objTS.Show ();
		}

		private void refButton_Click( object sender, EventArgs e )
		{
			form_Refresh objRefrsh = new form_Refresh ();
			objRefrsh.Show ();
		}

		private void currentState_Click( object sender, EventArgs e )
		{
            string connectionString = @"Data Source=C:\Users\User\Desktop\Cineplex_prototype_01\Cineplex_prototype_01\prototype_Database01.sdf";

            SqlConnection connObj = new SqlConnection(connectionString);

           // string objquery = "INSERT INTO t_Student VALUES('" + studentObj.Id + @"','" + studentObj.Name + @"','" + studentObj.DepartmentName + "')";

            SqlCommand objcommadn_01 = new SqlCommand(objquery,connectionString);

                                 
                                 

                                    
            
            
            
            
            
            
            
            
            currentState_Admin objcst = new currentState_Admin ();
			objcst.Show ();
		}

		private void updateMovie_Click( object sender, EventArgs e )
		{
			form_UpdateMovie objUM = new form_UpdateMovie ();
			objUM.Show ();
		}

		private void seatArrange_Click( object sender, EventArgs e )
		{
			form_SeatArrange objSA = new form_SeatArrange ();
			objSA.Show ();
		}
	}
}
