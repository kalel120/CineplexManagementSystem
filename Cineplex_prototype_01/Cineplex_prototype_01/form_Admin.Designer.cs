namespace Cineplex_prototype_01
{
	partial class form_Admin
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
			this.back2mmFrom_Admin = new System.Windows.Forms.Button();
			this.currentState = new System.Windows.Forms.Button();
			this.insertMovie = new System.Windows.Forms.Button();
			this.button_del_movie = new System.Windows.Forms.Button();
			this.seatArrange = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.button_Stuff = new System.Windows.Forms.Button();
			this.btn_Hall_arrange = new System.Windows.Forms.Button();
			this.button_show_ticket_list = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// back2mmFrom_Admin
			// 
			this.back2mmFrom_Admin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2mmFrom_Admin.Location = new System.Drawing.Point(12, 361);
			this.back2mmFrom_Admin.Name = "back2mmFrom_Admin";
			this.back2mmFrom_Admin.Size = new System.Drawing.Size(75, 29);
			this.back2mmFrom_Admin.TabIndex = 0;
			this.back2mmFrom_Admin.Text = "back";
			this.back2mmFrom_Admin.UseVisualStyleBackColor = true;
			this.back2mmFrom_Admin.Click += new System.EventHandler(this.back2mmFrom_Admin_Click);
			// 
			// currentState
			// 
			this.currentState.Font = new System.Drawing.Font("Consolas", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentState.Location = new System.Drawing.Point(198, 12);
			this.currentState.Name = "currentState";
			this.currentState.Size = new System.Drawing.Size(242, 82);
			this.currentState.TabIndex = 1;
			this.currentState.Text = "Show Current State";
			this.currentState.UseVisualStyleBackColor = true;
			this.currentState.Click += new System.EventHandler(this.currentState_Click);
			// 
			// insertMovie
			// 
			this.insertMovie.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.insertMovie.Location = new System.Drawing.Point(12, 123);
			this.insertMovie.Name = "insertMovie";
			this.insertMovie.Size = new System.Drawing.Size(150, 75);
			this.insertMovie.TabIndex = 2;
			this.insertMovie.Text = "Insert Movie";
			this.insertMovie.UseVisualStyleBackColor = true;
			this.insertMovie.Click += new System.EventHandler(this.updateMovie_Click);
			// 
			// button_del_movie
			// 
			this.button_del_movie.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_del_movie.Location = new System.Drawing.Point(251, 123);
			this.button_del_movie.Name = "button_del_movie";
			this.button_del_movie.Size = new System.Drawing.Size(150, 75);
			this.button_del_movie.TabIndex = 3;
			this.button_del_movie.Text = "Delete Movie";
			this.button_del_movie.UseVisualStyleBackColor = true;
			this.button_del_movie.Click += new System.EventHandler(this.button3_Click);
			// 
			// seatArrange
			// 
			this.seatArrange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.seatArrange.Location = new System.Drawing.Point(477, 123);
			this.seatArrange.Name = "seatArrange";
			this.seatArrange.Size = new System.Drawing.Size(150, 75);
			this.seatArrange.TabIndex = 4;
			this.seatArrange.Text = "Update Movie\r\n";
			this.seatArrange.UseVisualStyleBackColor = true;
			this.seatArrange.Click += new System.EventHandler(this.seatArrange_Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(413, 228);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 6;
			// 
			// button_Stuff
			// 
			this.button_Stuff.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Stuff.Location = new System.Drawing.Point(12, 228);
			this.button_Stuff.Name = "button_Stuff";
			this.button_Stuff.Size = new System.Drawing.Size(150, 75);
			this.button_Stuff.TabIndex = 7;
			this.button_Stuff.Text = "Stuff";
			this.button_Stuff.UseVisualStyleBackColor = true;
			this.button_Stuff.Click += new System.EventHandler(this.button_Stuff_Click);
			// 
			// btn_Hall_arrange
			// 
			this.btn_Hall_arrange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Hall_arrange.Location = new System.Drawing.Point(251, 228);
			this.btn_Hall_arrange.Name = "btn_Hall_arrange";
			this.btn_Hall_arrange.Size = new System.Drawing.Size(150, 75);
			this.btn_Hall_arrange.TabIndex = 8;
			this.btn_Hall_arrange.Text = "Hall Arrangement";
			this.btn_Hall_arrange.UseVisualStyleBackColor = true;
			this.btn_Hall_arrange.Click += new System.EventHandler(this.btn_Hall_arrange_Click);
			// 
			// button_show_ticket_list
			// 
			this.button_show_ticket_list.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_show_ticket_list.Location = new System.Drawing.Point(251, 314);
			this.button_show_ticket_list.Name = "button_show_ticket_list";
			this.button_show_ticket_list.Size = new System.Drawing.Size(150, 75);
			this.button_show_ticket_list.TabIndex = 9;
			this.button_show_ticket_list.Text = "Tickets";
			this.button_show_ticket_list.UseVisualStyleBackColor = true;
			this.button_show_ticket_list.Click += new System.EventHandler(this.button_show_ticket_list_Click);
			// 
			// form_Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 401);
			this.Controls.Add(this.button_show_ticket_list);
			this.Controls.Add(this.btn_Hall_arrange);
			this.Controls.Add(this.button_Stuff);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.seatArrange);
			this.Controls.Add(this.button_del_movie);
			this.Controls.Add(this.insertMovie);
			this.Controls.Add(this.currentState);
			this.Controls.Add(this.back2mmFrom_Admin);
			this.Name = "form_Admin";
			this.Text = "Administrator";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back2mmFrom_Admin;
		private System.Windows.Forms.Button currentState;
		private System.Windows.Forms.Button insertMovie;
		private System.Windows.Forms.Button button_del_movie;
		private System.Windows.Forms.Button seatArrange;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button button_Stuff;
		private System.Windows.Forms.Button btn_Hall_arrange;
		private System.Windows.Forms.Button button_show_ticket_list;
	}
}