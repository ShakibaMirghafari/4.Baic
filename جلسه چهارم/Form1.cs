using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace جلسه_چهارم
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void TextBox_Enter(object sender, EventArgs e)
		{
			System.Windows.Forms.TextBox currentTextBox = sender as System.Windows.Forms.TextBox;
			if (currentTextBox != null)
			{
				currentTextBox.Font = new System.Drawing.Font(currentTextBox.Font, System.Drawing.FontStyle.Bold);
			}
		}

		private void TextBox_Leave(object sender, EventArgs e)
		{
			System.Windows.Forms.TextBox currentTextBox = sender as System.Windows.Forms.TextBox;
			if (currentTextBox != null)
			{
				currentTextBox.Font = new System.Drawing.Font(currentTextBox.Font, System.Drawing.FontStyle.Regular);
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//BackColor=System.Drawing.Color.FromArgb(200, 20, 19);

			redHScrollBar.Value = BackColor.R;
			greenHScrollBar.Value = BackColor.G;
			blueHScrollBar.Value = BackColor.B;
		}

		private void HScrollBar_Scroll(object sender, ScrollEventArgs e)
		{
			//BackColor = System.Drawing.Color.FromArgb
			//	(redHScrollBar.Value, greenHScrollBar.Value, blueHScrollBar.Value);

			BackColor = System.Drawing.Color.FromArgb
				(red: redHScrollBar.Value, green: greenHScrollBar.Value, blue: blueHScrollBar.Value);
		}

		private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
		{
			if (firstNameTextBox.TextLength>20)
			{
				System.Windows.Forms.MessageBox.Show
					("طول کارکتر بیش از حد کجاز است.");

				e.Cancel = true;
			}
		}

		private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					{
						break;
					}
				default:
					{
						e.Handled = true;
						break;
					}
					
			}

		}
	}
}
