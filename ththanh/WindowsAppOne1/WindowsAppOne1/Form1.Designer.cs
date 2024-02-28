using System;

namespace WindowAppOne1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtNumN = new System.Windows.Forms.TextBox();
			this.btnPlus = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNumM = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.btnSub = new System.Windows.Forms.Button();
			this.btnMul = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(90, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(300, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
			// 
			// txtNumN
			// 
			this.txtNumN.Location = new System.Drawing.Point(191, 70);
			this.txtNumN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNumN.Name = "txtNumN";
			this.txtNumN.Size = new System.Drawing.Size(178, 26);
			this.txtNumN.TabIndex = 1;
			// 
			// btnPlus
			// 
			this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlus.Location = new System.Drawing.Point(66, 192);
			this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(68, 38);
			this.btnPlus.TabIndex = 2;
			this.btnPlus.Text = "+";
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Nhập số n :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(96, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nhập số m :";
			// 
			// txtNumM
			// 
			this.txtNumM.Location = new System.Drawing.Point(191, 110);
			this.txtNumM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNumM.Name = "txtNumM";
			this.txtNumM.Size = new System.Drawing.Size(178, 26);
			this.txtNumM.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(96, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Kết quả :";
			// 
			// txtResult
			// 
			this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.txtResult.ForeColor = System.Drawing.Color.Red;
			this.txtResult.Location = new System.Drawing.Point(191, 149);
			this.txtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(178, 26);
			this.txtResult.TabIndex = 6;
			// 
			// btnSub
			// 
			this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSub.Location = new System.Drawing.Point(134, 192);
			this.btnSub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSub.Name = "btnSub";
			this.btnSub.Size = new System.Drawing.Size(68, 38);
			this.btnSub.TabIndex = 8;
			this.btnSub.Text = "-";
			this.btnSub.UseVisualStyleBackColor = true;
			this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
			// 
			// btnMul
			// 
			this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMul.Location = new System.Drawing.Point(201, 192);
			this.btnMul.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnMul.Name = "btnMul";
			this.btnMul.Size = new System.Drawing.Size(68, 38);
			this.btnMul.TabIndex = 9;
			this.btnMul.Text = "*";
			this.btnMul.UseVisualStyleBackColor = true;
			this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
			// 
			// btnDiv
			// 
			this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.Location = new System.Drawing.Point(269, 192);
			this.btnDiv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(68, 38);
			this.btnDiv.TabIndex = 10;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = true;
			this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
			// 
			// btnDel
			// 
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.Location = new System.Drawing.Point(336, 192);
			this.btnDel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(68, 38);
			this.btnDel.TabIndex = 11;
			this.btnDel.Text = "Xóa";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(74, 240);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(307, 38);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 299);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnMul);
			this.Controls.Add(this.btnSub);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNumM);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.txtNumN);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "TÍNH TOÁN";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNumN;
		private System.Windows.Forms.Button btnPlus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNumM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btnSub;
		private System.Windows.Forms.Button btnMul;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnExit;
	}
}

