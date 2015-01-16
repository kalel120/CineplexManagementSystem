namespace Cineplex_prototype_01
{
	partial class form_ticket_list
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
            this.cine_Database01DataSet1 = new Cineplex_prototype_01.cine_Database01DataSet1();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TicketTableAdapter();
            this.tableAdapterManager = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager();
            this.bb2Admin = new System.Windows.Forms.Button();
            this.ticketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cine_Database01DataSet = new Cineplex_prototype_01.cine_Database01DataSet();
            this.ticketTableAdapter1 = new Cineplex_prototype_01.cine_Database01DataSetTableAdapters.TicketTableAdapter();
            this.ticketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cineDatabase01DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickettypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDatabase01DataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cine_Database01DataSet1
            // 
            this.cine_Database01DataSet1.DataSetName = "cine_Database01DataSet1";
            this.cine_Database01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.cine_Database01DataSet1;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cinema_HallTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.Requests_forTableAdapter = null;
            this.tableAdapterManager.ShowsTableAdapter = null;
            this.tableAdapterManager.StuffTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = this.ticketTableAdapter;
            this.tableAdapterManager.UpdateOrder = Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bb2Admin
            // 
            this.bb2Admin.Location = new System.Drawing.Point(12, 461);
            this.bb2Admin.Name = "bb2Admin";
            this.bb2Admin.Size = new System.Drawing.Size(106, 30);
            this.bb2Admin.TabIndex = 2;
            this.bb2Admin.Text = "back";
            this.bb2Admin.UseVisualStyleBackColor = true;
            this.bb2Admin.Click += new System.EventHandler(this.bb2Admin_Click);
            // 
            // ticketDataGridView
            // 
            this.ticketDataGridView.AutoGenerateColumns = false;
            this.ticketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ticketDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketidDataGridViewTextBoxColumn,
            this.issueddateDataGridViewTextBoxColumn,
            this.tickettypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.csidDataGridViewTextBoxColumn,
            this.movieidDataGridViewTextBoxColumn});
            this.ticketDataGridView.DataSource = this.ticketBindingSource1;
            this.ticketDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ticketDataGridView.Name = "ticketDataGridView";
            this.ticketDataGridView.Size = new System.Drawing.Size(685, 413);
            this.ticketDataGridView.TabIndex = 2;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataMember = "Ticket";
            this.ticketBindingSource1.DataSource = this.cine_Database01DataSet;
            // 
            // cine_Database01DataSet
            // 
            this.cine_Database01DataSet.DataSetName = "cine_Database01DataSet";
            this.cine_Database01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketTableAdapter1
            // 
            this.ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // ticketBindingSource2
            // 
            this.ticketBindingSource2.DataMember = "Ticket";
            this.ticketBindingSource2.DataSource = this.cine_Database01DataSet1;
            // 
            // cineDatabase01DataSet1BindingSource
            // 
            this.cineDatabase01DataSet1BindingSource.DataSource = this.cine_Database01DataSet1;
            this.cineDatabase01DataSet1BindingSource.Position = 0;
            // 
            // ticketidDataGridViewTextBoxColumn
            // 
            this.ticketidDataGridViewTextBoxColumn.DataPropertyName = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.HeaderText = "ticket_id";
            this.ticketidDataGridViewTextBoxColumn.Name = "ticketidDataGridViewTextBoxColumn";
            // 
            // issueddateDataGridViewTextBoxColumn
            // 
            this.issueddateDataGridViewTextBoxColumn.DataPropertyName = "issued_date";
            this.issueddateDataGridViewTextBoxColumn.HeaderText = "issued_date";
            this.issueddateDataGridViewTextBoxColumn.Name = "issueddateDataGridViewTextBoxColumn";
            // 
            // tickettypeDataGridViewTextBoxColumn
            // 
            this.tickettypeDataGridViewTextBoxColumn.DataPropertyName = "ticket_type";
            this.tickettypeDataGridViewTextBoxColumn.HeaderText = "ticket_type";
            this.tickettypeDataGridViewTextBoxColumn.Name = "tickettypeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // csidDataGridViewTextBoxColumn
            // 
            this.csidDataGridViewTextBoxColumn.DataPropertyName = "cs_id";
            this.csidDataGridViewTextBoxColumn.HeaderText = "cs_id";
            this.csidDataGridViewTextBoxColumn.Name = "csidDataGridViewTextBoxColumn";
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "movie_id";
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            // 
            // form_ticket_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 511);
            this.Controls.Add(this.ticketDataGridView);
            this.Controls.Add(this.bb2Admin);
            this.Name = "form_ticket_list";
            this.Text = "Ticket List";
            this.Load += new System.EventHandler(this.form_ticket_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDatabase01DataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private cine_Database01DataSet1 cine_Database01DataSet1;
		private System.Windows.Forms.BindingSource ticketBindingSource;
		private cine_Database01DataSet1TableAdapters.TicketTableAdapter ticketTableAdapter;
		private cine_Database01DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Button bb2Admin;
        private System.Windows.Forms.DataGridView ticketDataGridView;
        private cine_Database01DataSet cine_Database01DataSet;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private cine_Database01DataSetTableAdapters.TicketTableAdapter ticketTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tickettypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketBindingSource2;
        private System.Windows.Forms.BindingSource cineDatabase01DataSet1BindingSource;
	}
}