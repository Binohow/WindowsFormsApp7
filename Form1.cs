using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//判断所有选中项集合大于0
			if (this.listBox1.SelectedItems.Count > 0&&this.listBox2.SelectedItems.Count > 0)
			{
				//获取选中的值
				int result;
				left = this.listBox1.SelectedItem.ToString();
				right = this.listBox2.SelectedItem.ToString();
				result = int.Parse(left) * int.Parse(right);

				string temp = left + "×" + right + "=" + result;

				if (!this.listBox1.Items.Contains(temp))
				{
					this.listBox3.Items.Add(temp);
				}
			}

		}

		private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			//判断所有选中项集合大于0
			if (this.listBox1.SelectedItems.Count > 0 && this.listBox2.SelectedItems.Count > 0)
			{
				//获取选中的值
				int result;
				left = this.listBox1.SelectedItem.ToString();
				right = this.listBox2.SelectedItem.ToString();
				result=int.Parse(left)*int.Parse(right);

				string temp = left + "×" + right + "=" + result;

				if (!this.listBox1.Items.Contains(temp))
				{
					this.listBox3.Items.Add(temp);
				}

			}
		}


	}
}
