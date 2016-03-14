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
	public partial class form_Hall_arrangement : Form
	{
		int hid01, mid01;
        SqlConnection contn = new SqlConnection("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");

		public form_Hall_arrangement()
		{
			InitializeComponent ();
		}

		private void bb2admi_from_hall_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void form_Hall_arrangement_Load( object sender, EventArgs e )
		{

		}

		private void label1_Click( object sender, EventArgs e )
		{

		}

		private void label2_Click( object sender, EventArgs e )
		{

		}

		private void button_submit_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand objcmd;
				contn.Open ();

				string ins_sql = @"INSERT INTO Shows (hall_id,movie_id) values (@hid01,@mid01)";
				objcmd = new SqlCommand (ins_sql, contn);

				objcmd.Parameters.Add ("@hid01", SqlDbType.Int).Value = hid01;
				objcmd.Parameters.Add ("@mid01", SqlDbType.Int).Value = mid01;

				objcmd.ExecuteNonQuery ();
				MessageBox.Show ("Input successfull");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("Unvalid Input");
			}
		}

		private void textBox_hid_TextChanged( object sender, EventArgs e )
		{
			hid01 = Convert.ToInt32 (textBox_hid.Text);
		}

		private void textBox_mid_TextChanged( object sender, EventArgs e )
		{
			mid01 = Convert.ToInt32 (textBox_mid.Text);
		}

		private void button_show_list_Click( object sender, EventArgs e )
		{
			form_list obj_list = new form_list ();
			obj_list.Show ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;

				contn.Open ();

				string del_query = @"DELETE  FROM Shows";
				obj_cmd = new SqlCommand (del_query, contn);
				obj_cmd.ExecuteNonQuery ();

				MessageBox.Show ("List is Cleared");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("List is Empty");
			}
		}
	}
}
