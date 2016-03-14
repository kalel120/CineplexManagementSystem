namespace Cineplex_prototype_01
{
	partial class form_Tkt_BB
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
			this.label_name = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_cs_name = new System.Windows.Forms.TextBox();
			this.back2Customer_formTB = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.textBox_m_name = new System.Windows.Forms.TextBox();
			this.label_ttype = new System.Windows.Forms.Label();
			this.textBox_m_date = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label_amount = new System.Windows.Forms.Label();
			this.textBox_tkt_amount = new System.Windows.Forms.TextBox();
			this.button_check_out = new System.Windows.Forms.Button();
			this.button_pay_amount = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_name
			// 
			this.label_name.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_name.Location = new System.Drawing.Point(12, 34);
			this.label_name.Name = "label_name";
			this.label_name.Size = new System.Drawing.Size(169, 22);
			this.label_name.TabIndex = 0;
			this.label_name.Text = "Input your Name\r\n\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(534, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Input Movie ID\r\n";
			// 
			// textBox_cs_name
			// 
			this.textBox_cs_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_cs_name.Location = new System.Drawing.Point(16, 59);
			this.textBox_cs_name.Multiline = true;
			this.textBox_cs_name.Name = "textBox_cs_name";
			this.textBox_cs_name.Size = new System.Drawing.Size(201, 29);
			this.textBox_cs_name.TabIndex = 2;
			this.textBox_cs_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// back2Customer_formTB
			// 
			this.back2Customer_formTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.back2Customer_formTB.Location = new System.Drawing.Point(16, 466);
			this.back2Customer_formTB.Name = "back2Customer_formTB";
			this.back2Customer_formTB.Size = new System.Drawing.Size(75, 29);
			this.back2Customer_formTB.TabIndex = 3;
			this.back2Customer_formTB.Text = "back";
			this.back2Customer_formTB.UseVisualStyleBackColor = true;
			this.back2Customer_formTB.Click += new System.EventHandler(this.back2Customer_formTB_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(534, 237);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 44);
			this.label3.TabIndex = 4;
			this.label3.Text = "Payment Method\r\n\r\n";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.radioButton1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(538, 285);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(81, 23);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Online";
			this.radioButton1.UseVisualStyleBackColor = false;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.radioButton2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(649, 285);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(90, 23);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Offline";
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// textBox_m_name
			// 
			this.textBox_m_name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_m_name.Location = new System.Drawing.Point(538, 59);
			this.textBox_m_name.Multiline = true;
			this.textBox_m_name.Name = "textBox_m_name";
			this.textBox_m_name.Size = new System.Drawing.Size(201, 29);
			this.textBox_m_name.TabIndex = 7;
			this.textBox_m_name.TextChanged += new System.EventHandler(this.textBox_m_name_TextChanged);
			// 
			// label_ttype
			// 
			this.label_ttype.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ttype.Location = new System.Drawing.Point(12, 127);
			this.label_ttype.Name = "label_ttype";
			this.label_ttype.Size = new System.Drawing.Size(181, 29);
			this.label_ttype.TabIndex = 8;
			this.label_ttype.Text = "Input Ticket Type";
			// 
			// textBox_m_date
			// 
			this.textBox_m_date.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_m_date.Location = new System.Drawing.Point(538, 159);
			this.textBox_m_date.Multiline = true;
			this.textBox_m_date.Name = "textBox_m_date";
			this.textBox_m_date.Size = new System.Drawing.Size(201, 29);
			this.textBox_m_date.TabIndex = 9;
			this.textBox_m_date.TextChanged += new System.EventHandler(this.textBox1_m_date_TextChanged_1);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(534, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 29);
			this.label1.TabIndex = 10;
			this.label1.Text = "Input Date";
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
			this.comboBox1.Location = new System.Drawing.Point(16, 177);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(201, 27);
			this.comboBox1.TabIndex = 11;
			this.comboBox1.Text = "Select Ticket type";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label_amount
			// 
			this.label_amount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_amount.Location = new System.Drawing.Point(12, 237);
			this.label_amount.Name = "label_amount";
			this.label_amount.Size = new System.Drawing.Size(181, 29);
			this.label_amount.TabIndex = 12;
			this.label_amount.Text = "How many tickets?\r\n\r\n";
			// 
			// textBox_tkt_amount
			// 
			this.textBox_tkt_amount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_tkt_amount.Location = new System.Drawing.Point(16, 279);
			this.textBox_tkt_amount.Multiline = true;
			this.textBox_tkt_amount.Name = "textBox_tkt_amount";
			this.textBox_tkt_amount.Size = new System.Drawing.Size(201, 29);
			this.textBox_tkt_amount.TabIndex = 13;
			this.textBox_tkt_amount.TextChanged += new System.EventHandler(this.textBox_tkt_amount_TextChanged);
			// 
			// button_check_out
			// 
			this.button_check_out.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_check_out.Location = new System.Drawing.Point(16, 345);
			this.button_check_out.Name = "button_check_out";
			this.button_check_out.Size = new System.Drawing.Size(108, 42);
			this.button_check_out.TabIndex = 14;
			this.button_check_out.Text = "Check Out";
			this.button_check_out.UseVisualStyleBackColor = true;
			this.button_check_out.Click += new System.EventHandler(this.button_check_out_Click);
			// 
			// button_pay_amount
			// 
			this.button_pay_amount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_pay_amount.Location = new System.Drawing.Point(282, 345);
			this.button_pay_amount.Name = "button_pay_amount";
			this.button_pay_amount.Size = new System.Drawing.Size(193, 97);
			this.button_pay_amount.TabIndex = 15;
			this.button_pay_amount.Text = "Show Payable Amount in ৳ ";
			this.button_pay_amount.UseVisualStyleBackColor = true;
			this.button_pay_amount.Click += new System.EventHandler(this.button_pay_amount_Click);
			// 
			// form_Tkt_BB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 523);
			this.Controls.Add(this.button_pay_amount);
			this.Controls.Add(this.button_check_out);
			this.Controls.Add(this.textBox_tkt_amount);
			this.Controls.Add(this.label_amount);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_m_date);
			this.Controls.Add(this.label_ttype);
			this.Controls.Add(this.textBox_m_name);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.back2Customer_formTB);
			this.Controls.Add(this.textBox_cs_name);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label_name);
			this.Name = "form_Tkt_BB";
			this.Text = "Buy/Book Tickets";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_cs_name;
		private System.Windows.Forms.Button back2Customer_formTB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox textBox_m_name;
		private System.Windows.Forms.Label label_ttype;
		private System.Windows.Forms.TextBox textBox_m_date;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label_amount;
		private System.Windows.Forms.TextBox textBox_tkt_amount;
		private System.Windows.Forms.Button button_check_out;
		private System.Windows.Forms.Button button_pay_amount;
	}
}