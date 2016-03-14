namespace Cineplex_prototype_01
{
	partial class form_UpdateMovie
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
			this.SuspendLayout();
			// 
			// back2Admin_fromUM
			// 
			this.back2Admin_fromUM.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2Admin_fromUM.Location = new System.Drawing.Point(13, 220);
			this.back2Admin_fromUM.Name = "back2Admin_fromUM";
			this.back2Admin_fromUM.Size = new System.Drawing.Size(75, 29);
			this.back2Admin_fromUM.TabIndex = 0;
			this.back2Admin_fromUM.Text = "back";
			this.back2Admin_fromUM.UseVisualStyleBackColor = true;
			this.back2Admin_fromUM.Click += new System.EventHandler(this.back2Admin_fromUM_Click);
			// 
			// form_UpdateMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.back2Admin_fromUM);
			this.Name = "form_UpdateMovie";
			this.Text = "Update Movie";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back2Admin_fromUM;
	}
}