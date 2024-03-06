namespace WindowsForms2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bbo = new System.Windows.Forms.Button();
            this.bga = new System.Windows.Forms.Button();
            this.bca = new System.Windows.Forms.Button();
            this.btvien = new System.Windows.Forms.Button();
            this.bgvien = new System.Windows.Forms.Button();
            this.bcom = new System.Windows.Forms.Button();
            this.bcoca = new System.Windows.Forms.Button();
            this.bsting = new System.Windows.Forms.Button();
            this.bpepsi = new System.Windows.Forms.Button();
            this.bhuda = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Button();
            this.gvOrrder = new System.Windows.Forms.DataGridView();
            this.cbblist = new System.Windows.Forms.ComboBox();
            this.bxoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER HERE";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.bxoa);
            this.groupBox1.Controls.Add(this.cbblist);
            this.groupBox1.Controls.Add(this.border);
            this.groupBox1.Controls.Add(this.bhuda);
            this.groupBox1.Controls.Add(this.bpepsi);
            this.groupBox1.Controls.Add(this.bsting);
            this.groupBox1.Controls.Add(this.bcoca);
            this.groupBox1.Controls.Add(this.bcom);
            this.groupBox1.Controls.Add(this.bgvien);
            this.groupBox1.Controls.Add(this.btvien);
            this.groupBox1.Controls.Add(this.bca);
            this.groupBox1.Controls.Add(this.bga);
            this.groupBox1.Controls.Add(this.bbo);
            this.groupBox1.Location = new System.Drawing.Point(35, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH MỤC MÓN ĂN";
            // 
            // bbo
            // 
            this.bbo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbo.Location = new System.Drawing.Point(43, 46);
            this.bbo.Name = "bbo";
            this.bbo.Size = new System.Drawing.Size(139, 33);
            this.bbo.TabIndex = 0;
            this.bbo.Text = "Burger bò";
            this.bbo.UseVisualStyleBackColor = true;
            this.bbo.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bga
            // 
            this.bga.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bga.Location = new System.Drawing.Point(43, 111);
            this.bga.Name = "bga";
            this.bga.Size = new System.Drawing.Size(139, 33);
            this.bga.TabIndex = 1;
            this.bga.Text = "Burger gà";
            this.bga.UseVisualStyleBackColor = true;
            this.bga.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bca
            // 
            this.bca.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bca.Location = new System.Drawing.Point(43, 183);
            this.bca.Name = "bca";
            this.bca.Size = new System.Drawing.Size(139, 33);
            this.bca.TabIndex = 2;
            this.bca.Text = "Burger cá";
            this.bca.UseVisualStyleBackColor = true;
            this.bca.Click += new System.EventHandler(this.bbo_Click);
            // 
            // btvien
            // 
            this.btvien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvien.Location = new System.Drawing.Point(208, 46);
            this.btvien.Name = "btvien";
            this.btvien.Size = new System.Drawing.Size(127, 33);
            this.btvien.TabIndex = 3;
            this.btvien.Text = "Tôm VIên";
            this.btvien.UseVisualStyleBackColor = true;
            this.btvien.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bgvien
            // 
            this.bgvien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgvien.Location = new System.Drawing.Point(208, 111);
            this.bgvien.Name = "bgvien";
            this.bgvien.Size = new System.Drawing.Size(127, 33);
            this.bgvien.TabIndex = 4;
            this.bgvien.Text = "Gà Viên";
            this.bgvien.UseVisualStyleBackColor = true;
            this.bgvien.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bcom
            // 
            this.bcom.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcom.Location = new System.Drawing.Point(208, 183);
            this.bcom.Name = "bcom";
            this.bcom.Size = new System.Drawing.Size(127, 33);
            this.bcom.TabIndex = 5;
            this.bcom.Text = "Cơm gà";
            this.bcom.UseVisualStyleBackColor = true;
            this.bcom.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bcoca
            // 
            this.bcoca.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcoca.Location = new System.Drawing.Point(383, 46);
            this.bcoca.Name = "bcoca";
            this.bcoca.Size = new System.Drawing.Size(89, 33);
            this.bcoca.TabIndex = 6;
            this.bcoca.Text = "Coca";
            this.bcoca.UseVisualStyleBackColor = true;
            this.bcoca.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bsting
            // 
            this.bsting.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsting.Location = new System.Drawing.Point(527, 46);
            this.bsting.Name = "bsting";
            this.bsting.Size = new System.Drawing.Size(89, 33);
            this.bsting.TabIndex = 7;
            this.bsting.Text = "Sting";
            this.bsting.UseVisualStyleBackColor = true;
            this.bsting.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bpepsi
            // 
            this.bpepsi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpepsi.Location = new System.Drawing.Point(383, 111);
            this.bpepsi.Name = "bpepsi";
            this.bpepsi.Size = new System.Drawing.Size(89, 33);
            this.bpepsi.TabIndex = 8;
            this.bpepsi.Text = "Pepsi";
            this.bpepsi.UseVisualStyleBackColor = true;
            this.bpepsi.Click += new System.EventHandler(this.bbo_Click);
            // 
            // bhuda
            // 
            this.bhuda.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhuda.Location = new System.Drawing.Point(527, 111);
            this.bhuda.Name = "bhuda";
            this.bhuda.Size = new System.Drawing.Size(89, 33);
            this.bhuda.TabIndex = 9;
            this.bhuda.Text = "Huda";
            this.bhuda.UseVisualStyleBackColor = true;
            this.bhuda.Click += new System.EventHandler(this.bbo_Click);
            // 
            // border
            // 
            this.border.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.border.Location = new System.Drawing.Point(383, 183);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(89, 33);
            this.border.TabIndex = 10;
            this.border.Text = "ORDER";
            this.border.UseVisualStyleBackColor = true;
            this.border.Click += new System.EventHandler(this.border_Click);
            // 
            // gvOrrder
            // 
            this.gvOrrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrrder.Location = new System.Drawing.Point(35, 359);
            this.gvOrrder.Name = "gvOrrder";
            this.gvOrrder.RowHeadersWidth = 51;
            this.gvOrrder.RowTemplate.Height = 24;
            this.gvOrrder.Size = new System.Drawing.Size(632, 154);
            this.gvOrrder.TabIndex = 2;
            this.gvOrrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbblist
            // 
            this.cbblist.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbblist.FormattingEnabled = true;
            this.cbblist.Location = new System.Drawing.Point(383, 153);
            this.cbblist.Name = "cbblist";
            this.cbblist.Size = new System.Drawing.Size(233, 25);
            this.cbblist.TabIndex = 3;
            // 
            // bxoa
            // 
            this.bxoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bxoa.Location = new System.Drawing.Point(527, 183);
            this.bxoa.Name = "bxoa";
            this.bxoa.Size = new System.Drawing.Size(89, 33);
            this.bxoa.TabIndex = 11;
            this.bxoa.Text = "Xóa";
            this.bxoa.UseVisualStyleBackColor = true;
            this.bxoa.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 571);
            this.Controls.Add(this.gvOrrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button border;
        private System.Windows.Forms.Button bhuda;
        private System.Windows.Forms.Button bpepsi;
        private System.Windows.Forms.Button bsting;
        private System.Windows.Forms.Button bcoca;
        private System.Windows.Forms.Button bcom;
        private System.Windows.Forms.Button bgvien;
        private System.Windows.Forms.Button btvien;
        private System.Windows.Forms.Button bca;
        private System.Windows.Forms.Button bga;
        private System.Windows.Forms.Button bbo;
        private System.Windows.Forms.DataGridView gvOrrder;
        private System.Windows.Forms.ComboBox cbblist;
        private System.Windows.Forms.Button bxoa;
    }
}

