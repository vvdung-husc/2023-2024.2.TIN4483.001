namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.Tim = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chkBSCNN = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUSCLN = new System.Windows.Forms.CheckBox();
            this.SoB = new System.Windows.Forms.Label();
            this.SoA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tim
            // 
            this.Tim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Tim.Location = new System.Drawing.Point(57, 86);
            this.Tim.Name = "Tim";
            this.Tim.Size = new System.Drawing.Size(147, 45);
            this.Tim.TabIndex = 7;
            this.Tim.Text = "Tìm";
            this.Tim.UseVisualStyleBackColor = false;
            this.Tim.Click += new System.EventHandler(this.Tim_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(255, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Bỏ qua";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Thoat.Location = new System.Drawing.Point(444, 86);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(153, 45);
            this.Thoat.TabIndex = 11;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            // 
            // chkBSCNN
            // 
            this.chkBSCNN.AutoSize = true;
            this.chkBSCNN.BackColor = System.Drawing.SystemColors.Window;
            this.chkBSCNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBSCNN.Location = new System.Drawing.Point(47, 111);
            this.chkBSCNN.Name = "chkBSCNN";
            this.chkBSCNN.Size = new System.Drawing.Size(95, 24);
            this.chkBSCNN.TabIndex = 13;
            this.chkBSCNN.Text = "BSCNN";
            this.chkBSCNN.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.chkBSCNN);
            this.groupBox1.Controls.Add(this.chkUSCLN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(541, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 163);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn tìm";
            // 
            // chkUSCLN
            // 
            this.chkUSCLN.AutoSize = true;
            this.chkUSCLN.BackColor = System.Drawing.SystemColors.Window;
            this.chkUSCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUSCLN.Location = new System.Drawing.Point(47, 47);
            this.chkUSCLN.Name = "chkUSCLN";
            this.chkUSCLN.Size = new System.Drawing.Size(93, 24);
            this.chkUSCLN.TabIndex = 12;
            this.chkUSCLN.Text = "USCLN";
            this.chkUSCLN.UseVisualStyleBackColor = false;
            // 
            // SoB
            // 
            this.SoB.AutoSize = true;
            this.SoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoB.Location = new System.Drawing.Point(27, 96);
            this.SoB.Name = "SoB";
            this.SoB.Size = new System.Drawing.Size(35, 29);
            this.SoB.TabIndex = 1;
            this.SoB.Text = "B:";
            // 
            // SoA
            // 
            this.SoA.AutoSize = true;
            this.SoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoA.Location = new System.Drawing.Point(27, 47);
            this.SoA.Name = "SoA";
            this.SoA.Size = new System.Drawing.Size(34, 29);
            this.SoA.TabIndex = 2;
            this.SoA.Text = "A:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(114, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 27);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.SoA);
            this.groupBox2.Controls.Add(this.SoB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(97, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 163);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(133, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(382, 27);
            this.textBox3.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.Tim);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.Thoat);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(97, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 146);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kết quả:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Tim;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox chkBSCNN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SoB;
        private System.Windows.Forms.Label SoA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkUSCLN;
    }
}

