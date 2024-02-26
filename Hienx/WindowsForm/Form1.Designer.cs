namespace WindowsForm
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
            this.txt = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.Label();
            this.txtson = new System.Windows.Forms.TextBox();
            this.txtsom = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.txtk = new System.Windows.Forms.Label();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(173, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.Location = new System.Drawing.Point(95, 153);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(78, 17);
            this.txt.TabIndex = 1;
            this.txt.Text = "Nhập số n:";
            this.txt.Click += new System.EventHandler(this.txtson_Click);
            // 
            // txtm
            // 
            this.txtm.AutoSize = true;
            this.txtm.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtm.Location = new System.Drawing.Point(95, 207);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(82, 17);
            this.txtm.TabIndex = 2;
            this.txtm.Text = "Nhập số m:";
            // 
            // txtson
            // 
            this.txtson.Location = new System.Drawing.Point(204, 147);
            this.txtson.Name = "txtson";
            this.txtson.Size = new System.Drawing.Size(306, 22);
            this.txtson.TabIndex = 3;
            this.txtson.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtsom
            // 
            this.txtsom.Location = new System.Drawing.Point(204, 201);
            this.txtsom.Name = "txtsom";
            this.txtsom.Size = new System.Drawing.Size(306, 22);
            this.txtsom.TabIndex = 4;
            // 
            // txtketqua
            // 
            this.txtketqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtketqua.Location = new System.Drawing.Point(204, 250);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(306, 22);
            this.txtketqua.TabIndex = 6;
            this.txtketqua.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtk
            // 
            this.txtk.AutoSize = true;
            this.txtk.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtk.ForeColor = System.Drawing.Color.Black;
            this.txtk.Location = new System.Drawing.Point(98, 256);
            this.txtk.Name = "txtk";
            this.txtk.Size = new System.Drawing.Size(65, 17);
            this.txtk.TabIndex = 5;
            this.txtk.Text = "Kết quả:";
            this.txtk.Click += new System.EventHandler(this.label4_Click);
            // 
            // btcong
            // 
            this.btcong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcong.Location = new System.Drawing.Point(201, 300);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(69, 33);
            this.btcong.TabIndex = 7;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // bttru
            // 
            this.bttru.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttru.Location = new System.Drawing.Point(276, 300);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(69, 33);
            this.bttru.TabIndex = 8;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.bttru_Click);
            // 
            // btnhan
            // 
            this.btnhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhan.Location = new System.Drawing.Point(351, 300);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(69, 33);
            this.btnhan.TabIndex = 9;
            this.btnhan.Text = "*";
            this.btnhan.UseVisualStyleBackColor = true;
            this.btnhan.Click += new System.EventHandler(this.btnhan_Click);
            // 
            // btchia
            // 
            this.btchia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchia.Location = new System.Drawing.Point(426, 300);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(69, 33);
            this.btchia.TabIndex = 10;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            this.btchia.Click += new System.EventHandler(this.btchia_Click);
            // 
            // btxoa
            // 
            this.btxoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Location = new System.Drawing.Point(98, 300);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(72, 33);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = false;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(201, 358);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(291, 35);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btchia);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtk);
            this.Controls.Add(this.txtsom);
            this.Controls.Add(this.txtson);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label txtm;
        private System.Windows.Forms.TextBox txtson;
        private System.Windows.Forms.TextBox txtsom;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label txtk;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
    }
}

