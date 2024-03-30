using System;

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
            this.txtson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsom = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // txtson
            // 
            this.txtson.Location = new System.Drawing.Point(280, 113);
            this.txtson.Name = "txtson";
            this.txtson.Size = new System.Drawing.Size(383, 22);
            this.txtson.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập số m";
            // 
            // txtsom
            // 
            this.txtsom.Location = new System.Drawing.Point(280, 184);
            this.txtsom.Name = "txtsom";
            this.txtsom.Size = new System.Drawing.Size(383, 22);
            this.txtsom.TabIndex = 4;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(280, 247);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(383, 22);
            this.txtketqua.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả";
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(139, 303);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(102, 63);
            this.btcong.TabIndex = 7;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            // 
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(270, 303);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(94, 63);
            this.bttru.TabIndex = 8;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            // 
            // btnhan
            // 
            this.btnhan.Location = new System.Drawing.Point(391, 303);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(96, 63);
            this.btnhan.TabIndex = 9;
            this.btnhan.Text = "x";
            this.btnhan.UseVisualStyleBackColor = true;
            // 
            // btchia
            // 
            this.btchia.Location = new System.Drawing.Point(512, 303);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(99, 63);
            this.btchia.TabIndex = 10;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(662, 303);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(87, 63);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(391, 390);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(96, 48);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtson);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsom;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
    }
}

