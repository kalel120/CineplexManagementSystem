﻿namespace Cineplex_prototype_01
{
	partial class form_Customer
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
			this.ticketBooking = new System.Windows.Forms.Button();
			this.rateMovie = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.back2mm_fromCS = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ticketBooking
			// 
			this.ticketBooking.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ticketBooking.Location = new System.Drawing.Point(258, 52);
			this.ticketBooking.Name = "ticketBooking";
			this.ticketBooking.Size = new System.Drawing.Size(186, 66);
			this.ticketBooking.TabIndex = 0;
			this.ticketBooking.Text = "Buy/Book Tickets";
			this.ticketBooking.UseVisualStyleBackColor = true;
			this.ticketBooking.Click += new System.EventHandler(this.ticketBooking_Click);
			// 
			// rateMovie
			// 
			this.rateMovie.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rateMovie.Location = new System.Drawing.Point(258, 155);
			this.rateMovie.Name = "rateMovie";
			this.rateMovie.Size = new System.Drawing.Size(186, 66);
			this.rateMovie.TabIndex = 1;
			this.rateMovie.Text = "Rate Movie";
			this.rateMovie.UseVisualStyleBackColor = true;
			this.rateMovie.Click += new System.EventHandler(this.rateMovie_Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(486, 331);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 2;
			// 
			// back2mm_fromCS
			// 
			this.back2mm_fromCS.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2mm_fromCS.Location = new System.Drawing.Point(12, 464);
			this.back2mm_fromCS.Name = "back2mm_fromCS";
			this.back2mm_fromCS.Size = new System.Drawing.Size(75, 29);
			this.back2mm_fromCS.TabIndex = 3;
			this.back2mm_fromCS.Text = "back";
			this.back2mm_fromCS.UseVisualStyleBackColor = true;
			this.back2mm_fromCS.Click += new System.EventHandler(this.back2mm_fromCS_Click);
			// 
			// form_Customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 511);
			this.Controls.Add(this.back2mm_fromCS);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.rateMovie);
			this.Controls.Add(this.ticketBooking);
			this.Name = "form_Customer";
			this.Text = "Cutomer View";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ticketBooking;
		private System.Windows.Forms.Button rateMovie;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button back2mm_fromCS;
	}
}