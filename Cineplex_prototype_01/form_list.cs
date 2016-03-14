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
	public partial class form_list : Form
	{
		public form_list()
		{
			InitializeComponent ();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void showsBindingNavigatorSaveItem_Click( object sender, EventArgs e )
		{
			this.Validate ();
			this.showsBindingSource.EndEdit ();
			this.tableAdapterManager.UpdateAll (this.cine_Database01DataSet1);

		}

		private void form_list_Load( object sender, EventArgs e )
		{
            // TODO: This line of code loads data into the 'cine_Database01DataSet.Cinema_Hall' table. You can move, or remove it, as needed.
            this.cinema_HallTableAdapter1.Fill(this.cine_Database01DataSet.Cinema_Hall);
            // TODO: This line of code loads data into the 'cine_Database01DataSet1.Cinema_Hall' table. You can move, or remove it, as needed.
            this.cinema_HallTableAdapter.Fill(this.cine_Database01DataSet1.Cinema_Hall);
			// TODO: This line of code loads data into the 'cine_Database01DataSet1.Shows' table. You can move, or remove it, as needed.
			this.showsTableAdapter.Fill (this.cine_Database01DataSet1.Shows);

		}
	}
}
