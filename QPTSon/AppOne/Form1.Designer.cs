namespace AppOne
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBCNN = new System.Windows.Forms.CheckBox();
            this.txtUCLN = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtExit = new System.Windows.Forms.Button();
            this.txtNext = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhapB);
            this.groupBox1.Controls.Add(this.txtNhapA);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(54, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 174);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(49, 107);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(305, 34);
            this.txtNhapB.TabIndex = 3;
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(48, 41);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(306, 34);
            this.txtNhapA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBCNN);
            this.groupBox2.Controls.Add(this.txtUCLN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(500, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 174);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm";
            // 
            // txtBCNN
            // 
            this.txtBCNN.AutoSize = true;
            this.txtBCNN.Location = new System.Drawing.Point(44, 109);
            this.txtBCNN.Name = "txtBCNN";
            this.txtBCNN.Size = new System.Drawing.Size(104, 33);
            this.txtBCNN.TabIndex = 1;
            this.txtBCNN.Text = "BCNN";
            this.txtBCNN.UseVisualStyleBackColor = true;
            this.txtBCNN.CheckedChanged += new System.EventHandler(this.txtBCNN_CheckedChanged_1);
            // 
            // txtUCLN
            // 
            this.txtUCLN.AutoSize = true;
            this.txtUCLN.Location = new System.Drawing.Point(44, 49);
            this.txtUCLN.Name = "txtUCLN";
            this.txtUCLN.Size = new System.Drawing.Size(100, 33);
            this.txtUCLN.TabIndex = 0;
            this.txtUCLN.Text = "UCLN";
            this.txtUCLN.UseVisualStyleBackColor = true;
            this.txtUCLN.CheckedChanged += new System.EventHandler(this.txtUCLN_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.txtExit);
            this.groupBox3.Controls.Add(this.txtNext);
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(54, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(734, 183);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(48, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 34);
            this.textBox3.TabIndex = 4;
            // 
            // txtExit
            // 
            this.txtExit.Location = new System.Drawing.Point(446, 128);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(281, 47);
            this.txtExit.TabIndex = 3;
            this.txtExit.Text = "Thoát";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click_1);
            // 
            // txtNext
            // 
            this.txtNext.Location = new System.Drawing.Point(445, 76);
            this.txtNext.Name = "txtNext";
            this.txtNext.Size = new System.Drawing.Size(282, 46);
            this.txtNext.TabIndex = 2;
            this.txtNext.Text = "Bỏ qua";
            this.txtNext.UseVisualStyleBackColor = true;
            this.txtNext.Click += new System.EventHandler(this.txtNext_Click_1);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(446, 22);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(282, 48);
            this.txtTim.TabIndex = 1;
            this.txtTim.Text = "Tìm";
            this.txtTim.UseVisualStyleBackColor = true;
            this.txtTim.Click += new System.EventHandler(this.txtTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox txtUCLN;
        private System.Windows.Forms.CheckBox txtBCNN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtExit;
        private System.Windows.Forms.Button txtNext;
        private System.Windows.Forms.Button txtTim;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.TextBox textBox3;
    }
}

