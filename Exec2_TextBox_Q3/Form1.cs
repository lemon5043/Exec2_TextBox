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
				result.Text = CheckAge(dateTimePicker1.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		string CheckAge(DateTime n)
		{
			// 判斷年齡是否超過今天
			if (n > DateTime.Now)
			{
				throw new Exception("生日不可超過現在");
			}

			int age = DateTime.Now.Year - n.Year;
			if (DateTime.Now < n.AddYears(age)) { age--; }

			if (age >= 13)
			{
				return "您已滿13歲";
			}
			else
			{
				return "您未滿13歲";
			}
		}
	}
}
