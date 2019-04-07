namespace جلسه_چهارم
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			this.titleLable = new System.Windows.Forms.Label();
			this.titleTime = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// titleLable
			// 
			this.titleLable.BackColor = System.Drawing.Color.RosyBrown;
			this.titleLable.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLable.ForeColor = System.Drawing.Color.Black;
			this.titleLable.Location = new System.Drawing.Point(12, 9);
			this.titleLable.Name = "titleLable";
			this.titleLable.Size = new System.Drawing.Size(451, 300);
			this.titleLable.TabIndex = 0;
			this.titleLable.Text = "Welcom To My Class";
			this.titleLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// titleTime
			// 
			this.titleTime.Enabled = true;
			this.titleTime.Interval = 1000;
			this.titleTime.Tick += new System.EventHandler(this.titleTime_Tick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(475, 318);
			this.Controls.Add(this.titleLable);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label titleLable;
		private System.Windows.Forms.Timer titleTime;
	}
}