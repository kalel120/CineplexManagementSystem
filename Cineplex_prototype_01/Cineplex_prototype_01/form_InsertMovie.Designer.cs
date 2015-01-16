namespace Cineplex_prototype_01
{
	partial class form_Insert_Movie
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
			this.back2Admin_fromUM = new System.Windows.Forms.Button();
			this.label_mid = new System.Windows.Forms.Label();
			this.label_title = new System.Windows.Forms.Label();
			this.label_show_time = new System.Windows.Forms.Label();
			this.label_release_date = new System.Windows.Forms.Label();
			this.label_gener = new System.Windows.Forms.Label();
			this.textBox_id = new System.Windows.Forms.TextBox();
			this.textBox_title = new System.Windows.Forms.TextBox();
			this.textBox_st = new System.Windows.Forms.TextBox();
			this.textBox_rd = new System.Windows.Forms.TextBox();
			this.button_submit = new System.Windows.Forms.Button();
			this.comboBox_gener = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// back2Admin_fromUM
			// 
			this.back2Admin_fromUM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2Admin_fromUM.Location = new System.Drawing.Point(16, 456);
			this.back2Admin_fromUM.Name = "back2Admin_fromUM";
			this.back2Admin_fromUM.Size = new System.Drawing.Size(75, 29);
			this.back2Admin_fromUM.TabIndex = 0;
			this.back2Admin_fromUM.Text = "back";
			this.back2Admin_fromUM.UseVisualStyleBackColor = true;
			this.back2Admin_fromUM.Click += new System.EventHandler(this.back2Admin_fromUM_Click);
			// 
			// label_mid
			// 
			this.label_mid.AutoSize = true;
			this.label_mid.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mid.Location = new System.Drawing.Point(37, 30);
			this.label_mid.Name = "label_mid";
			this.label_mid.Size = new System.Drawing.Size(81, 19);
			this.label_mid.TabIndex = 1;
			this.label_mid.Text = "Movie_ID";
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_title.Location = new System.Drawing.Point(37, 105);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(108, 19);
			this.label_title.TabIndex = 2;
			this.label_title.Text = "Movie_Title";
			// 
			// label_show_time
			// 
			this.label_show_time.AutoSize = true;
			this.label_show_time.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_show_time.Location = new System.Drawing.Point(37, 176);
			this.label_show_time.Name = "label_show_time";
			this.label_show_time.Size = new System.Drawing.Size(90, 19);
			this.label_show_time.TabIndex = 3;
			this.label_show_time.Text = "Show_Time";
			// 
			// label_release_date
			// 
			this.label_release_date.AutoSize = true;
			this.label_release_date.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_release_date.Location = new System.Drawing.Point(37, 267);
			this.label_release_date.Name = "label_release_date";
			this.label_release_date.Size = new System.Drawing.Size(117, 19);
			this.label_release_date.TabIndex = 4;
			this.label_release_date.Text = "Release Date";
			this.label_release_date.Click += new System.EventHandler(this.label4_Click);
			// 
			// label_gener
			// 
			this.label_gener.AutoSize = true;
			this.label_gener.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_gener.Location = new System.Drawing.Point(37, 337);
			this.label_gener.Name = "label_gener";
			this.label_gener.Size = new System.Drawing.Size(54, 19);
			this.label_gener.TabIndex = 5;
			this.label_gener.Text = "Gener";
			// 
			// textBox_id
			// 
			this.textBox_id.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_id.Location = new System.Drawing.Point(205, 31);
			this.textBox_id.Name = "textBox_id";
			this.textBox_id.Size = new System.Drawing.Size(156, 26);
			this.textBox_id.TabIndex = 6;
			this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
			// 
			// textBox_title
			// 
			this.textBox_title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_title.Location = new System.Drawing.Point(205, 104);
			this.textBox_title.Name = "textBox_title";
			this.textBox_title.Size = new System.Drawing.Size(156, 26);
			this.textBox_title.TabIndex = 7;
			this.textBox_title.TextChanged += new System.EventHandler(this.textBox_title_TextChanged);
			// 
			// textBox_st
			// 
			this.textBox_st.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_st.Location = new System.Drawing.Point(205, 176);
			this.textBox_st.Name = "textBox_st";
			this.textBox_st.Size = new System.Drawing.Size(156, 26);
			this.textBox_st.TabIndex = 8;
			this.textBox_st.TextChanged += new System.EventHandler(this.textBox_st_TextChanged);
			// 
			// textBox_rd
			// 
			this.textBox_rd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_rd.Location = new System.Drawing.Point(205, 266);
			this.textBox_rd.Name = "textBox_rd";
			this.textBox_rd.Size = new System.Drawing.Size(156, 26);
			this.textBox_rd.TabIndex = 9;
			this.textBox_rd.TextChanged += new System.EventHandler(this.textBox_rd_TextChanged);
			// 
			// button_submit
			// 
			this.button_submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_submit.Location = new System.Drawing.Point(566, 176);
			this.button_submit.Name = "button_submit";
			this.button_submit.Size = new System.Drawing.Size(96, 71);
			this.button_submit.TabIndex = 11;
			this.button_submit.Text = "Submit";
			this.button_submit.UseVisualStyleBackColor = true;
			this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
			// 
			// comboBox_gener
			// 
			this.comboBox_gener.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_gener.FormattingEnabled = true;
			this.comboBox_gener.Items.AddRange(new object[] {
            "Action",
            "Adventure\t",
            "Biography",
            "Comady",
            "Documentary",
            "Horror",
            "Sci-Fi",
            "Spy Thriller"});
			this.comboBox_gener.Location = new System.Drawing.Point(205, 338);
			this.comboBox_gener.Name = "comboBox_gener";
			this.comboBox_gener.Size = new System.Drawing.Size(156, 27);
			this.comboBox_gener.TabIndex = 12;
			this.comboBox_gener.Text = "Select Gener";
			this.comboBox_gener.SelectedIndexChanged += new System.EventHandler(this.comboBox_gener_SelectedIndexChanged);
			// 
			// form_Insert_Movie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(710, 497);
			this.Controls.Add(this.comboBox_gener);
			this.Controls.Add(this.button_submit);
			this.Controls.Add(this.textBox_rd);
			this.Controls.Add(this.textBox_st);
			this.Controls.Add(this.textBox_title);
			this.Controls.Add(this.textBox_id);
			this.Controls.Add(this.label_gener);
			this.Controls.Add(this.label_release_date);
			this.Controls.Add(this.label_show_time);
			this.Controls.Add(this.label_title);
			this.Controls.Add(this.label_mid);
			this.Controls.Add(this.back2Admin_fromUM);
			this.Name = "form_Insert_Movie";
			this.Text = "Insert Movie";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button back2Admin_fromUM;
		private System.Windows.Forms.Label label_mid;
		private System.Windows.Forms.Label label_title;
		private System.Windows.Forms.Label label_show_time;
		private System.Windows.Forms.Label label_release_date;
		private System.Windows.Forms.Label label_gener;
		private System.Windows.Forms.TextBox textBox_id;
		private System.Windows.Forms.TextBox textBox_title;
		private System.Windows.Forms.TextBox textBox_st;
		private System.Windows.Forms.TextBox textBox_rd;
		private System.Windows.Forms.Button button_submit;
		private System.Windows.Forms.ComboBox comboBox_gener;
	}
}