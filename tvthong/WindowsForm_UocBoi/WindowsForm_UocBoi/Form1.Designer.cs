namespace WindowsForm_UocBoi
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
            this.chkUSCLN = new System.Windows.Forms.CheckBox();
            this.chkBSCNN = new System.Windows.Forms.CheckBox();
            this.bttim = new System.Windows.Forms.Button();
            this.btboqua = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.groupTim = new System.Windows.Forms.GroupBox();
            this.groupKetqua = new System.Windows.Forms.GroupBox();
            this.groupNhap = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.groupTim.SuspendLayout();
            this.groupKetqua.SuspendLayout();
            this.groupNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkUSCLN
            // 
            this.chkUSCLN.AutoSize = true;
            this.chkUSCLN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chkUSCLN.Location = new System.Drawing.Point(20, 30);
            this.chkUSCLN.Name = "chkUSCLN";
            this.chkUSCLN.Size = new System.Drawing.Size(81, 23);
            this.chkUSCLN.TabIndex = 4;
            this.chkUSCLN.Text = "USCLN";
            this.chkUSCLN.UseVisualStyleBackColor = false;
            this.chkUSCLN.CheckedChanged += new System.EventHandler(this.chkUSCLN_CheckedChanged);
            // 
            // chkBSCNN
            // 
            this.chkBSCNN.AutoSize = true;
            this.chkBSCNN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chkBSCNN.Location = new System.Drawing.Point(20, 72);
            this.chkBSCNN.Name = "chkBSCNN";
            this.chkBSCNN.Size = new System.Drawing.Size(83, 23);
            this.chkBSCNN.TabIndex = 5;
            this.chkBSCNN.Text = "BSCNN";
            this.chkBSCNN.UseVisualStyleBackColor = false;
            this.chkBSCNN.CheckedChanged += new System.EventHandler(this.chkBSCNN_CheckedChanged);
            // 
            // bttim
            // 
            this.bttim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttim.Location = new System.Drawing.Point(5, 71);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(129, 35);
            this.bttim.TabIndex = 8;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = false;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // btboqua
            // 
            this.btboqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btboqua.Location = new System.Drawing.Point(140, 71);
            this.btboqua.Name = "btboqua";
            this.btboqua.Size = new System.Drawing.Size(136, 35);
            this.btboqua.TabIndex = 9;
            this.btboqua.Text = "Xóa";
            this.btboqua.UseVisualStyleBackColor = false;
            this.btboqua.Click += new System.EventHandler(this.btboqua_Click);
            // 
            // btthoat
            // 
            this.btthoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btthoat.Location = new System.Drawing.Point(282, 71);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(137, 35);
            this.btthoat.TabIndex = 10;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = false;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // txtkq
            // 
            this.txtkq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtkq.Location = new System.Drawing.Point(6, 29);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(274, 26);
            this.txtkq.TabIndex = 7;
            this.txtkq.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // groupTim
            // 
            this.groupTim.Controls.Add(this.chkBSCNN);
            this.groupTim.Controls.Add(this.chkUSCLN);
            this.groupTim.Location = new System.Drawing.Point(318, 41);
            this.groupTim.Name = "groupTim";
            this.groupTim.Size = new System.Drawing.Size(155, 133);
            this.groupTim.TabIndex = 12;
            this.groupTim.TabStop = false;
            this.groupTim.Text = "Chọn Tìm";
            this.groupTim.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupKetqua
            // 
            this.groupKetqua.Controls.Add(this.txtkq);
            this.groupKetqua.Controls.Add(this.btthoat);
            this.groupKetqua.Controls.Add(this.btboqua);
            this.groupKetqua.Controls.Add(this.bttim);
            this.groupKetqua.Location = new System.Drawing.Point(17, 180);
            this.groupKetqua.Name = "groupKetqua";
            this.groupKetqua.Size = new System.Drawing.Size(456, 130);
            this.groupKetqua.TabIndex = 13;
            this.groupKetqua.TabStop = false;
            this.groupKetqua.Text = "Kết quả";
            this.groupKetqua.Enter += new System.EventHandler(this.groupKetqua_Enter);
            // 
            // groupNhap
            // 
            this.groupNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupNhap.Controls.Add(this.label2);
            this.groupNhap.Controls.Add(this.label1);
            this.groupNhap.Controls.Add(this.txtb);
            this.groupNhap.Controls.Add(this.txta);
            this.groupNhap.Location = new System.Drawing.Point(17, 28);
            this.groupNhap.Name = "groupNhap";
            this.groupNhap.Size = new System.Drawing.Size(279, 146);
            this.groupNhap.TabIndex = 14;
            this.groupNhap.TabStop = false;
            this.groupNhap.Text = "Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập A";
            // 
            // txtb
            // 
            this.txtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtb.Location = new System.Drawing.Point(87, 96);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(166, 26);
            this.txtb.TabIndex = 1;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            // 
            // txta
            // 
            this.txta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txta.Location = new System.Drawing.Point(87, 48);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(166, 26);
            this.txta.TabIndex = 0;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(502, 348);
            this.Controls.Add(this.groupNhap);
            this.Controls.Add(this.groupKetqua);
            this.Controls.Add(this.groupTim);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của A và B";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupTim.ResumeLayout(false);
            this.groupTim.PerformLayout();
            this.groupKetqua.ResumeLayout(false);
            this.groupKetqua.PerformLayout();
            this.groupNhap.ResumeLayout(false);
            this.groupNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chkUSCLN;
        private System.Windows.Forms.CheckBox chkBSCNN;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Button btboqua;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.GroupBox groupTim;
        private System.Windows.Forms.GroupBox groupKetqua;
        private System.Windows.Forms.GroupBox groupNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
    }
}

