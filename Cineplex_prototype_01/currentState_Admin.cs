using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cineplex_prototype_01
{
	public partial class currentState_Admin : Form
	{
		public currentState_Admin()
		{
			InitializeComponent ();
		}

		private void back2Admin_fromCST_Click( object sender, EventArgs e )
		{
			this.Close ();
		}

		private void cinema_HallBindingNavigatorSaveItem_Click( object sender, EventArgs e )
		{
			this.Validate ();
			this.cinema_HallBindingSource.EndEdit ();
			this.tableAdapterManager.UpdateAll (this.prototype_Database01DataSet1);

		}

		private void currentState_Admin_Load( object sender, EventArgs e )
		{
			// TODO: This line of code loads data into the 'prototype_Database01DataSet1.Movie' table. You can move, or remove it, as needed.
			this.movieTableAdapter.Fill (this.prototype_Database01DataSet1.Movie);
			// TODO: This line of code loads data into the 'prototype_Database01DataSet1.Cinema_Hall' table. You can move, or remove it, as needed.
			this.cinema_HallTableAdapter.Fill (this.prototype_Database01DataSet1.Cinema_Hall);

		}
	}
}
