namespace WindowsForms
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
            this.txtson = new System.Windows.Forms.TextBox();
            this.txtsom = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.txtcong = new System.Windows.Forms.Button();
            this.txttru = new System.Windows.Forms.Button();
            this.txtnhan = new System.Windows.Forms.Button();
            this.txtchia = new System.Windows.Forms.Button();
            this.txtxoa = new System.Windows.Forms.Button();
            this.txtthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(248, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(109, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số n:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(109, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập số m:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(109, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtson
            // 
            this.txtson.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtson.Location = new System.Drawing.Point(253, 125);
            this.txtson.Name = "txtson";
            this.txtson.Size = new System.Drawing.Size(318, 26);
            this.txtson.TabIndex = 4;
            this.txtson.Text = "55";
            // 
            // txtsom
            // 
            this.txtsom.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsom.Location = new System.Drawing.Point(253, 194);
            this.txtsom.Name = "txtsom";
            this.txtsom.Size = new System.Drawing.Size(318, 26);
            this.txtsom.TabIndex = 5;
            this.txtsom.Text = "5";
            // 
            // txtketqua
            // 
            this.txtketqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtketqua.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtketqua.Location = new System.Drawing.Point(253, 257);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(318, 26);
            this.txtketqua.TabIndex = 6;
            // 
            // txtcong
            // 
            this.txtcong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtcong.Location = new System.Drawing.Point(253, 321);
            this.txtcong.Name = "txtcong";
            this.txtcong.Size = new System.Drawing.Size(75, 38);
            this.txtcong.TabIndex = 7;
            this.txtcong.Text = "+";
            this.txtcong.UseVisualStyleBackColor = true;
            this.txtcong.Click += new System.EventHandler(this.txtcong_Click);
            // 
            // txttru
            // 
            this.txttru.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txttru.Location = new System.Drawing.Point(334, 321);
            this.txttru.Name = "txttru";
            this.txttru.Size = new System.Drawing.Size(75, 38);
            this.txttru.TabIndex = 8;
            this.txttru.Text = "-";
            this.txttru.UseVisualStyleBackColor = true;
            this.txttru.Click += new System.EventHandler(this.txttru_Click);
            // 
            // txtnhan
            // 
            this.txtnhan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtnhan.Location = new System.Drawing.Point(415, 321);
            this.txtnhan.Name = "txtnhan";
            this.txtnhan.Size = new System.Drawing.Size(75, 38);
            this.txtnhan.TabIndex = 9;
            this.txtnhan.Text = "*";
            this.txtnhan.UseVisualStyleBackColor = true;
            this.txtnhan.Click += new System.EventHandler(this.txtnhan_Click);
            // 
            // txtchia
            // 
            this.txtchia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtchia.Location = new System.Drawing.Point(496, 321);
            this.txtchia.Name = "txtchia";
            this.txtchia.Size = new System.Drawing.Size(75, 38);
            this.txtchia.TabIndex = 10;
            this.txtchia.Text = "/";
            this.txtchia.UseVisualStyleBackColor = true;
            this.txtchia.Click += new System.EventHandler(this.txtchia_Click);
            // 
            // txtxoa
            // 
            this.txtxoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtxoa.Location = new System.Drawing.Point(590, 321);
            this.txtxoa.Name = "txtxoa";
            this.txtxoa.Size = new System.Drawing.Size(75, 38);
            this.txtxoa.TabIndex = 11;
            this.txtxoa.Text = "Xóa";
            this.txtxoa.UseVisualStyleBackColor = true;
            this.txtxoa.Click += new System.EventHandler(this.txtxoa_Click);
            // 
            // txtthoat
            // 
            this.txtthoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtthoat.Location = new System.Drawing.Point(253, 400);
            this.txtthoat.Name = "txtthoat";
            this.txtthoat.Size = new System.Drawing.Size(318, 38);
            this.txtthoat.TabIndex = 12;
            this.txtthoat.Text = "Thoát";
            this.txtthoat.UseVisualStyleBackColor = true;
            this.txtthoat.Click += new System.EventHandler(this.txtthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 579);
            this.Controls.Add(this.txtthoat);
            this.Controls.Add(this.txtxoa);
            this.Controls.Add(this.txtchia);
            this.Controls.Add(this.txtnhan);
            this.Controls.Add(this.txttru);
            this.Controls.Add(this.txtcong);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsom);
            this.Controls.Add(this.txtson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtson;
        private System.Windows.Forms.TextBox txtsom;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button txtcong;
        private System.Windows.Forms.Button txttru;
        private System.Windows.Forms.Button txtnhan;
        private System.Windows.Forms.Button txtchia;
        private System.Windows.Forms.Button txtxoa;
        private System.Windows.Forms.Button txtthoat;
    }
}

