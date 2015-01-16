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
	public partial class about_Form : Form
	{
		public about_Form()
		{
			InitializeComponent ();
		}

		private void About_Load( object sender, EventArgs e )
		{

		}

		private void back2mmFrom_about_Click( object sender, EventArgs e )
		{
			this.Close ();
		}
	}
}
