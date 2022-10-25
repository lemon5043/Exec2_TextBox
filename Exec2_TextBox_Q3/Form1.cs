using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			result.Text = string.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				result.Text = CheckAge(textBox1.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		string CheckAge(string n)
		{
			bool isInt = int.TryParse(n, out int value);

			if (!isInt || value < 0 || value > 150)
			{
				throw new Exception("請輸入正確的年齡");
			}

			if (value < 13)
			{
				return "您未滿13歲";
			}
			else
			{
				return "您已滿13歲";
			}
		}
	}
}
