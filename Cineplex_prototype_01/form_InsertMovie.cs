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
	public partial class form_Insert_Movie : Form
	{
		int m_id01;
		string m_title, m_rd, m_st, m_gener;
        SqlConnection contn = new SqlConnection("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");
		SqlCommand obj_comnd;

		public form_Insert_Movie()
		{
			InitializeComponent ();
		}

		private void back2Admin_fromUM_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void label4_Click( object sender, EventArgs e )
		{


		}

		private void button_submit_Click( object sender, EventArgs e )
		{
			try
			{
				contn.Open ();
				string insrt_sql = @"INSERT INTO Movie (movie_id,movie_title,release_date_time,show_date_time,gener) values (@m_id01,@m_title,@m_rd,@m_st,@m_gener)";
				obj_comnd = new SqlCommand (insrt_sql, contn);

				obj_comnd.Parameters.Add ("@m_id01", SqlDbType.Int).Value = m_id01;
				obj_comnd.Parameters.Add ("@m_title", SqlDbType.NVarChar).Value = m_title;
				obj_comnd.Parameters.Add ("@m_st", SqlDbType.DateTime).Value = m_st;
				obj_comnd.Parameters.Add ("@m_rd", SqlDbType.DateTime).Value = m_rd;
				obj_comnd.Parameters.Add ("@m_gener", SqlDbType.NVarChar).Value = m_gener;


				obj_comnd.ExecuteNonQuery ();
				MessageBox.Show ("Insert Successful");

				contn.Close ();

			}
			catch (Exception)
			{
				MessageBox.Show ("Insert Unsucessufll");
			}
		}

		private void textBox_id_TextChanged( object sender, EventArgs e )
		{
			this.m_id01 = Convert.ToInt32 (textBox_id.Text);
		}

		private void textBox_title_TextChanged( object sender, EventArgs e )
		{
			this.m_title = textBox_title.Text;
		}

		private void textBox_st_TextChanged( object sender, EventArgs e )
		{
			this.m_st = textBox_st.Text;
		}

		private void textBox_rd_TextChanged( object sender, EventArgs e )
		{
			this.m_rd = textBox_rd.Text;
		}

		

		private void comboBox_gener_SelectedIndexChanged( object sender, EventArgs e )
		{

			
			m_gener = comboBox_gener.SelectedItem.ToString ();
			
		}
	}
}
