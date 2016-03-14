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
	public partial class form_AdminPass : Form
	{
		string dummy1, dummy2,dummy3,dummy4;
		
		public form_AdminPass()
		{
			InitializeComponent ();
		}

		private void back2mm_from_Adminlogin_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			dummy2 = "admin";
			dummy4 = "admin";
			if( (dummy1 == dummy2) & (dummy3 == dummy4) )
			{
				form_loginSucs objAdlogS = new form_loginSucs ();
				objAdlogS.Show ();
				this.Close ();
			}
			else
			{
				form_login_not_sucs objlogNotS = new form_login_not_sucs ();
				objlogNotS.Show ();
			}
		}

		private void textBox1_TextChanged( object sender, EventArgs e )
		{
			TextBox objTextBox01 = (TextBox)sender;
			string theText01 = objTextBox01.Text;

			dummy1 = theText01;

		}

		private void textBox2_TextChanged( object sender, EventArgs e )
		{
			TextBox objTextBox02 = (TextBox)sender;
			string theText02 = objTextBox02.Text;

			dummy3 = theText02;
		} 
	}
}
