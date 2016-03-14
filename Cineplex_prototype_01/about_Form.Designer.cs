namespace Cineplex_prototype_01
{
	partial class about_Form
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
			this.label1 = new System.Windows.Forms.Label();
			this.back2mmFrom_about = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoEllipsis = true;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(440, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "This is a project about Cineplex Management";
			// 
			// back2mmFrom_about
			// 
			this.back2mmFrom_about.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2mmFrom_about.Location = new System.Drawing.Point(26, 217);
			this.back2mmFrom_about.Name = "back2mmFrom_about";
			this.back2mmFrom_about.Size = new System.Drawing.Size(75, 35);
			this.back2mmFrom_about.TabIndex = 2;
			this.back2mmFrom_about.Text = "back";
			this.back2mmFrom_about.UseVisualStyleBackColor = true;
			this.back2mmFrom_about.Click += new System.EventHandler(this.back2mmFrom_about_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(194, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "v1.0.0";
			// 
			// about_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.back2mmFrom_about);
			this.Controls.Add(this.label1);
			this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Name = "about_Form";
			this.Text = "About";
			this.Load += new System.EventHandler(this.About_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button back2mmFrom_about;
		private System.Windows.Forms.Label label2;

	}
}