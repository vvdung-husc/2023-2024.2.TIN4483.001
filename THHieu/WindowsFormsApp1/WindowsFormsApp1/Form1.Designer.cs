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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tbKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả là:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(115, 57);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(188, 22);
            this.tb1.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(115, 145);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(188, 22);
            this.tb2.TabIndex = 4;
            // 
            // tbKQ
            // 
            this.tbKQ.Location = new System.Drawing.Point(115, 236);
            this.tbKQ.Name = "tbKQ";
            this.tbKQ.Size = new System.Drawing.Size(647, 22);
            this.tbKQ.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt2);
            this.groupBox1.Controls.Add(this.rbt1);
            this.groupBox1.Location = new System.Drawing.Point(309, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(57, 106);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(206, 20);
            this.rbt2.TabIndex = 1;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Ước chung lớn nhất của a và b";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(57, 40);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(157, 20);
            this.rbt1.TabIndex = 0;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Ước chung của a và b";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(664, 333);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(394, 333);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(115, 333);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(75, 23);
            this.btTinh.TabIndex = 7;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbKQ);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tbKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTinh;
    }
}

