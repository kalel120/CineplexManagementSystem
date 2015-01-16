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
            this.back2mm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back2mm
            // 
            this.back2mm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back2mm.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back2mm.Location = new System.Drawing.Point(32, 22);
            this.back2mm.Name = "back2mm";
            this.back2mm.Size = new System.Drawing.Size(79, 31);
            this.back2mm.TabIndex = 0;
            this.back2mm.Text = "back";
            this.back2mm.UseVisualStyleBackColor = true;
            this.back2mm.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 97);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 93);
            this.textBox1.TabIndex = 1;
            // 
            // movie_schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 501);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back2mm);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "movie_schedule";
            this.Text = "Movie Schedule";
            this.Load += new System.EventHandler(this.movie_schedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button back2mm;
        private System.Windows.Forms.TextBox textBox1;
	}
}