namespace Cineplex_prototype_01
{
	partial class form_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_list));
            this.button1 = new System.Windows.Forms.Button();
            this.cine_Database01DataSet1 = new Cineplex_prototype_01.cine_Database01DataSet1();
            this.showsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showsTableAdapter = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.ShowsTableAdapter();
            this.tableAdapterManager = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager();
            this.showsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.showsDataGridView = new System.Windows.Forms.DataGridView();
            this.cinemaHallBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinema_HallTableAdapter = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.Cinema_HallTableAdapter();
            this.cinemaHallBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cine_Database01DataSet = new Cineplex_prototype_01.cine_Database01DataSet();
            this.cinemaHallBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cinema_HallTableAdapter1 = new Cineplex_prototype_01.cine_Database01DataSetTableAdapters.Cinema_HallTableAdapter();
            this.hallidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsBindingNavigator)).BeginInit();
            this.showsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaHallBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaHallBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaHallBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cine_Database01DataSet1
            // 
            this.cine_Database01DataSet1.DataSetName = "cine_Database01DataSet1";
            this.cine_Database01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // showsBindingSource
            // 
            this.showsBindingSource.DataMember = "Shows";
            this.showsBindingSource.DataSource = this.cine_Database01DataSet1;
            // 
            // showsTableAdapter
            // 
            this.showsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cinema_HallTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.Requests_forTableAdapter = null;
            this.tableAdapterManager.ShowsTableAdapter = this.showsTableAdapter;
            this.tableAdapterManager.StuffTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // showsBindingNavigator
            // 
            this.showsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.showsBindingNavigator.BindingSource = this.showsBindingSource;
            this.showsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.showsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.showsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.showsBindingNavigatorSaveItem});
            this.showsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.showsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.showsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.showsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.showsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.showsBindingNavigator.Name = "showsBindingNavigator";
            this.showsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.showsBindingNavigator.Size = new System.Drawing.Size(332, 25);
            this.showsBindingNavigator.TabIndex = 1;
            this.showsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // showsBindingNavigatorSaveItem
            // 
            this.showsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("showsBindingNavigatorSaveItem.Image")));
            this.showsBindingNavigatorSaveItem.Name = "showsBindingNavigatorSaveItem";
            this.showsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.showsBindingNavigatorSaveItem.Text = "Save Data";
            this.showsBindingNavigatorSaveItem.Click += new System.EventHandler(this.showsBindingNavigatorSaveItem_Click);
            // 
            // showsDataGridView
            // 
            this.showsDataGridView.AutoGenerateColumns = false;
            this.showsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hallidDataGridViewTextBoxColumn,
            this.hallnameDataGridViewTextBoxColumn});
            this.showsDataGridView.DataSource = this.cinemaHallBindingSource2;
            this.showsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.showsDataGridView.Name = "showsDataGridView";
            this.showsDataGridView.Size = new System.Drawing.Size(302, 370);
            this.showsDataGridView.TabIndex = 2;
            // 
            // cinemaHallBindingSource
            // 
            this.cinemaHallBindingSource.DataMember = "Cinema_Hall";
            this.cinemaHallBindingSource.DataSource = this.cine_Database01DataSet1;
            // 
            // cinema_HallTableAdapter
            // 
            this.cinema_HallTableAdapter.ClearBeforeFill = true;
            // 
            // cinemaHallBindingSource1
            // 
            this.cinemaHallBindingSource1.DataMember = "Cinema_Hall";
            this.cinemaHallBindingSource1.DataSource = this.cine_Database01DataSet1;
            // 
            // cine_Database01DataSet
            // 
            this.cine_Database01DataSet.DataSetName = "cine_Database01DataSet";
            this.cine_Database01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cinemaHallBindingSource2
            // 
            this.cinemaHallBindingSource2.DataMember = "Cinema_Hall";
            this.cinemaHallBindingSource2.DataSource = this.cine_Database01DataSet;
            // 
            // cinema_HallTableAdapter1
            // 
            this.cinema_HallTableAdapter1.ClearBeforeFill = true;
            // 
            // hallidDataGridViewTextBoxColumn
            // 
            this.hallidDataGridViewTextBoxColumn.DataPropertyName = "hall_id";
            this.hallidDataGridViewTextBoxColumn.HeaderText = "hall_id";
            this.hallidDataGridViewTextBoxColumn.Name = "hallidDataGridViewTextBoxColumn";
            // 
            // hallnameDataGridViewTextBoxColumn
            // 
            this.hallnameDataGridViewTextBoxColumn.DataPropertyName = "hall_name";
            this.hallnameDataGridViewTextBoxColumn.HeaderText = "hall_name";
            this.hallnameDataGridViewTextBoxColumn.Name = "hallnameDataGridViewTextBoxColumn";
            // 
            // form_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 495);
            this.Controls.Add(this.showsDataGridView);
            this.Controls.Add(this.showsBindingNavigator);
            this.Controls.Add(this.button1);
            this.Name = "form_list";
            this.Text = "List";
            this.Load += new System.EventHandler(this.form_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showsBindingNavigator)).EndInit();
            this.showsBindingNavigator.ResumeLayout(false);
            this.showsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaHallBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaHallBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaHallBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private cine_Database01DataSet1 cine_Database01DataSet1;
		private System.Windows.Forms.BindingSource showsBindingSource;
		private cine_Database01DataSet1TableAdapters.ShowsTableAdapter showsTableAdapter;
		private cine_Database01DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator showsBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton showsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView showsDataGridView;
        private System.Windows.Forms.BindingSource cinemaHallBindingSource;
        private cine_Database01DataSet1TableAdapters.Cinema_HallTableAdapter cinema_HallTableAdapter;
        private System.Windows.Forms.BindingSource cinemaHallBindingSource1;
        private cine_Database01DataSet cine_Database01DataSet;
        private System.Windows.Forms.BindingSource cinemaHallBindingSource2;
        private cine_Database01DataSetTableAdapters.Cinema_HallTableAdapter cinema_HallTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallnameDataGridViewTextBoxColumn;
	}
}