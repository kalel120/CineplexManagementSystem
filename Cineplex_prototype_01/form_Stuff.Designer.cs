namespace Cineplex_prototype_01
{
	partial class form_Stuff
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.bb2_Admin_from_Stuff = new System.Windows.Forms.Button();
			this.button_submit_stuff = new System.Windows.Forms.Button();
			this.button_stuff_table = new System.Windows.Forms.Button();
			this.button_clr_stable = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Stuff ID";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(297, 34);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 34);
			this.label2.TabIndex = 1;
			this.label2.Text = "Stuff Name";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(545, 34);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hall Id";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(33, 80);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(122, 25);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(301, 80);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(122, 25);
			this.textBox2.TabIndex = 4;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(549, 80);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(122, 25);
			this.textBox3.TabIndex = 5;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// bb2_Admin_from_Stuff
			// 
			this.bb2_Admin_from_Stuff.Location = new System.Drawing.Point(33, 460);
			this.bb2_Admin_from_Stuff.Name = "bb2_Admin_from_Stuff";
			this.bb2_Admin_from_Stuff.Size = new System.Drawing.Size(122, 32);
			this.bb2_Admin_from_Stuff.TabIndex = 6;
			this.bb2_Admin_from_Stuff.Text = "back";
			this.bb2_Admin_from_Stuff.UseVisualStyleBackColor = true;
			this.bb2_Admin_from_Stuff.Click += new System.EventHandler(this.bb2_Admin_from_Stuff_Click);
			// 
			// button_submit_stuff
			// 
			this.button_submit_stuff.Location = new System.Drawing.Point(301, 149);
			this.button_submit_stuff.Name = "button_submit_stuff";
			this.button_submit_stuff.Size = new System.Drawing.Size(122, 32);
			this.button_submit_stuff.TabIndex = 7;
			this.button_submit_stuff.Text = "Submit";
			this.button_submit_stuff.UseVisualStyleBackColor = true;
			this.button_submit_stuff.Click += new System.EventHandler(this.button_submit_stuff_Click);
			// 
			// button_stuff_table
			// 
			this.button_stuff_table.Location = new System.Drawing.Point(301, 264);
			this.button_stuff_table.Name = "button_stuff_table";
			this.button_stuff_table.Size = new System.Drawing.Size(122, 49);
			this.button_stuff_table.TabIndex = 8;
			this.button_stuff_table.Text = "Show Stuff Table";
			this.button_stuff_table.UseVisualStyleBackColor = true;
			this.button_stuff_table.Click += new System.EventHandler(this.button_stuff_table_Click);
			// 
			// button_clr_stable
			// 
			this.button_clr_stable.Location = new System.Drawing.Point(587, 410);
			this.button_clr_stable.Name = "button_clr_stable";
			this.button_clr_stable.Size = new System.Drawing.Size(108, 73);
			this.button_clr_stable.TabIndex = 9;
			this.button_clr_stable.Text = "Clear Stuff Table";
			this.button_clr_stable.UseVisualStyleBackColor = true;
			this.button_clr_stable.Click += new System.EventHandler(this.button_clr_stable_Click);
			// 
			// form_Stuff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 504);
			this.Controls.Add(this.button_clr_stable);
			this.Controls.Add(this.button_stuff_table);
			this.Controls.Add(this.button_submit_stuff);
			this.Controls.Add(this.bb2_Admin_from_Stuff);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "form_Stuff";
			this.Text = "Stuff";
			this.Load += new System.EventHandler(this.form_Stuff_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button bb2_Admin_from_Stuff;
		private System.Windows.Forms.Button button_submit_stuff;
		private System.Windows.Forms.Button button_stuff_table;
		private System.Windows.Forms.Button button_clr_stable;
	}
}