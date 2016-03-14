namespace Cineplex_prototype_01
{
	partial class form_stuff_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_stuff_table));
            this.bb2_stuff = new System.Windows.Forms.Button();
            this.cine_Database01DataSet1 = new Cineplex_prototype_01.cine_Database01DataSet1();
            this.stuffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuffTableAdapter = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.StuffTableAdapter();
            this.tableAdapterManager = new Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager();
            this.stuffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.stuffBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stuffDataGridView = new System.Windows.Forms.DataGridView();
            this.cine_Database01DataSet = new Cineplex_prototype_01.cine_Database01DataSet();
            this.cineDatabase01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stuffTableAdapter1 = new Cineplex_prototype_01.cine_Database01DataSetTableAdapters.StuffTableAdapter();
            this.stuffidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stuffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffBindingNavigator)).BeginInit();
            this.stuffBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDatabase01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bb2_stuff
            // 
            this.bb2_stuff.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bb2_stuff.Location = new System.Drawing.Point(12, 439);
            this.bb2_stuff.Name = "bb2_stuff";
            this.bb2_stuff.Size = new System.Drawing.Size(103, 33);
            this.bb2_stuff.TabIndex = 0;
            this.bb2_stuff.Text = "Back";
            this.bb2_stuff.UseVisualStyleBackColor = true;
            this.bb2_stuff.Click += new System.EventHandler(this.bb2_stuff_Click);
            // 
            // cine_Database01DataSet1
            // 
            this.cine_Database01DataSet1.DataSetName = "cine_Database01DataSet1";
            this.cine_Database01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuffBindingSource
            // 
            this.stuffBindingSource.DataMember = "Stuff";
            this.stuffBindingSource.DataSource = this.cine_Database01DataSet1;
            // 
            // stuffTableAdapter
            // 
            this.stuffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cinema_HallTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MovieTableAdapter = null;
            this.tableAdapterManager.Requests_forTableAdapter = null;
            this.tableAdapterManager.ShowsTableAdapter = null;
            this.tableAdapterManager.StuffTableAdapter = this.stuffTableAdapter;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cineplex_prototype_01.cine_Database01DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stuffBindingNavigator
            // 
            this.stuffBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.stuffBindingNavigator.BindingSource = this.stuffBindingSource;
            this.stuffBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.stuffBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.stuffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.stuffBindingNavigatorSaveItem});
            this.stuffBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.stuffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.stuffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.stuffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.stuffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.stuffBindingNavigator.Name = "stuffBindingNavigator";
            this.stuffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.stuffBindingNavigator.Size = new System.Drawing.Size(378, 25);
            this.stuffBindingNavigator.TabIndex = 1;
            this.stuffBindingNavigator.Text = "bindingNavigator1";
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
            // stuffBindingNavigatorSaveItem
            // 
            this.stuffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stuffBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("stuffBindingNavigatorSaveItem.Image")));
            this.stuffBindingNavigatorSaveItem.Name = "stuffBindingNavigatorSaveItem";
            this.stuffBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.stuffBindingNavigatorSaveItem.Text = "Save Data";
            this.stuffBindingNavigatorSaveItem.Click += new System.EventHandler(this.stuffBindingNavigatorSaveItem_Click);
            // 
            // stuffDataGridView
            // 
            this.stuffDataGridView.AutoGenerateColumns = false;
            this.stuffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuffidDataGridViewTextBoxColumn,
            this.stuffnameDataGridViewTextBoxColumn,
            this.hallidDataGridViewTextBoxColumn});
            this.stuffDataGridView.DataSource = this.stuffBindingSource1;
            this.stuffDataGridView.Location = new System.Drawing.Point(12, 43);
            this.stuffDataGridView.Name = "stuffDataGridView";
            this.stuffDataGridView.Size = new System.Drawing.Size(348, 356);
            this.stuffDataGridView.TabIndex = 2;
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
            // stuffBindingSource1
            // 
            this.stuffBindingSource1.DataMember = "Stuff";
            this.stuffBindingSource1.DataSource = this.cineDatabase01DataSetBindingSource;
            // 
            // stuffTableAdapter1
            // 
            this.stuffTableAdapter1.ClearBeforeFill = true;
            // 
            // stuffidDataGridViewTextBoxColumn
            // 
            this.stuffidDataGridViewTextBoxColumn.DataPropertyName = "stuff_id";
            this.stuffidDataGridViewTextBoxColumn.HeaderText = "stuff_id";
            this.stuffidDataGridViewTextBoxColumn.Name = "stuffidDataGridViewTextBoxColumn";
            // 
            // stuffnameDataGridViewTextBoxColumn
            // 
            this.stuffnameDataGridViewTextBoxColumn.DataPropertyName = "stuff_name";
            this.stuffnameDataGridViewTextBoxColumn.HeaderText = "stuff_name";
            this.stuffnameDataGridViewTextBoxColumn.Name = "stuffnameDataGridViewTextBoxColumn";
            // 
            // hallidDataGridViewTextBoxColumn
            // 
            this.hallidDataGridViewTextBoxColumn.DataPropertyName = "hall_id";
            this.hallidDataGridViewTextBoxColumn.HeaderText = "hall_id";
            this.hallidDataGridViewTextBoxColumn.Name = "hallidDataGridViewTextBoxColumn";
            // 
            // form_stuff_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 492);
            this.Controls.Add(this.stuffDataGridView);
            this.Controls.Add(this.stuffBindingNavigator);
            this.Controls.Add(this.bb2_stuff);
            this.Name = "form_stuff_table";
            this.Text = "Stuff Table";
            this.Load += new System.EventHandler(this.form_stuff_table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffBindingNavigator)).EndInit();
            this.stuffBindingNavigator.ResumeLayout(false);
            this.stuffBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stuffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cine_Database01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cineDatabase01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bb2_stuff;
		private cine_Database01DataSet1 cine_Database01DataSet1;
		private System.Windows.Forms.BindingSource stuffBindingSource;
		private cine_Database01DataSet1TableAdapters.StuffTableAdapter stuffTableAdapter;
		private cine_Database01DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator stuffBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton stuffBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView stuffDataGridView;
        private cine_Database01DataSet cine_Database01DataSet;
        private System.Windows.Forms.BindingSource cineDatabase01DataSetBindingSource;
        private System.Windows.Forms.BindingSource stuffBindingSource1;
        private cine_Database01DataSetTableAdapters.StuffTableAdapter stuffTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallidDataGridViewTextBoxColumn;
	}
}