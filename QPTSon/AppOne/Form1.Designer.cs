
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
            this.SoA = new System.Windows.Forms.TextBox();
            this.SoB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.Tim = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BSCNN = new System.Windows.Forms.RadioButton();
            this.USCLN = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "B";
            // 
            // SoA
            // 
            this.SoA.Location = new System.Drawing.Point(80, 48);
            this.SoA.Name = "SoA";
            this.SoA.Size = new System.Drawing.Size(311, 30);
            this.SoA.TabIndex = 4;
            // 
            // SoB
            // 
            this.SoB.Location = new System.Drawing.Point(80, 104);
            this.SoB.Name = "SoB";
            this.SoB.Size = new System.Drawing.Size(311, 30);
            this.SoB.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 6;
            // 
            // ketqua
            // 
            this.ketqua.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ketqua.ForeColor = System.Drawing.SystemColors.Window;
            this.ketqua.Location = new System.Drawing.Point(78, 36);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(311, 30);
            this.ketqua.TabIndex = 10;
            // 
            // Tim
            // 
            this.Tim.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tim.Location = new System.Drawing.Point(31, 70);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(142, 47);
            this.Tim.TabIndex = 11;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = false;
            this.Tim.Click += new System.EventHandler(this.button1_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.Location = new System.Drawing.Point(197, 72);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(135, 45);
            this.Xoa.TabIndex = 12;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(377, 72);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(126, 45);
            this.Thoat.TabIndex = 13;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BSCNN);
            this.groupBox1.Controls.Add(this.USCLN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(483, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 151);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn tìm";
            // 
            // BSCNN
            // 
            this.BSCNN.AutoSize = true;
            this.BSCNN.Location = new System.Drawing.Point(6, 94);
            this.BSCNN.Name = "BSCNN";
            this.BSCNN.Size = new System.Drawing.Size(89, 29);
            this.BSCNN.TabIndex = 8;
            this.BSCNN.TabStop = true;
            this.BSCNN.Text = "BCNN";
            this.BSCNN.UseVisualStyleBackColor = true;
            // 
            // USCLN
            // 
            this.USCLN.AutoSize = true;
            this.USCLN.Location = new System.Drawing.Point(6, 48);
            this.USCLN.Name = "USCLN";
            this.USCLN.Size = new System.Drawing.Size(87, 29);
            this.USCLN.TabIndex = 7;
            this.USCLN.TabStop = true;
            this.USCLN.Text = "UCLN";
            this.USCLN.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SoB);
            this.groupBox2.Controls.Add(this.SoA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(69, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 142);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Thoat);
            this.groupBox3.Controls.Add(this.Xoa);
            this.groupBox3.Controls.Add(this.Tim);
            this.groupBox3.Controls.Add(this.ketqua);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(71, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(567, 123);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết Quả :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(95, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tim UCLN và BCNN của A, B";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SoA;
        private System.Windows.Forms.TextBox SoB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button Xoa;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.RadioButton BSCNN;
        private System.Windows.Forms.RadioButton USCLN;
    }
}
