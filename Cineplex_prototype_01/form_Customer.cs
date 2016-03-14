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
	public partial class form_Customer : Form
	{
		public form_Customer()
		{
			InitializeComponent ();
		}

		private void back2mm_fromCS_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void ticketBooking_Click( object sender, EventArgs e )
		{
			form_Tkt_BB objBBT = new form_Tkt_BB ();
			objBBT.Show ();
		}

		private void rateMovie_Click( object sender, EventArgs e )
		{
			form_Rating objRT = new form_Rating ();
			objRT.Show ();
		}
	}
}
