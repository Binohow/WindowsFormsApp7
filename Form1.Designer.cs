namespace WindowsFormsApp7
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Items.AddRange(new object[] {
            "12",
            "10",
            "5",
            "8",
            "22",
            "25",
            "9"});
			this.listBox1.Location = new System.Drawing.Point(83, 44);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(78, 154);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 15;
			this.listBox2.Items.AddRange(new object[] {
            "9",
            "15",
            "20",
            "32",
            "18",
            "5",
            "7",
            "32"});
			this.listBox2.Location = new System.Drawing.Point(252, 44);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(78, 154);
			this.listBox2.TabIndex = 1;
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.ListBox2_SelectedIndexChanged);
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 15;
			this.listBox3.Location = new System.Drawing.Point(426, 44);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(106, 154);
			this.listBox3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(182, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "×";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(372, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "=";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 243);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;

		string left;
		string right;
	}
}

