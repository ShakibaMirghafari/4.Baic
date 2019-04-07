namespace جلسه_چهارم
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.redHScrollBar = new System.Windows.Forms.HScrollBar();
			this.blueHScrollBar = new System.Windows.Forms.HScrollBar();
			this.greenHScrollBar = new System.Windows.Forms.HScrollBar();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 13);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "Hello World!";
			this.textBox1.Enter += new System.EventHandler(this.TextBox_Enter);
			this.textBox1.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(13, 39);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.Text = "Hello World!";
			this.textBox2.Enter += new System.EventHandler(this.TextBox_Enter);
			this.textBox2.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(12, 65);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "Hello World!";
			this.textBox3.Enter += new System.EventHandler(this.TextBox_Enter);
			this.textBox3.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(12, 91);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "Hello World!";
			this.textBox4.Enter += new System.EventHandler(this.TextBox_Enter);
			this.textBox4.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(13, 117);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "Hello World!";
			this.textBox5.Enter += new System.EventHandler(this.TextBox_Enter);
			this.textBox5.Leave += new System.EventHandler(this.TextBox_Leave);
			// 
			// redHScrollBar
			// 
			this.redHScrollBar.Location = new System.Drawing.Point(9, 155);
			this.redHScrollBar.Maximum = 255;
			this.redHScrollBar.Name = "redHScrollBar";
			this.redHScrollBar.Size = new System.Drawing.Size(494, 17);
			this.redHScrollBar.TabIndex = 5;
			this.redHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
			// 
			// blueHScrollBar
			// 
			this.blueHScrollBar.Location = new System.Drawing.Point(8, 176);
			this.blueHScrollBar.Maximum = 255;
			this.blueHScrollBar.Name = "blueHScrollBar";
			this.blueHScrollBar.Size = new System.Drawing.Size(495, 17);
			this.blueHScrollBar.TabIndex = 6;
			this.blueHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
			// 
			// greenHScrollBar
			// 
			this.greenHScrollBar.Location = new System.Drawing.Point(8, 197);
			this.greenHScrollBar.Maximum = 255;
			this.greenHScrollBar.Name = "greenHScrollBar";
			this.greenHScrollBar.Size = new System.Drawing.Size(495, 17);
			this.greenHScrollBar.TabIndex = 7;
			this.greenHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScrollBar_Scroll);
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(149, 13);
			this.firstNameTextBox.MaxLength = 333333;
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(139, 20);
			this.firstNameTextBox.TabIndex = 8;
			this.firstNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.firstNameTextBox_Validating);
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(149, 39);
			this.lastNameTextBox.MaxLength = 30;
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(139, 20);
			this.lastNameTextBox.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(149, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(367, 12);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(100, 20);
			this.textBox6.TabIndex = 11;
			this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(367, 39);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(100, 20);
			this.textBox7.TabIndex = 12;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(367, 65);
			this.textBox8.Name = "textBox8";
			this.textBox8.Size = new System.Drawing.Size(100, 20);
			this.textBox8.TabIndex = 13;
			this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(367, 91);
			this.textBox9.Name = "textBox9";
			this.textBox9.Size = new System.Drawing.Size(100, 20);
			this.textBox9.TabIndex = 14;
			this.textBox9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.textBox15);
			this.panel1.Controls.Add(this.textBox14);
			this.panel1.Controls.Add(this.textBox13);
			this.panel1.Controls.Add(this.textBox12);
			this.panel1.Controls.Add(this.textBox11);
			this.panel1.Controls.Add(this.textBox10);
			this.panel1.Location = new System.Drawing.Point(24, 253);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(191, 108);
			this.panel1.TabIndex = 15;
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(16, 69);
			this.textBox12.Name = "textBox12";
			this.textBox12.Size = new System.Drawing.Size(100, 20);
			this.textBox12.TabIndex = 2;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(16, 42);
			this.textBox11.Name = "textBox11";
			this.textBox11.Size = new System.Drawing.Size(100, 20);
			this.textBox11.TabIndex = 1;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(16, 15);
			this.textBox10.Name = "textBox10";
			this.textBox10.Size = new System.Drawing.Size(100, 20);
			this.textBox10.TabIndex = 0;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(16, 96);
			this.textBox13.Name = "textBox13";
			this.textBox13.Size = new System.Drawing.Size(100, 20);
			this.textBox13.TabIndex = 3;
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(125, 96);
			this.textBox14.Name = "textBox14";
			this.textBox14.Size = new System.Drawing.Size(100, 20);
			this.textBox14.TabIndex = 4;
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(125, 69);
			this.textBox15.Name = "textBox15";
			this.textBox15.Size = new System.Drawing.Size(100, 20);
			this.textBox15.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(251, 253);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 100);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "وضعیت تاهل";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(47, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "مجرد";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(7, 43);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(85, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "radioButton2";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(7, 68);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(85, 17);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "radioButton3";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Highlight;
			this.ClientSize = new System.Drawing.Size(558, 453);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.greenHScrollBar);
			this.Controls.Add(this.blueHScrollBar);
			this.Controls.Add(this.redHScrollBar);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.HScrollBar redHScrollBar;
		private System.Windows.Forms.HScrollBar blueHScrollBar;
		private System.Windows.Forms.HScrollBar greenHScrollBar;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}

