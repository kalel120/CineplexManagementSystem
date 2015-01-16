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
	public partial class form_Tkt_BB : Form
	{
		int cs_id01 = 3001;
		int tkt_type01, m_id01;
		int tkt_id01 = 2001;
		int price_01;
		int accounts_payable, tkt_amount01;

		string cs_name01, m_date01, tkt_type02;


		public form_Tkt_BB()
		{
			InitializeComponent ();
		}

		private void textBox1_TextChanged( object sender, EventArgs e )
		{
			cs_name01 = textBox_m_date.Text;
		}

		private void back2Customer_formTB_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void radioButton1_CheckedChanged( object sender, EventArgs e )
		{

		}

		private void radioButton2_CheckedChanged( object sender, EventArgs e )
		{

		}

		private void button_check_out_Click( object sender, EventArgs e )
		{
			//try
			//{
			SqlConnection contn01 = new SqlConnection ("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");
			SqlCommand obj_cmd01;
			contn01.Open ();


			string ins_qury = @"INSERT INTO Customer (cs_id,cs_name) values (@cs_id01, @cs_name01)";

			obj_cmd01 = new SqlCommand (ins_qury, contn01);


			obj_cmd01.Parameters.Add ("@cs_id01", SqlDbType.Int).Value = cs_id01;
			obj_cmd01.Parameters.Add ("@cs_name01", SqlDbType.NVarChar).Value = cs_name01;

			obj_cmd01.ExecuteNonQuery ();
			contn01.Close ();

            SqlConnection contn02 = new SqlConnection("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");
			SqlCommand obj_cmd02;
			contn02.Open ();

			string qury02 = @"INSERT INTO Ticket (ticket_id,issued_date,ticket_type,price,cs_id,movie_id) values (@tkt_id01, @m_date01, @tkt_type01, @price_01, @cs_id01, @m_id01 )";

			obj_cmd02 = new SqlCommand (qury02, contn02);



			obj_cmd02.Parameters.Add ("@tkt_id01 ", SqlDbType.Int).Value = tkt_id01;
			obj_cmd02.Parameters.Add ("@m_date01 ", SqlDbType.DateTime).Value = m_date01;
			obj_cmd02.Parameters.Add ("@tkt_type01 ", SqlDbType.Int).Value = tkt_type01;
			obj_cmd02.Parameters.Add ("@price_01 ", SqlDbType.Int).Value = price_01;
			obj_cmd02.Parameters.Add ("@cs_id01 ", SqlDbType.Int).Value = cs_id01;
			obj_cmd02.Parameters.Add ("@m_id01 ", SqlDbType.Int).Value = m_id01;

			obj_cmd02.ExecuteNonQuery ();

			cs_id01++;
			tkt_id01++;
			MessageBox.Show ("Purched!!");
			contn02.Close ();
			//}
			//catch (Exception)
			//{
			//MessageBox.Show ("Failed");
			//}
		}

		private void textBox_m_name_TextChanged( object sender, EventArgs e )
		{
			m_id01 = Convert.ToInt32 (textBox_m_name.Text);
		}

		private void comboBox1_SelectedIndexChanged( object sender, EventArgs e )
		{
			tkt_type02 = comboBox1.SelectedItem.ToString ();
			tkt_type01 = Convert.ToInt32 (tkt_type02);

			if (tkt_type01 == 1)
			{
				price_01 = 1000;

			}
			else
			{
				price_01 = 500;

			}
		}

		private void textBox1_m_date_TextChanged_1( object sender, EventArgs e )
		{
			m_date01 = textBox_m_date.Text;
		}

		private void textBox_tkt_amount_TextChanged( object sender, EventArgs e )
		{

			tkt_amount01 = Convert.ToInt32 (textBox_tkt_amount.Text);
		}

		private void button_pay_amount_Click( object sender, EventArgs e )
		{

			accounts_payable = (tkt_amount01 * price_01);
			MessageBox.Show (accounts_payable.ToString());
		}

		private void label3_Click( object sender, EventArgs e )
		{

		}
	}
}
