namespace WindowsApp1
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
            this.btnCong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCong.Location = new System.Drawing.Point(76, 256);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(49, 23);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = false;
            this.btnCong.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số m:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập số n:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(156, 147);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(162, 20);
            this.txtSom.TabIndex = 5;
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(156, 101);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(162, 20);
            this.txtSon.TabIndex = 6;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(156, 206);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(162, 20);
            this.txtKQ.TabIndex = 7;
            // 
            // btnTru
            // 
            this.btnTru.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTru.Location = new System.Drawing.Point(131, 256);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(49, 23);
            this.btnTru.TabIndex = 12;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = false;
            // 
            // btnNhan
            // 
            this.btnNhan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhan.Location = new System.Drawing.Point(186, 256);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(49, 23);
            this.btnNhan.TabIndex = 13;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = false;
            // 
            // btnChia
            // 
            this.btnChia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChia.Location = new System.Drawing.Point(241, 256);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(49, 23);
            this.btnChia.TabIndex = 14;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.Location = new System.Drawing.Point(296, 256);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(49, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.Location = new System.Drawing.Point(351, 256);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(49, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 332);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCong);
            this.Name = "Form1";
            this.Text = "TÍNH TOÁN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

