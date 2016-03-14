namespace Cineplex_prototype_01
{
	partial class form_Delete_Movie
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
			this.back2Admin_formDelM = new System.Windows.Forms.Button();
			this.button_clr_M_list = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label_movie_name = new System.Windows.Forms.Label();
			this.textBox_movie_name = new System.Windows.Forms.TextBox();
			this.button_submit = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// back2Admin_formDelM
			// 
			this.back2Admin_formDelM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2Admin_formDelM.Location = new System.Drawing.Point(25, 297);
			this.back2Admin_formDelM.Name = "back2Admin_formDelM";
			this.back2Admin_formDelM.Size = new System.Drawing.Size(75, 27);
			this.back2Admin_formDelM.TabIndex = 0;
			this.back2Admin_formDelM.Text = "back";
			this.back2Admin_formDelM.UseVisualStyleBackColor = true;
			this.back2Admin_formDelM.Click += new System.EventHandler(this.back2Admin_formTS_Click);
			// 
			// button_clr_M_list
			// 
			this.button_clr_M_list.BackColor = System.Drawing.Color.Red;
			this.button_clr_M_list.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_clr_M_list.ForeColor = System.Drawing.Color.Honeydew;
			this.button_clr_M_list.Location = new System.Drawing.Point(303, 72);
			this.button_clr_M_list.Name = "button_clr_M_list";
			this.button_clr_M_list.Size = new System.Drawing.Size(97, 80);
			this.button_clr_M_list.TabIndex = 1;
			this.button_clr_M_list.Text = "Clear Movie List";
			this.button_clr_M_list.UseVisualStyleBackColor = false;
			this.button_clr_M_list.Click += new System.EventHandler(this.button_clr_M_list_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(95, -58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Movie to Delete";
			// 
			// label_movie_name
			// 
			this.label_movie_name.AutoSize = true;
			this.label_movie_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_movie_name.Location = new System.Drawing.Point(21, 72);
			this.label_movie_name.Name = "label_movie_name";
			this.label_movie_name.Size = new System.Drawing.Size(153, 19);
			this.label_movie_name.TabIndex = 3;
			this.label_movie_name.Text = "Input Movie Name";
			// 
			// textBox_movie_name
			// 
			this.textBox_movie_name.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_movie_name.Location = new System.Drawing.Point(25, 110);
			this.textBox_movie_name.Multiline = true;
			this.textBox_movie_name.Name = "textBox_movie_name";
			this.textBox_movie_name.Size = new System.Drawing.Size(149, 31);
			this.textBox_movie_name.TabIndex = 4;
			this.textBox_movie_name.TextChanged += new System.EventHandler(this.textBox_movie_name_TextChanged);
			// 
			// button_submit
			// 
			this.button_submit.BackColor = System.Drawing.Color.RoyalBlue;
			this.button_submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_submit.ForeColor = System.Drawing.Color.White;
			this.button_submit.Location = new System.Drawing.Point(25, 168);
			this.button_submit.Name = "button_submit";
			this.button_submit.Size = new System.Drawing.Size(87, 38);
			this.button_submit.TabIndex = 5;
			this.button_submit.Text = "Submit";
			this.button_submit.UseVisualStyleBackColor = false;
			this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(117, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 31);
			this.label2.TabIndex = 6;
			this.label2.Text = "Movie to Delete";
			// 
			// form_Delete_Movie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 331);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_submit);
			this.Controls.Add(this.textBox_movie_name);
			this.Controls.Add(this.label_movie_name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_clr_M_list);
			this.Controls.Add(this.back2Admin_formDelM);
			this.Name = "form_Delete_Movie";
			this.Text = "Delete Movie";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button back2Admin_formDelM;
		private System.Windows.Forms.Button button_clr_M_list;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_movie_name;
		private System.Windows.Forms.TextBox textBox_movie_name;
		private System.Windows.Forms.Button button_submit;
		private System.Windows.Forms.Label label2;
	}
}