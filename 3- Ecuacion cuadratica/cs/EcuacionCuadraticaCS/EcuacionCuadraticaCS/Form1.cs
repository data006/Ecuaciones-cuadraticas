using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcuacionCuadraticaCS
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}



		Double A, B, C;
		Double x1, x2;

		private void txtB_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((this.txtB.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == ".") & !(Convert.ToString(e.KeyChar) == "-");
			}
			else if (!this.txtB.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == ".");
			}
			else if (!this.txtB.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == "-");
			}
			else if (this.txtB.Text.Contains(".") & this.txtB.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}
		}

		private void txtC_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((this.txtC.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == ".") & !(Convert.ToString(e.KeyChar) == "-");
			}
			else if (!this.txtC.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == ".");
			}
			else if (!this.txtC.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == "-");
			}
			else if (this.txtC.Text.Contains(".") & this.txtC.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}
		}

		private void txtA_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((this.txtA.Text ?? "") == (string.Empty ?? ""))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == ".") & !(Convert.ToString(e.KeyChar) == "-");
			}
			else if (!this.txtA.Text.Contains("."))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == ".");
			}
			else if (!this.txtA.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar) & !(Convert.ToString(e.KeyChar) == "-");
			}
			else if (this.txtA.Text.Contains(".") & this.txtA.Text.Contains("-"))
			{
				e.Handled = !char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar);
			}
		}

		Double dis;



		private void btnSolve_Click(object sender, EventArgs e)
		{
			if (txtA.Text == String.Empty || txtB.Text == String.Empty || txtC.Text == String.Empty)
			{

			}
			else
			{
				A = Convert.ToDouble(txtA.Text);
				B = Convert.ToDouble(txtB.Text);
				C = Convert.ToDouble(txtC.Text);
			}
			

			dis = (B * B) - (4 * A * C);

			if (dis < 0)
			{

				dis = dis * -1;
				dis = Math.Sqrt(dis);
				dis = dis / (2 * A);

				x1 = -B / (2 * A);

				MessageBox.Show("X1 = " + x1 + " + " + dis + "i \r \n" + "X2 = " + x1 + " - " + dis + "i");


			}
			else if (dis == 0)
			{

				x1 = -B / (2 * A);
				x2 = -B / (2 * A);

				MessageBox.Show("X1 = " + x1 + "\r \n" + "X2 = " + x2);

			}
			else
			{
				x1 = -B / (2 * A) + Math.Sqrt(dis) / (2 * A);
				x2 = -B / (2 * A) - Math.Sqrt(dis) / (2 * A);

				MessageBox.Show("X1 = " + x1 + "\r \n" + "X2 = " + x2);
			}

		}
	}
}
