using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			lblAnswer.Text = String.Empty;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				lblAnswer.Text = Is1To99(txtInput.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private string Is1To99(string input)
		{
			bool isDouble = double.TryParse(input, out double n);

			if (!isDouble)
			{
				throw new Exception("請輸入數字");
			}

			if (n >= 1 && n <= 99)
			{
				return $"{n}在1到99之間";
			}
			else
			{
				return $"{n}不在1到99之間";
			}
		}
	}
}
