namespace Cineplex_prototype_01
{
	partial class main_Menu
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
			this.project_name = new System.Windows.Forms.Label();
			this.movi_schedul = new System.Windows.Forms.Button();
			this.login_admin = new System.Windows.Forms.Button();
			this.login_customer = new System.Windows.Forms.Button();
			this.button_about = new System.Windows.Forms.Button();
			this.finish_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// project_name
			// 
			this.project_name.BackColor = System.Drawing.Color.Transparent;
			this.project_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.project_name.Font = new System.Drawing.Font("Viner Hand ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.project_name.ForeColor = System.Drawing.Color.Maroon;
			this.project_name.Location = new System.Drawing.Point(91, 9);
			this.project_name.Name = "project_name";
			this.project_name.Size = new System.Drawing.Size(481, 60);
			this.project_name.TabIndex = 0;
			this.project_name.Text = "Cineplex Management System";
			this.project_name.Click += new System.EventHandler(this.label1_Click);
			// 
			// movi_schedul
			// 
			this.movi_schedul.BackColor = System.Drawing.Color.IndianRed;
			this.movi_schedul.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.movi_schedul.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.movi_schedul.Location = new System.Drawing.Point(250, 211);
			this.movi_schedul.Name = "movi_schedul";
			this.movi_schedul.Size = new System.Drawing.Size(119, 55);
			this.movi_schedul.TabIndex = 1;
			this.movi_schedul.Text = "Movie Schedule";
			this.movi_schedul.UseVisualStyleBackColor = false;
			this.movi_schedul.Click += new System.EventHandler(this.button1_Click);
			// 
			// login_admin
			// 
			this.login_admin.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.login_admin.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_admin.Location = new System.Drawing.Point(38, 280);
			this.login_admin.Name = "login_admin";
			this.login_admin.Size = new System.Drawing.Size(200, 71);
			this.login_admin.TabIndex = 2;
			this.login_admin.Text = "Log in as Admin";
			this.login_admin.UseVisualStyleBackColor = false;
			this.login_admin.Click += new System.EventHandler(this.button2_Click);
			// 
			// login_customer
			// 
			this.login_customer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.login_customer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_customer.Location = new System.Drawing.Point(410, 280);
			this.login_customer.Name = "login_customer";
			this.login_customer.Size = new System.Drawing.Size(200, 71);
			this.login_customer.TabIndex = 3;
			this.login_customer.Text = "Browse as Customer";
			this.login_customer.UseVisualStyleBackColor = false;
			this.login_customer.Click += new System.EventHandler(this.login_customer_Click);
			// 
			// button_about
			// 
			this.button_about.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_about.Location = new System.Drawing.Point(491, 438);
			this.button_about.Name = "button_about";
			this.button_about.Size = new System.Drawing.Size(119, 38);
			this.button_about.TabIndex = 4;
			this.button_about.Text = "About";
			this.button_about.UseVisualStyleBackColor = true;
			this.button_about.Click += new System.EventHandler(this.button_about_Click);
			// 
			// finish_button
			// 
			this.finish_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.finish_button.Location = new System.Drawing.Point(38, 438);
			this.finish_button.Name = "finish_button";
			this.finish_button.Size = new System.Drawing.Size(119, 35);
			this.finish_button.TabIndex = 5;
			this.finish_button.Text = "Exit";
			this.finish_button.UseVisualStyleBackColor = true;
			this.finish_button.Click += new System.EventHandler(this.finish_button_Click);
			// 
			// main_Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Cineplex_prototype_01.Properties.Resources.cineplexMobile_Playbook_1_spk;
			this.ClientSize = new System.Drawing.Size(654, 486);
			this.Controls.Add(this.finish_button);
			this.Controls.Add(this.button_about);
			this.Controls.Add(this.login_customer);
			this.Controls.Add(this.login_admin);
			this.Controls.Add(this.movi_schedul);
			this.Controls.Add(this.project_name);
			this.Name = "main_Menu";
			this.Text = "Main Menu";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label project_name;
		private System.Windows.Forms.Button movi_schedul;
		private System.Windows.Forms.Button login_admin;
		private System.Windows.Forms.Button login_customer;
		private System.Windows.Forms.Button button_about;
		private System.Windows.Forms.Button finish_button;
	}
}

