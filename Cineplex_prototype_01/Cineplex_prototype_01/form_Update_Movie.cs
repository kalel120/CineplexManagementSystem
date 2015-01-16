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
	public partial class form_Update_Movie : Form
	{
		int pre_id, post_id,mid_r,mid_s,mid_g;
		string pre_title, post_title;
		string pre_rd, post_rd;
		string pre_st, post_st;
		string pre_gen, post_gen;

        SqlConnection contn = new SqlConnection("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");

		public form_Update_Movie()
		{
			InitializeComponent ();
		}

		private void back2Admin_formSA_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void button_cng_id_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;
				contn.Open ();

				string sql_cngid = @"UPDATE	Movie SET movie_id =@post_id WHERE movie_id=@pre_id";
				obj_cmd = new SqlCommand (sql_cngid, contn);
				obj_cmd.Parameters.Add ("@pre_id", SqlDbType.Int).Value = pre_id;
				obj_cmd.Parameters.Add ("@post_id", SqlDbType.Int).Value = post_id;

				obj_cmd.ExecuteNonQuery ();
				MessageBox.Show ("Updated");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("Update Failed!!");
			}
		}

		private void textBox_pre_id_TextChanged( object sender, EventArgs e )
		{
			pre_id = Convert.ToInt32 (textBox_pre_id.Text);
		}

		private void textBox_new_id_TextChanged( object sender, EventArgs e )
		{
			post_id = Convert.ToInt32 (textBox_new_id.Text);
		}

		private void button_cng_title_Click( object sender, EventArgs e )
		{
			try
			{
			SqlCommand obj_cmd;
			contn.Open ();

			string cng_title = @"UPDATE Movie SET movie_title=@post_title WHERE movie_title=@pre_title";
			obj_cmd = new SqlCommand (cng_title,contn);
			obj_cmd.Parameters.Add ("@pre_title",SqlDbType.NVarChar).Value=pre_title;
			obj_cmd.Parameters.Add ("@post_title", SqlDbType.NVarChar).Value = post_title;

			obj_cmd.ExecuteNonQuery ();
			MessageBox.Show ("Title Updated");
			contn.Close ();
			}
			catch(Exception)
			{
				MessageBox.Show("Update failed");
			}
			
		}

		private void textBox_pretitle_TextChanged( object sender, EventArgs e )
		{
			pre_title = textBox_pretitle.Text;
		}

		private void textBox_posttitle_TextChanged( object sender, EventArgs e )
		{
			post_title = textBox_posttitle.Text;
		}

		private void button_cng_rd_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;
				contn.Open ();

				string cng_rd = @"UPDATE Movie SET release_date_time = @post_rd WHERE release_date_time=@pre_rd AND movie_id= @mid_r";
				obj_cmd = new SqlCommand (cng_rd, contn);
				obj_cmd.Parameters.Add ("@pre_rd", SqlDbType.DateTime).Value = pre_rd;
				obj_cmd.Parameters.Add ("@post_rd", SqlDbType.DateTime).Value = post_rd;
				obj_cmd.Parameters.Add ("@mid_r",SqlDbType.Int).Value=mid_r;

				obj_cmd.ExecuteNonQuery ();
				MessageBox.Show ("Released date time Updated");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("Update failed");
			}
		}

		private void textBox2_TextChanged( object sender, EventArgs e )
		{
			pre_rd = textBox2.Text;
		}

		private void textBox1_TextChanged( object sender, EventArgs e )
		{
			post_rd = textBox1.Text;
		}

		private void textBox_mid_r_TextChanged( object sender, EventArgs e )
		{
			mid_r = Convert.ToInt32 (textBox_mid_r.Text);
		}

		private void button_cng_st_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;
				contn.Open ();

				string cng_st = @"UPDATE Movie SET show_date_time = @post_st WHERE show_date_time=@pre_st AND movie_id= @mid_s";
				obj_cmd = new SqlCommand (cng_st, contn);
				obj_cmd.Parameters.Add ("@pre_st", SqlDbType.DateTime).Value = pre_st;
				obj_cmd.Parameters.Add ("@post_st", SqlDbType.DateTime).Value = post_st;
				obj_cmd.Parameters.Add ("@mid_s", SqlDbType.Int).Value = mid_s;

				obj_cmd.ExecuteNonQuery ();
				MessageBox.Show ("Show Date time  Updated");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("Update failed");
			}
		}

		private void textBox_mid_s_TextChanged( object sender, EventArgs e )
		{
			mid_s = Convert.ToInt32 (textBox_mid_s.Text);
		}

		private void textBox_pre_s_TextChanged( object sender, EventArgs e )
		{
			pre_st = textBox_pre_s.Text;
		}

		private void textBox_post_s_TextChanged( object sender, EventArgs e )
		{
			post_st = textBox_post_s.Text;
		}

		private void button_cng_gener_Click( object sender, EventArgs e )
		{
			try
			{
				SqlCommand obj_cmd;
				contn.Open ();

				string cng_gen = @"UPDATE Movie SET gener = @post_gen WHERE gener=@pre_gen AND movie_id= @mid_g";
				obj_cmd = new SqlCommand (cng_gen, contn);
				obj_cmd.Parameters.Add ("@pre_gen", SqlDbType.NVarChar).Value = pre_gen;
				obj_cmd.Parameters.Add ("@post_gen", SqlDbType.NVarChar).Value = post_gen;
				obj_cmd.Parameters.Add ("@mid_g", SqlDbType.Int).Value = mid_g;

				obj_cmd.ExecuteNonQuery ();
				MessageBox.Show ("Gener Updated");
				contn.Close ();
			}
			catch (Exception)
			{
				MessageBox.Show ("Update failed");
			}
		}

		private void textBox_m_g_TextChanged( object sender, EventArgs e )
		{
			mid_g = Convert.ToInt32 (textBox_m_g.Text);
		}

		private void comboBox_pre_SelectedIndexChanged( object sender, EventArgs e )
		{
			pre_gen = comboBox_pre.SelectedItem.ToString ();
		}

		private void comboBox_post_SelectedIndexChanged( object sender, EventArgs e )
		{
			post_gen = comboBox_post.SelectedItem.ToString ();
		}




	}
}
