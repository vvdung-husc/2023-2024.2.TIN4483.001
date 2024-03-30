namespace WindowsForms_UocBoi
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
            this.groupNhap = new System.Windows.Forms.GroupBox();
            this.groupTim = new System.Windows.Forms.GroupBox();
            this.groupKetqua = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.chkUSCLN = new System.Windows.Forms.CheckBox();
            this.chkBSCNN = new System.Windows.Forms.CheckBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.bttim = new System.Windows.Forms.Button();
            this.btboqua = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.groupNhap.SuspendLayout();
            this.groupTim.SuspendLayout();
            this.groupKetqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupNhap
            // 
            this.groupNhap.Controls.Add(this.txtb);
            this.groupNhap.Controls.Add(this.txta);
            this.groupNhap.Controls.Add(this.label2);
            this.groupNhap.Controls.Add(this.label1);
            this.groupNhap.Location = new System.Drawing.Point(12, 12);
            this.groupNhap.Name = "groupNhap";
            this.groupNhap.Size = new System.Drawing.Size(316, 187);
            this.groupNhap.TabIndex = 0;
            this.groupNhap.TabStop = false;
            this.groupNhap.Text = "Nhập";
            this.groupNhap.Enter += new System.EventHandler(this.groupNhap_Enter);
            // 
            // groupTim
            // 
            this.groupTim.Controls.Add(this.chkBSCNN);
            this.groupTim.Controls.Add(this.chkUSCLN);
            this.groupTim.Location = new System.Drawing.Point(375, 12);
            this.groupTim.Name = "groupTim";
            this.groupTim.Size = new System.Drawing.Size(312, 187);
            this.groupTim.TabIndex = 1;
            this.groupTim.TabStop = false;
            this.groupTim.Text = "Chọn tìm";
            // 
            // groupKetqua
            // 
            this.groupKetqua.Controls.Add(this.btthoat);
            this.groupKetqua.Controls.Add(this.btboqua);
            this.groupKetqua.Controls.Add(this.bttim);
            this.groupKetqua.Controls.Add(this.txtkq);
            this.groupKetqua.Location = new System.Drawing.Point(12, 246);
            this.groupKetqua.Name = "groupKetqua";
            this.groupKetqua.Size = new System.Drawing.Size(675, 178);
            this.groupKetqua.TabIndex = 2;
            this.groupKetqua.TabStop = false;
            this.groupKetqua.Text = "Kết quả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập B";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(108, 35);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 22);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(108, 97);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 22);
            this.txtb.TabIndex = 3;
            // 
            // chkUSCLN
            // 
            this.chkUSCLN.AutoSize = true;
            this.chkUSCLN.Location = new System.Drawing.Point(88, 41);
            this.chkUSCLN.Name = "chkUSCLN";
            this.chkUSCLN.Size = new System.Drawing.Size(74, 20);
            this.chkUSCLN.TabIndex = 0;
            this.chkUSCLN.Text = "USCLN";
            this.chkUSCLN.UseVisualStyleBackColor = true;
            this.chkUSCLN.CheckedChanged += new System.EventHandler(this.chkUSCLN_CheckedChanged);
            // 
            // chkBSCNN
            // 
            this.chkBSCNN.AutoSize = true;
            this.chkBSCNN.Location = new System.Drawing.Point(88, 100);
            this.chkBSCNN.Name = "chkBSCNN";
            this.chkBSCNN.Size = new System.Drawing.Size(73, 20);
            this.chkBSCNN.TabIndex = 1;
            this.chkBSCNN.Text = "BSCLN";
            this.chkBSCNN.UseVisualStyleBackColor = true;
            this.chkBSCNN.CheckedChanged += new System.EventHandler(this.chkBSCNN_CheckedChanged);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(27, 42);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(289, 22);
            this.txtkq.TabIndex = 0;
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(27, 111);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(104, 23);
            this.bttim.TabIndex = 1;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // btboqua
            // 
            this.btboqua.Location = new System.Drawing.Point(162, 111);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new System.Drawing.Size(105, 23);
            this.btboqua.TabIndex = 2;
            this.btboqua.Text = "Xoá";
            this.btboqua.UseVisualStyleBackColor = true;
            this.btboqua.Click += new System.EventHandler(this.btboqua_Click);
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(300, 111);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(110, 23);
            this.btthoat.TabIndex = 3;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupKetqua);
            this.Controls.Add(this.groupTim);
            this.Controls.Add(this.groupNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupNhap.ResumeLayout(false);
            this.groupNhap.PerformLayout();
            this.groupTim.ResumeLayout(false);
            this.groupTim.PerformLayout();
            this.groupKetqua.ResumeLayout(false);
            this.groupKetqua.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupNhap;
        private System.Windows.Forms.GroupBox groupTim;
        private System.Windows.Forms.GroupBox groupKetqua;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBSCNN;
        private System.Windows.Forms.CheckBox chkUSCLN;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.Button btboqua;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox txtkq;
    }
}

