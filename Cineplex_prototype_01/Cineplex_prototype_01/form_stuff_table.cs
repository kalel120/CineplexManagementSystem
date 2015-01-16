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
	public partial class form_stuff_table : Form
	{
		public form_stuff_table()
		{
			InitializeComponent ();
		}

		private void bb2_stuff_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void stuffBindingNavigatorSaveItem_Click( object sender, EventArgs e )
		{
			this.Validate ();
			this.stuffBindingSource.EndEdit ();
			this.tableAdapterManager.UpdateAll (this.cine_Database01DataSet1);

		}

		private void form_stuff_table_Load( object sender, EventArgs e )
		{
            // TODO: This line of code loads data into the 'cine_Database01DataSet.Stuff' table. You can move, or remove it, as needed.
            this.stuffTableAdapter1.Fill(this.cine_Database01DataSet.Stuff);
			// TODO: This line of code loads data into the 'cine_Database01DataSet1.Stuff' table. You can move, or remove it, as needed.
			this.stuffTableAdapter.Fill (this.cine_Database01DataSet1.Stuff);

		}
	}
}
