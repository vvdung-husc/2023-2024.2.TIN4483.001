namespace WindowsAppTwo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkUscln = new System.Windows.Forms.RadioButton();
            this.checkBscnn = new System.Windows.Forms.RadioButton();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "A :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "B :";
            // 
            // checkUscln
            // 
            this.checkUscln.AutoSize = true;
            this.checkUscln.Location = new System.Drawing.Point(32, 43);
            this.checkUscln.Name = "checkUscln";
            this.checkUscln.Size = new System.Drawing.Size(73, 20);
            this.checkUscln.TabIndex = 12;
            this.checkUscln.TabStop = true;
            this.checkUscln.Text = "USCLN";
            this.checkUscln.UseVisualStyleBackColor = true;
            this.checkUscln.CheckedChanged += new System.EventHandler(this.checkUscln_CheckedChanged);
            // 
            // checkBscnn
            // 
            this.checkBscnn.AutoSize = true;
            this.checkBscnn.Location = new System.Drawing.Point(32, 107);
            this.checkBscnn.Name = "checkBscnn";
            this.checkBscnn.Size = new System.Drawing.Size(75, 20);
            this.checkBscnn.TabIndex = 13;
            this.checkBscnn.TabStop = true;
            this.checkBscnn.Text = "BSCNN";
            this.checkBscnn.UseVisualStyleBackColor = true;
            this.checkBscnn.CheckedChanged += new System.EventHandler(this.checkBscnn_CheckedChanged);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(75, 137);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(135, 36);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(282, 137);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(135, 36);
            this.btnBoqua.TabIndex = 15;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(487, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 36);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(103, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(338, 22);
            this.txtA.TabIndex = 17;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(103, 103);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(338, 22);
            this.txtB.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 188);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBscnn);
            this.groupBox2.Controls.Add(this.checkUscln);
            this.groupBox2.Location = new System.Drawing.Point(540, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 188);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn tìm ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKetqua);
            this.groupBox3.Controls.Add(this.btnTim);
            this.groupBox3.Controls.Add(this.btnBoqua);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Location = new System.Drawing.Point(12, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(777, 189);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả :";
            // 
            // txtKetqua
            // 
            this.txtKetqua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetqua.Location = new System.Drawing.Point(146, 51);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(387, 22);
            this.txtKetqua.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 445);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tìm USCLN và BSCNN của A và B";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton checkUscln;
        private System.Windows.Forms.RadioButton checkBscnn;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKetqua;
    }
}

