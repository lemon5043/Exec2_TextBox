using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_TextBox_Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			result.Text = String.Empty;
		}

		private void btnResult_Click(object sender, EventArgs e)
		{
			try
			{
				int sumCar = CalculateValue(txtCar.Text, 200, "車輛");
				int sumPeople = CalculateValue(txtPeople.Text, 60, "人");

				int finalPrice = Math.Min(sumCar, sumPeople);

				result.Text = $"總價格{finalPrice}元";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int CalculateValue(string amount, int price, string type)
		{
			bool isInt = int.TryParse(amount, out int value);

			if (!isInt || value < 0)
			{
				throw new Exception($"請輸入正確的{type}數");
			}

			return value * price;
		}
	}
}
