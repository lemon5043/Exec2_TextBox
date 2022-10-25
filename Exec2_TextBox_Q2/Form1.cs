using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (dateTimePicker1.Value > DateTime.Now)
			{
				MessageBox.Show("該日期在未來");
			}
			else
			{
				MessageBox.Show("該日期在過去或今天");
			}
		}
	}
}
