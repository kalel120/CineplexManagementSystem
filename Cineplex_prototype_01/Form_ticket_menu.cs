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
	public partial class Form_ticket_menu : Form
	{
		SqlConnection contn = new SqlConnection ("Data Source=KRAKER-PC;Initial Catalog=cine_Database01;Integrated Security=True");
		public Form_ticket_menu()
		{
			InitializeComponent ();
		}

		private void button2_Click( object sender, EventArgs e )
		{
			SqlCommand obj_cmd;

			contn.Open ();

			string del_query = @"DELETE  FROM Ticket";
			obj_cmd = new SqlCommand (del_query, contn);
			obj_cmd.ExecuteNonQuery ();

			MessageBox.Show ("Ticket list  is Cleared");
			contn.Close ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			form_ticket_list obj_tkt_list = new form_ticket_list ();
			obj_tkt_list.Show ();
		}

		private void button3_Click( object sender, EventArgs e )
		{
			this.Close ();
		}
	}
}
