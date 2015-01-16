namespace Cineplex_prototype_01
{
	partial class movie_schedule
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
            this.back2mm = new System.Windows.Forms.Button();
            this.cine_Database01DataSet1 = new Cineplex_prototype_01.cine_Database01DataSet1();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.cine_Database01DataSet = new Cineplex_prototype_01.cine_Database01DataSet();
            this.cineDatabase01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter1 = new Cineplex_prototype_01.cine_Database01DataSetTableAdapters.MovieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDatabase01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // back2mm
            // 
            this.back2mm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back2mm.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2mm.Location = new System.Drawing.Point(12, 458);
            this.back2mm.Name = "back2mm";
            this.back2mm.Size = new System.Drawing.Size(79, 31);
            this.back2mm.TabIndex = 0;
            this.back2mm.Text = "back";
            this.back2mm.UseVisualStyleBackColor = true;
            this.back2mm.Click += new System.EventHandler(this.button1_Click);
            // 
            // cine_Database01DataSet1
            // 
            this.cine_Database01DataSet1.DataSetName = "cine_Database01DataSet1";
            this.cine_Database01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.cine_Database01DataSet1;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cinema_HallTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.Requests_forTableAdapter = null;
            this.tableAdapterManager.ShowsTableAdapter = null;
            this.tableAdapterManager.StuffTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.movieDataGridView.DataSource = this.movieBindingSource1;
            this.movieDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movieDataGridView.Location = new System.Drawing.Point(12, 12);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.Size = new System.Drawing.Size(445, 404);
            this.movieDataGridView.TabIndex = 2;
            // 
            // cine_Database01DataSet
            // 
            this.cine_Database01DataSet.DataSetName = "cine_Database01DataSet";
            this.cine_Database01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cineDatabase01DataSetBindingSource
            // 
            this.cineDatabase01DataSetBindingSource.DataSource = this.cine_Database01DataSet;
            this.cineDatabase01DataSetBindingSource.Position = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gener";
            this.dataGridViewTextBoxColumn5.HeaderText = "Gener";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "release_date_time";
            this.dataGridViewTextBoxColumn3.HeaderText = "Release Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "show_date_time";
            this.dataGridViewTextBoxColumn4.HeaderText = "Show time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "movie_title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // movieBindingSource1
            // 
            this.movieBindingSource1.DataMember = "Movie";
            this.movieBindingSource1.DataSource = this.cineDatabase01DataSetBindingSource;
            // 
            // movieTableAdapter1
            // 
            this.movieTableAdapter1.ClearBeforeFill = true;
            // 
            // movie_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 509);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.back2mm);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "movie_schedule";
            this.Text = "Movie Schedule";
            this.Load += new System.EventHandler(this.movie_schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDatabase01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back2mm;
		private cine_Database01DataSet1 cine_Database01DataSet1;
		private System.Windows.Forms.BindingSource movieBindingSource;
		private cine_Database01DataSet1TableAdapters.MovieTableAdapter movieTableAdapter;
		private cine_Database01DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.BindingSource cineDatabase01DataSetBindingSource;
        private cine_Database01DataSet cine_Database01DataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private cine_Database01DataSetTableAdapters.MovieTableAdapter movieTableAdapter1;
	}
}