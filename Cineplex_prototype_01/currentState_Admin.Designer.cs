namespace Cineplex_prototype_01
{
	partial class currentState_Admin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.back2Admin_fromCST = new System.Windows.Forms.Button();
            this.prototype_Database01DataSet1 = new Cineplex_prototype_01.prototype_Database01DataSet1();
            this.cinema_HallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinema_HallTableAdapter = new Cineplex_prototype_01.prototype_Database01DataSet1TableAdapters.Cinema_HallTableAdapter();
            this.tableAdapterManager = new Cineplex_prototype_01.prototype_Database01DataSet1TableAdapters.TableAdapterManager();
            this.movieTableAdapter = new Cineplex_prototype_01.prototype_Database01DataSet1TableAdapters.MovieTableAdapter();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prototype_Database01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema_HallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // back2Admin_fromCST
            // 
            this.back2Admin_fromCST.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2Admin_fromCST.Location = new System.Drawing.Point(12, 393);
            this.back2Admin_fromCST.Name = "back2Admin_fromCST";
            this.back2Admin_fromCST.Size = new System.Drawing.Size(75, 28);
            this.back2Admin_fromCST.TabIndex = 0;
            this.back2Admin_fromCST.Text = "back";
            this.back2Admin_fromCST.UseVisualStyleBackColor = true;
            this.back2Admin_fromCST.Click += new System.EventHandler(this.back2Admin_fromCST_Click);
            // 
            // prototype_Database01DataSet1
            // 
            this.prototype_Database01DataSet1.DataSetName = "prototype_Database01DataSet1";
            this.prototype_Database01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinema_HallBindingSource
            // 
            this.cinema_HallBindingSource.DataMember = "Cinema Hall";
            this.cinema_HallBindingSource.DataSource = this.prototype_Database01DataSet1;
            // 
            // cinema_HallTableAdapter
            // 
            this.cinema_HallTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cinema_HallTableAdapter = this.cinema_HallTableAdapter;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.Requests_forTableAdapter = null;
            this.tableAdapterManager.showsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.ticketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cineplex_prototype_01.prototype_Database01DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.prototype_Database01DataSet1;
            // 
            // currentState_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 451);
            this.Controls.Add(this.back2Admin_fromCST);
            this.Name = "currentState_Admin";
            this.Text = "Current State";
            this.Load += new System.EventHandler(this.currentState_Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prototype_Database01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinema_HallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back2Admin_fromCST;
		private prototype_Database01DataSet1 prototype_Database01DataSet1;
		private System.Windows.Forms.BindingSource cinema_HallBindingSource;
		private prototype_Database01DataSet1TableAdapters.Cinema_HallTableAdapter cinema_HallTableAdapter;
        private prototype_Database01DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private prototype_Database01DataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.BindingSource movieBindingSource;
	}
}