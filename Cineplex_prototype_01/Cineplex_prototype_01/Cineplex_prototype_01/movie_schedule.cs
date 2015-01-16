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
	public partial class movie_schedule : Form
	{
		public movie_schedule()
		{
			InitializeComponent ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

        private void movie_schedule_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            String connectionString = @"Data Source=C:\TAHSIN\tahsin work files\Database\Cineplex_prototype_01\Cineplex_prototype_01\Cineplex_prototype_01\prototype_Database01.sdf";

            connection.ConnectionString = connectionString;
            SqlCommand command1 = new SqlCommand();
            command1.Connection = connection;
            command1.CommandText = " select movie_title from Movie where movie_id=1301 ";

            SqlCommand command2 = new SqlCommand();
            command2.Connection = connection;
            command2.CommandText = " select movie_title from Movie where movie_id=1302 ";

            String result1;
            String result2;
            using (connection)
            {
                connection.Open();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();

                result1 = command1.ExecuteScalar().ToString();
                result2 = command2.ExecuteScalar().ToString();


            }

            textBox1.Text = result1 + "\r\n" + result2;
        }
	}
}
