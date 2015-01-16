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
	public partial class form_loginSucs : Form
	{
		public form_loginSucs()
		{
			InitializeComponent ();
		}

		private void timer1_Tick( object sender, EventArgs e )
		{
			form_Admin objAd = new form_Admin ();
			objAd.Show ();
			this.Close ();

		}

		private void form_loginSucs_Load( object sender, EventArgs e )
		{

		}
	}
}
