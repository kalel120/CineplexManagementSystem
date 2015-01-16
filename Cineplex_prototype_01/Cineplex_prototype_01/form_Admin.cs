using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
			form_Delete_Movie objTS = new form_Delete_Movie ();
			objTS.Show ();
		}

		private void currentState_Click( object sender, EventArgs e )
		{
			form_currentState_Admin objsct = new form_currentState_Admin ();
			objsct.Show ();
		}

		private void updateMovie_Click( object sender, EventArgs e )
		{
			form_Insert_Movie objUM = new form_Insert_Movie ();
			objUM.Show ();
		}

		private void seatArrange_Click( object sender, EventArgs e )
		{
			form_Update_Movie objSA = new form_Update_Movie ();
			objSA.Show ();
		}

		private void button_Stuff_Click( object sender, EventArgs e )
		{
			form_Stuff obj_Stuff = new form_Stuff ();
			obj_Stuff.Show ();
		}

		private void btn_Hall_arrange_Click( object sender, EventArgs e )
		{
			form_Hall_arrangement obj_H_arrng = new form_Hall_arrangement ();
			obj_H_arrng.Show ();
		}

		private void button_show_ticket_list_Click( object sender, EventArgs e )
		{
			Form_ticket_menu obj_tkt_menu = new Form_ticket_menu ();
			obj_tkt_menu.Show ();
		}

	}
}
