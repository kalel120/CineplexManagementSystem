namespace Cineplex_prototype_01
{
	partial class form_Hall_arrangement
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
			this.bb2admi_from_hall = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_hid = new System.Windows.Forms.TextBox();
			this.textBox_mid = new System.Windows.Forms.TextBox();
			this.button_submit = new System.Windows.Forms.Button();
			this.button_show_list = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bb2admi_from_hall
			// 
			this.bb2admi_from_hall.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bb2admi_from_hall.Location = new System.Drawing.Point(12, 450);
			this.bb2admi_from_hall.Name = "bb2admi_from_hall";
			this.bb2admi_from_hall.Size = new System.Drawing.Size(95, 33);
			this.bb2admi_from_hall.TabIndex = 0;
			this.bb2admi_from_hall.Text = "back";
			this.bb2admi_from_hall.UseVisualStyleBackColor = true;
			this.bb2admi_from_hall.Click += new System.EventHandler(this.bb2admi_from_hall_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Input Hall Id";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Input Movie ID";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox_hid
			// 
			this.textBox_hid.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_hid.Location = new System.Drawing.Point(18, 90);
			this.textBox_hid.Multiline = true;
			this.textBox_hid.Name = "textBox_hid";
			this.textBox_hid.Size = new System.Drawing.Size(150, 30);
			this.textBox_hid.TabIndex = 3;
			this.textBox_hid.TextChanged += new System.EventHandler(this.textBox_hid_TextChanged);
			// 
			// textBox_mid
			// 
			this.textBox_mid.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_mid.Location = new System.Drawing.Point(18, 190);
			this.textBox_mid.Multiline = true;
			this.textBox_mid.Name = "textBox_mid";
			this.textBox_mid.Size = new System.Drawing.Size(150, 30);
			this.textBox_mid.TabIndex = 4;
			this.textBox_mid.TextChanged += new System.EventHandler(this.textBox_mid_TextChanged);
			// 
			// button_submit
			// 
			this.button_submit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_submit.Location = new System.Drawing.Point(19, 251);
			this.button_submit.Name = "button_submit";
			this.button_submit.Size = new System.Drawing.Size(95, 45);
			this.button_submit.TabIndex = 5;
			this.button_submit.Text = "Submit";
			this.button_submit.UseVisualStyleBackColor = true;
			this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
			// 
			// button_show_list
			// 
			this.button_show_list.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_show_list.Location = new System.Drawing.Point(418, 120);
			this.button_show_list.Name = "button_show_list";
			this.button_show_list.Size = new System.Drawing.Size(95, 50);
			this.button_show_list.TabIndex = 6;
			this.button_show_list.Text = "Show List";
			this.button_show_list.UseVisualStyleBackColor = true;
			this.button_show_list.Click += new System.EventHandler(this.button_show_list_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(418, 433);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 50);
			this.button1.TabIndex = 7;
			this.button1.Text = "Clear List";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// form_Hall_arrangement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 495);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_show_list);
			this.Controls.Add(this.button_submit);
			this.Controls.Add(this.textBox_mid);
			this.Controls.Add(this.textBox_hid);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bb2admi_from_hall);
			this.Name = "form_Hall_arrangement";
			this.Text = "Hall Arrangement";
			this.Load += new System.EventHandler(this.form_Hall_arrangement_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bb2admi_from_hall;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_hid;
		private System.Windows.Forms.TextBox textBox_mid;
		private System.Windows.Forms.Button button_submit;
		private System.Windows.Forms.Button button_show_list;
		private System.Windows.Forms.Button button1;
	}
}