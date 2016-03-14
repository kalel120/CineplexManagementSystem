namespace Cineplex_prototype_01
{
	partial class form_SeatArrange
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
			this.back2Admin_formSA = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// back2Admin_formSA
			// 
			this.back2Admin_formSA.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2Admin_formSA.Location = new System.Drawing.Point(12, 224);
			this.back2Admin_formSA.Name = "back2Admin_formSA";
			this.back2Admin_formSA.Size = new System.Drawing.Size(75, 25);
			this.back2Admin_formSA.TabIndex = 0;
			this.back2Admin_formSA.Text = "back";
			this.back2Admin_formSA.UseVisualStyleBackColor = true;
			this.back2Admin_formSA.Click += new System.EventHandler(this.back2Admin_formSA_Click);
			// 
			// form_SeatArrange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.back2Admin_formSA);
			this.Name = "form_SeatArrange";
			this.Text = "Seat Arrangement";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button back2Admin_formSA;
	}
}