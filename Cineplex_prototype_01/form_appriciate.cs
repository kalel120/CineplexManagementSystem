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
	public partial class form_appriciate : Form
	{
		public form_appriciate()
		{
			InitializeComponent ();
		}

		private void timer1_Tick( object sender, EventArgs e )
		{
			this.Close ();
		}
	}
}
