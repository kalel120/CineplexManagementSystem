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
	public partial class main_Menu : Form
	{
		public main_Menu()
		{
			InitializeComponent ();
		}

		private void label1_Click( object sender, EventArgs e )
		{

		}

		private void button2_Click( object sender, EventArgs e )
		{
			form_AdminPass objAdpass = new form_AdminPass ();
			objAdpass.Show ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			movie_schedule frm2 = new movie_schedule ();
			frm2.Show ();
		}

		private void finish_button_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void button_about_Click( object sender, EventArgs e )
		{
			about_Form frm_about = new about_Form ();
			frm_about.Show ();
		}

		private void login_customer_Click( object sender, EventArgs e )
		{
			form_Customer objCS = new form_Customer ();
			objCS.Show ();
		}
	}
}
