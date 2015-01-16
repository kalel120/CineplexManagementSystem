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
            this.updateMovie = new System.Windows.Forms.Button();
            this.ticktSell = new System.Windows.Forms.Button();
            this.seatArrange = new System.Windows.Forms.Button();
            this.refButton = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.freezSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back2mmFrom_Admin
            // 
            this.back2mmFrom_Admin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2mmFrom_Admin.Location = new System.Drawing.Point(12, 420);
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
            this.currentState.Location = new System.Drawing.Point(49, 57);
            this.currentState.Name = "currentState";
            this.currentState.Size = new System.Drawing.Size(242, 82);
            this.currentState.TabIndex = 1;
            this.currentState.Text = "Show Current State";
            this.currentState.UseVisualStyleBackColor = true;
            this.currentState.Click += new System.EventHandler(this.currentState_Click);
            // 
            // updateMovie
            // 
            this.updateMovie.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateMovie.Location = new System.Drawing.Point(49, 145);
            this.updateMovie.Name = "updateMovie";
            this.updateMovie.Size = new System.Drawing.Size(242, 76);
            this.updateMovie.TabIndex = 2;
            this.updateMovie.Text = "Update Movie";
            this.updateMovie.UseVisualStyleBackColor = true;
            this.updateMovie.Click += new System.EventHandler(this.updateMovie_Click);
            // 
            // ticktSell
            // 
            this.ticktSell.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticktSell.Location = new System.Drawing.Point(49, 227);
            this.ticktSell.Name = "ticktSell";
            this.ticktSell.Size = new System.Drawing.Size(242, 72);
            this.ticktSell.TabIndex = 3;
            this.ticktSell.Text = "ticket Sell";
            this.ticktSell.UseVisualStyleBackColor = true;
            this.ticktSell.Click += new System.EventHandler(this.button3_Click);
            // 
            // seatArrange
            // 
            this.seatArrange.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seatArrange.Location = new System.Drawing.Point(49, 305);
            this.seatArrange.Name = "seatArrange";
            this.seatArrange.Size = new System.Drawing.Size(242, 75);
            this.seatArrange.TabIndex = 4;
            this.seatArrange.Text = "Seat Arrangement";
            this.seatArrange.UseVisualStyleBackColor = true;
            this.seatArrange.Click += new System.EventHandler(this.seatArrange_Click);
            // 
            // refButton
            // 
            this.refButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refButton.Location = new System.Drawing.Point(545, 57);
            this.refButton.Name = "refButton";
            this.refButton.Size = new System.Drawing.Size(82, 82);
            this.refButton.TabIndex = 5;
            this.refButton.Text = "Refresh";
            this.refButton.UseVisualStyleBackColor = true;
            this.refButton.Click += new System.EventHandler(this.refButton_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(400, 218);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // freezSystem
            // 
            this.freezSystem.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freezSystem.Location = new System.Drawing.Point(512, 420);
            this.freezSystem.Name = "freezSystem";
            this.freezSystem.Size = new System.Drawing.Size(125, 29);
            this.freezSystem.TabIndex = 7;
            this.freezSystem.Text = "Freez System";
            this.freezSystem.UseVisualStyleBackColor = true;
            // 
            // form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 461);
            this.Controls.Add(this.freezSystem);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.refButton);
            this.Controls.Add(this.seatArrange);
            this.Controls.Add(this.ticktSell);
            this.Controls.Add(this.updateMovie);
            this.Controls.Add(this.currentState);
            this.Controls.Add(this.back2mmFrom_Admin);
            this.Name = "form_Admin";
            this.Text = "Administrator";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back2mmFrom_Admin;
		private System.Windows.Forms.Button currentState;
		private System.Windows.Forms.Button updateMovie;
		private System.Windows.Forms.Button ticktSell;
		private System.Windows.Forms.Button seatArrange;
		private System.Windows.Forms.Button refButton;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button freezSystem;
	}
}