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
	public partial class form_currentState_Admin : Form
	{
		public form_currentState_Admin()
		{
			InitializeComponent ();
		}

		private void bb2_admin_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void movieBindingNavigatorSaveItem_Click( object sender, EventArgs e )
		{
			this.Validate ();
			this.movieBindingSource.EndEdit ();
			this.tableAdapterManager.UpdateAll (this.cine_Database01DataSet1);

		}

		private void form_currentState_Admin_Load( object sender, EventArgs e )
		{
            // TODO: This line of code loads data into the 'cine_Database01DataSet.Movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter1.Fill(this.cine_Database01DataSet.Movie);
			// TODO: This line of code loads data into the 'cine_Database01DataSet1.Movie' table. You can move, or remove it, as needed.
			this.movieTableAdapter.Fill (this.cine_Database01DataSet1.Movie);

		}
	}
}
