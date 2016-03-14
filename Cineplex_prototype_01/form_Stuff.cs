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
	public partial class form_Stuff : Form
	{
        SqlConnection contn = new SqlConnection("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");
		int stuff_id01, hall_id01;
		string stuff_name01;
		
		public form_Stuff()
		{
			InitializeComponent ();
		}

		private void form_Stuff_Load( object sender, EventArgs e )
		{

		}

		private void label2_Click( object sender, EventArgs e )
		{

		}

		private void label3_Click( object sender, EventArgs e )
		{

		}

		private void bb2_Admin_from_Stuff_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void button_stuff_table_Click( object sender, EventArgs e )
		{
			form_stuff_table obj_stuff_table = new form_stuff_table ();
			obj_stuff_table.Show ();
		}

		private void button_submit_stuff_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;
				contn.Open ();

				string sql_ins = @"INSERT INTO Stuff (stuff_id,stuff_name,hall_id) values (@stuff_id01, @stuff_name01, @hall_id01)";
				obj_cmd = new SqlCommand (sql_ins, contn);
				obj_cmd.Parameters.Add ("@stuff_id01", SqlDbType.Int).Value = stuff_id01;
				obj_cmd.Parameters.Add ("@stuff_name01", SqlDbType.NVarChar).Value = stuff_name01;
				obj_cmd.Parameters.Add ("@hall_id01", SqlDbType.Int).Value = hall_id01;

				obj_cmd.ExecuteNonQuery ();
				MessageBox.Show ("Stuff Recruited");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("These Fields are Empty");
			}


		}

		private void textBox1_TextChanged( object sender, EventArgs e )
		{
			stuff_id01 = Convert.ToInt32(textBox1.Text);
		}

		private void textBox2_TextChanged( object sender, EventArgs e )
		{
			stuff_name01 = textBox2.Text;
		}

		private void textBox3_TextChanged( object sender, EventArgs e )
		{
			hall_id01 = Convert.ToInt32 (textBox3.Text);
		}

		private void button_clr_stable_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;

				contn.Open ();

				string del_query = @"DELETE  FROM Stuff";
				obj_cmd = new SqlCommand (del_query, contn);
				obj_cmd.ExecuteNonQuery ();

				MessageBox.Show ("Stuff List is Cleared");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("Stuff List is Empty");
			}
		}
	}
}
