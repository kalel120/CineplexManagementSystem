﻿using System;
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
	public partial class form_login_not_sucs : Form
	{
		public form_login_not_sucs()
		{
			InitializeComponent ();
		}

		private void timer1_Tick( object sender, EventArgs e )
		{
			this.Close ();
		}
	}
}
