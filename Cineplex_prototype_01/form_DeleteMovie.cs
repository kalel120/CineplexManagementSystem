using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Cineplex_prototype_01
{
	public partial class form_Delete_Movie : Form
	{
		string title01;
		SqlConnection contn = new SqlConnection ("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");


		public form_Delete_Movie()
		{
			InitializeComponent ();
		}

		private void back2Admin_formTS_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void button_clr_M_list_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;

				contn.Open ();

				string del_query = @"DELETE  FROM Movie";
				obj_cmd = new SqlCommand (del_query, contn);
				obj_cmd.ExecuteNonQuery ();

				MessageBox.Show ("Movie List is Cleared");
				contn.Close ();
				this.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("Movie List is Empty");
			}
		}

		private void button_submit_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand cmd01;
				contn.Open ();

				string sltv_del = @"DELETE FROM Movie WHERE movie_title = @title01";
				cmd01 = new SqlCommand (sltv_del, contn);

				cmd01.Parameters.Add ("@title01", SqlDbType.NVarChar).Value = title01;
				cmd01.ExecuteNonQuery ();
				MessageBox.Show ("Selected Movie is Deleted");
				contn.Close ();
			}
			catch(Exception)
			{
				MessageBox.Show ("Either Movie list is empty or Movie is not deleted");
			}
		}

		private void textBox_movie_name_TextChanged( object sender, EventArgs e )
		{
			title01 = textBox_movie_name.Text;
		}
	}
}
