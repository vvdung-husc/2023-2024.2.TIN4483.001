namespace WindowAppOne
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN PHÉP TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "nhập số n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "nhập số m";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "kết quả";
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(257, 80);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(281, 22);
            this.txtSon.TabIndex = 4;
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(255, 138);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(282, 22);
            this.txtSom.TabIndex = 5;
            // 
            // txtKetqua
            // 
            this.txtKetqua.BackColor = System.Drawing.SystemColors.Info;
            this.txtKetqua.Location = new System.Drawing.Point(254, 199);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(282, 22);
            this.txtKetqua.TabIndex = 6;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(222, 258);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(61, 36);
            this.btCong.TabIndex = 7;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(542, 258);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(68, 36);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btChia
            // 
            this.btChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChia.Location = new System.Drawing.Point(466, 258);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(59, 36);
            this.btChia.TabIndex = 9;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btNhan
            // 
            this.btNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhan.Location = new System.Drawing.Point(383, 258);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(60, 36);
            this.btNhan.TabIndex = 10;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.Location = new System.Drawing.Point(302, 258);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(61, 36);
            this.btTru.TabIndex = 11;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThoat.Location = new System.Drawing.Point(231, 322);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(323, 36);
            this.btThoat.TabIndex = 12;
            this.btThoat.Text = "thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 426);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btThoat;
    }
}

