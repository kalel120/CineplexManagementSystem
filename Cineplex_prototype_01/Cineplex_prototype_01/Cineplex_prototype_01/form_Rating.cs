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
	public partial class form_Rating : Form
	{
		public form_Rating()
		{
			InitializeComponent ();
		}

		private void back2CS_from_Rate_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void button2_Click( object sender, EventArgs e )
		{
			form_appriciate objapp = new form_appriciate ();
			objapp.Show ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			form_Remarks objRM = new form_Remarks ();
			objRM.Show ();
		}
	}
}
