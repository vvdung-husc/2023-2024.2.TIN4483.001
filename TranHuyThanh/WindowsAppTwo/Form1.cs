using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowAppTwo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void chkUSCLN_CheckedChanged(object sender, EventArgs e)
		{
			btnFind.Text = "Tìm - USCLN";
		}

		private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
		{
			btnFind.Text = "Tìm - BSCNN";
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			txtNumA.Text = "";
			txtNumB.Text = "";
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			int numA, numB;

			if (int.TryParse(txtNumA.Text, out numA) && int.TryParse(txtNumB.Text, out numB))
			{
				if (chkUSCLN.Checked)
				{
					int usclnResult = USCLN(numA, numB);
					MessageBox.Show($"USCLN của {numA} và {numB} là {usclnResult}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtResult.Text = usclnResult.ToString();
				}
				else if (chkBSCNN.Checked)
				{
					int bscnnResult = BSCNN(numA, numB);
					MessageBox.Show($"BSCNN của {numA} và {numB} là {bscnnResult}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
					txtResult.Text = bscnnResult.ToString();
				}
				else
				{
					MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			else
			{
				MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho cả hai số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private int USCLN(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}

		private int BSCNN(int a, int b)
		{
			return a * b / USCLN(a, b);
		}

		private void txtResult_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
