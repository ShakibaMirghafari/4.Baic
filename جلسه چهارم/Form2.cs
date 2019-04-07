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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void titleTime_Tick(object sender, EventArgs e)
		{
			//if (titleLable.Text == "Welcom To My Class")
			//{
			//	titleLable.Text = "I am Shakiba Mirghafari";
			//	titleLable.BackColor = System.Drawing.Color.Blue;
			//}
			//else
			//{
			//	titleLable.Text = "Welcom To My Class";
			//	titleLable.BackColor = System.Drawing.Color.Green;
			//}

			if (string.Compare ( titleLable.Text , "welcom to my class", ignoreCase : true ) ==0 )
			{
				titleLable.Text = "I am Shakiba Mirghafari";
				titleLable.BackColor = System.Drawing.Color.Blue;
			}
			else
			{
				titleLable.Text = "Welcom To My Class";
				titleLable.BackColor = System.Drawing.Color.Green;
			}
		}
	}
}
