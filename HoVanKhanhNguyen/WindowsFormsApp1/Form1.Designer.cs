namespace WindowsFormsApp1
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
            this.txtsob = new System.Windows.Forms.TextBox();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBSCNN = new System.Windows.Forms.RadioButton();
            this.chkUSCLN = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXóa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsob);
            this.groupBox1.Controls.Add(this.txtsoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập";
            // 
            // txtsob
            // 
            this.txtsob.Location = new System.Drawing.Point(103, 80);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(220, 27);
            this.txtsob.TabIndex = 3;
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(103, 38);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(220, 27);
            this.txtsoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.chkBSCNN);
            this.groupBox2.Controls.Add(this.chkUSCLN);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(392, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn";
            // 
            // chkBSCNN
            // 
            this.chkBSCNN.AutoSize = true;
            this.chkBSCNN.Location = new System.Drawing.Point(65, 86);
            this.chkBSCNN.Name = "chkBSCNN";
            this.chkBSCNN.Size = new System.Drawing.Size(94, 24);
            this.chkBSCNN.TabIndex = 1;
            this.chkBSCNN.TabStop = true;
            this.chkBSCNN.Text = "BSCNN\r\n";
            this.chkBSCNN.UseVisualStyleBackColor = true;
            this.chkBSCNN.CheckedChanged += new System.EventHandler(this.chkBSCNN_CheckedChanged);
            // 
            // chkUSCLN
            // 
            this.chkUSCLN.AutoSize = true;
            this.chkUSCLN.Location = new System.Drawing.Point(65, 41);
            this.chkUSCLN.Name = "chkUSCLN";
            this.chkUSCLN.Size = new System.Drawing.Size(92, 24);
            this.chkUSCLN.TabIndex = 0;
            this.chkUSCLN.TabStop = true;
            this.chkUSCLN.Text = "USCLN";
            this.chkUSCLN.UseVisualStyleBackColor = true;
            this.chkUSCLN.CheckedChanged += new System.EventHandler(this.chkUSLN_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThoat);
            this.groupBox3.Controls.Add(this.btnXóa);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.txtkq);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết Quả";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(401, 38);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 64);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXóa
            // 
            this.btnXóa.Location = new System.Drawing.Point(207, 77);
            this.btnXóa.Name = "btnXóa";
            this.btnXóa.Size = new System.Drawing.Size(140, 38);
            this.btnXóa.TabIndex = 2;
            this.btnXóa.Text = "Xóa";
            this.btnXóa.UseVisualStyleBackColor = true;
            this.btnXóa.Click += new System.EventHandler(this.btnXóa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(15, 77);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(156, 38);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtkq
            // 
            this.txtkq.BackColor = System.Drawing.SystemColors.Info;
            this.txtkq.Location = new System.Drawing.Point(27, 26);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(320, 27);
            this.txtkq.TabIndex = 0;
            this.txtkq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 282);
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
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton chkBSCNN;
        private System.Windows.Forms.RadioButton chkUSCLN;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXóa;
        private System.Windows.Forms.Button btnTim;
    }
}

