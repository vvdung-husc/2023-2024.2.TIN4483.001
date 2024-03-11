namespace WindowsFormsApptwo
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
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupbox3 = new System.Windows.Forms.GroupBox();
            this.chkUSCLN = new System.Windows.Forms.RadioButton();
            this.chkBSCNN = new System.Windows.Forms.RadioButton();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupbox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumB);
            this.groupBox1.Controls.Add(this.txtNumA);
            this.groupBox1.Location = new System.Drawing.Point(53, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNumA
            // 
            this.txtNumA.Location = new System.Drawing.Point(72, 36);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(100, 22);
            this.txtNumA.TabIndex = 0;
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(72, 84);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(100, 22);
            this.txtNumB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "B:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBSCNN);
            this.groupBox2.Controls.Add(this.chkUSCLN);
            this.groupBox2.Location = new System.Drawing.Point(392, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupbox3
            // 
            this.groupbox3.Controls.Add(this.btnthoat);
            this.groupbox3.Controls.Add(this.btnxoa);
            this.groupbox3.Controls.Add(this.btntim);
            this.groupbox3.Controls.Add(this.txtketqua);
            this.groupbox3.Location = new System.Drawing.Point(97, 229);
            this.groupbox3.Name = "groupbox3";
            this.groupbox3.Size = new System.Drawing.Size(331, 150);
            this.groupbox3.TabIndex = 3;
            this.groupbox3.TabStop = false;
            this.groupbox3.Text = "Kết quả:";
            this.groupbox3.Enter += new System.EventHandler(this.groupbox3_Enter);
            // 
            // chkUSCLN
            // 
            this.chkUSCLN.AutoSize = true;
            this.chkUSCLN.Location = new System.Drawing.Point(23, 37);
            this.chkUSCLN.Name = "chkUSCLN";
            this.chkUSCLN.Size = new System.Drawing.Size(73, 20);
            this.chkUSCLN.TabIndex = 0;
            this.chkUSCLN.TabStop = true;
            this.chkUSCLN.Text = "USCLN";
            this.chkUSCLN.UseVisualStyleBackColor = true;
            this.chkUSCLN.CheckedChanged += new System.EventHandler(this.chkUSCLN_CheckedChanged);
            // 
            // chkBSCNN
            // 
            this.chkBSCNN.AutoSize = true;
            this.chkBSCNN.Location = new System.Drawing.Point(23, 85);
            this.chkBSCNN.Name = "chkBSCNN";
            this.chkBSCNN.Size = new System.Drawing.Size(75, 20);
            this.chkBSCNN.TabIndex = 1;
            this.chkBSCNN.TabStop = true;
            this.chkBSCNN.Text = "BSCNN";
            this.chkBSCNN.UseVisualStyleBackColor = true;
            this.chkBSCNN.CheckedChanged += new System.EventHandler(this.chkBSCNN_CheckedChanged);
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(63, 43);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(234, 22);
            this.txtketqua.TabIndex = 0;
            this.txtketqua.TextChanged += new System.EventHandler(this.txtketqua_TextChanged);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(28, 97);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 1;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(124, 97);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(222, 97);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupbox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của A và B";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupbox3.ResumeLayout(false);
            this.groupbox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton chkBSCNN;
        private System.Windows.Forms.RadioButton chkUSCLN;
        private System.Windows.Forms.GroupBox groupbox3;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtketqua;
    }
}

