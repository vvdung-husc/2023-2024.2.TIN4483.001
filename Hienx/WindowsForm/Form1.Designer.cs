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
            this.txtson = new System.Windows.Forms.Label();
            this.txtsom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.Label();
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
            // txtson
            // 
            this.txtson.AutoSize = true;
            this.txtson.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtson.Location = new System.Drawing.Point(95, 153);
            this.txtson.Name = "txtson";
            this.txtson.Size = new System.Drawing.Size(78, 17);
            this.txtson.TabIndex = 1;
            this.txtson.Text = "Nhập số n:";
            this.txtson.Click += new System.EventHandler(this.txtson_Click);
            // 
            // txtsom
            // 
            this.txtsom.AutoSize = true;
            this.txtsom.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsom.Location = new System.Drawing.Point(95, 207);
            this.txtsom.Name = "txtsom";
            this.txtsom.Size = new System.Drawing.Size(82, 17);
            this.txtsom.TabIndex = 2;
            this.txtsom.Text = "Nhập số m:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(204, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(306, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBox3.Location = new System.Drawing.Point(204, 250);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(306, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtkq
            // 
            this.txtkq.AutoSize = true;
            this.txtkq.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.ForeColor = System.Drawing.Color.Black;
            this.txtkq.Location = new System.Drawing.Point(98, 256);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(65, 17);
            this.txtkq.TabIndex = 5;
            this.txtkq.Text = "Kết quả:";
            this.txtkq.Click += new System.EventHandler(this.label4_Click);
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
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtsom);
            this.Controls.Add(this.txtson);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtson;
        private System.Windows.Forms.Label txtsom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtkq;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
    }
}

