namespace TinhToan
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
            this.btcong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttru = new System.Windows.Forms.Button();
            this.btnhan = new System.Windows.Forms.Button();
            this.btchia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.txtsob = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btcong
            // 
            this.btcong.AllowDrop = true;
            this.btcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcong.Location = new System.Drawing.Point(50, 253);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(75, 39);
            this.btcong.TabIndex = 0;
            this.btcong.Text = "+";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thực Hiện Phép Tính";
            // 
            // bttru
            // 
            this.bttru.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttru.Location = new System.Drawing.Point(155, 253);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(75, 39);
            this.bttru.TabIndex = 2;
            this.bttru.Text = "-";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnhan
            // 
            this.btnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhan.Location = new System.Drawing.Point(266, 254);
            this.btnhan.Name = "btnhan";
            this.btnhan.Size = new System.Drawing.Size(75, 38);
            this.btnhan.TabIndex = 3;
            this.btnhan.Text = "x";
            this.btnhan.UseVisualStyleBackColor = true;
            this.btnhan.Click += new System.EventHandler(this.btnhan_Click);
            // 
            // btchia
            // 
            this.btchia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchia.Location = new System.Drawing.Point(368, 253);
            this.btchia.Name = "btchia";
            this.btchia.Size = new System.Drawing.Size(75, 39);
            this.btchia.TabIndex = 4;
            this.btchia.Text = "/";
            this.btchia.UseVisualStyleBackColor = true;
            this.btchia.Click += new System.EventHandler(this.btchia_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kết Quả";
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(155, 99);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(234, 22);
            this.txtsoa.TabIndex = 8;
            // 
            // txtsob
            // 
            this.txtsob.Location = new System.Drawing.Point(155, 148);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(233, 22);
            this.txtsob.TabIndex = 9;
            this.txtsob.TextChanged += new System.EventHandler(this.txtsob_TextChanged);
            // 
            // txtketqua
            // 
            this.txtketqua.BackColor = System.Drawing.SystemColors.Info;
            this.txtketqua.Location = new System.Drawing.Point(155, 200);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(234, 22);
            this.txtketqua.TabIndex = 10;
            // 
            // btthoat
            // 
            this.btthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.Location = new System.Drawing.Point(79, 318);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(330, 38);
            this.btthoat.TabIndex = 12;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 380);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtsob);
            this.Controls.Add(this.txtsoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btchia);
            this.Controls.Add(this.btnhan);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttru;
        private System.Windows.Forms.Button btnhan;
        private System.Windows.Forms.Button btchia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Button btthoat;
    }

}

