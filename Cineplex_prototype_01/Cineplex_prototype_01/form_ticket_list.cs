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
	public partial class form_ticket_list : Form
	{
		public form_ticket_list()
		{
			InitializeComponent ();
		}

		private void ticketBindingNavigatorSaveItem_Click( object sender, EventArgs e )
		{
			this.Validate ();
			this.ticketBindingSource.EndEdit ();
			this.tableAdapterManager.UpdateAll (this.cine_Database01DataSet1);

		}

		private void form_ticket_list_Load( object sender, EventArgs e )
		{
            // TODO: This line of code loads data into the 'cine_Database01DataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter1.Fill(this.cine_Database01DataSet.Ticket);
			// TODO: This line of code loads data into the 'cine_Database01DataSet1.Ticket' table. You can move, or remove it, as needed.
			this.ticketTableAdapter.Fill (this.cine_Database01DataSet1.Ticket);

		}

		private void bb2Admin_Click( object sender, EventArgs e )
		{
			this.Close ();
		}
	}
}
