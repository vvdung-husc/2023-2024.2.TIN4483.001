namespace WindowsAppOne
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
            this.txtNumN = new System.Windows.Forms.TextBox();
            this.txtNumM = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumN
            // 
            this.txtNumN.Location = new System.Drawing.Point(212, 76);
            this.txtNumN.Name = "txtNumN";
            this.txtNumN.Size = new System.Drawing.Size(168, 22);
            this.txtNumN.TabIndex = 0;
            // 
            // txtNumM
            // 
            this.txtNumM.Location = new System.Drawing.Point(219, 141);
            this.txtNumM.Name = "txtNumM";
            this.txtNumM.Size = new System.Drawing.Size(161, 22);
            this.txtNumM.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(218, 212);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(162, 22);
            this.txtResult.TabIndex = 2;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(115, 267);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(218, 267);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(77, 23);
            this.btnSub.TabIndex = 4;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(317, 268);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(62, 21);
            this.btnMul.TabIndex = 5;
            this.btnMul.Text = "*";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(399, 270);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(56, 19);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(482, 274);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(66, 25);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(153, 314);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(311, 42);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nhập số n:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nhập  số m:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNumM);
            this.Controls.Add(this.txtNumN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumN;
        private System.Windows.Forms.TextBox txtNumM;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

