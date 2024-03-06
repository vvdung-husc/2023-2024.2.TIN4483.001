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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkhoaitaychien = new System.Windows.Forms.Button();
            this.btncam = new System.Windows.Forms.Button();
            this.btnlipton = new System.Windows.Forms.Button();
            this.btn7up = new System.Windows.Forms.Button();
            this.btncafe = new System.Windows.Forms.Button();
            this.btncoca = new System.Windows.Forms.Button();
            this.btnpepsi = new System.Windows.Forms.Button();
            this.btncomga = new System.Windows.Forms.Button();
            this.btngaran = new System.Windows.Forms.Button();
            this.btngavien = new System.Windows.Forms.Button();
            this.btntomvien = new System.Windows.Forms.Button();
            this.btnca = new System.Windows.Forms.Button();
            this.btnga = new System.Windows.Forms.Button();
            this.btntom = new System.Windows.Forms.Button();
            this.btnbo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbblist = new System.Windows.Forms.ComboBox();
            this.btnorder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(53, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 101);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnkhoaitaychien);
            this.groupBox1.Controls.Add(this.btncam);
            this.groupBox1.Controls.Add(this.btnlipton);
            this.groupBox1.Controls.Add(this.btn7up);
            this.groupBox1.Controls.Add(this.btncafe);
            this.groupBox1.Controls.Add(this.btncoca);
            this.groupBox1.Controls.Add(this.btnpepsi);
            this.groupBox1.Controls.Add(this.btncomga);
            this.groupBox1.Controls.Add(this.btngaran);
            this.groupBox1.Controls.Add(this.btngavien);
            this.groupBox1.Controls.Add(this.btntomvien);
            this.groupBox1.Controls.Add(this.btnca);
            this.groupBox1.Controls.Add(this.btnga);
            this.groupBox1.Controls.Add(this.btntom);
            this.groupBox1.Controls.Add(this.btnbo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 137);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(683, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Mục Món Ăn";
            // 
            // btnkhoaitaychien
            // 
            this.btnkhoaitaychien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhoaitaychien.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnkhoaitaychien.Location = new System.Drawing.Point(428, 191);
            this.btnkhoaitaychien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkhoaitaychien.Name = "btnkhoaitaychien";
            this.btnkhoaitaychien.Size = new System.Drawing.Size(227, 41);
            this.btnkhoaitaychien.TabIndex = 14;
            this.btnkhoaitaychien.Text = "Khoai Tây Chiên";
            this.btnkhoaitaychien.UseVisualStyleBackColor = true;
            this.btnkhoaitaychien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncam
            // 
            this.btncam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncam.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btncam.Location = new System.Drawing.Point(555, 143);
            this.btncam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncam.Name = "btncam";
            this.btncam.Size = new System.Drawing.Size(100, 41);
            this.btncam.TabIndex = 13;
            this.btncam.Text = "Cam";
            this.btncam.UseVisualStyleBackColor = true;
            this.btncam.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnlipton
            // 
            this.btnlipton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlipton.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnlipton.Location = new System.Drawing.Point(555, 94);
            this.btnlipton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlipton.Name = "btnlipton";
            this.btnlipton.Size = new System.Drawing.Size(100, 41);
            this.btnlipton.TabIndex = 12;
            this.btnlipton.Text = "Lipton";
            this.btnlipton.UseVisualStyleBackColor = true;
            this.btnlipton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn7up
            // 
            this.btn7up.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7up.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btn7up.Location = new System.Drawing.Point(428, 95);
            this.btn7up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn7up.Name = "btn7up";
            this.btn7up.Size = new System.Drawing.Size(100, 41);
            this.btn7up.TabIndex = 11;
            this.btn7up.Text = "7 Up";
            this.btn7up.UseVisualStyleBackColor = true;
            this.btn7up.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncafe
            // 
            this.btncafe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncafe.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btncafe.Location = new System.Drawing.Point(428, 143);
            this.btncafe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncafe.Name = "btncafe";
            this.btncafe.Size = new System.Drawing.Size(100, 41);
            this.btncafe.TabIndex = 10;
            this.btncafe.Text = "Cafe";
            this.btncafe.UseVisualStyleBackColor = true;
            this.btncafe.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncoca
            // 
            this.btncoca.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncoca.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btncoca.Location = new System.Drawing.Point(555, 47);
            this.btncoca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncoca.Name = "btncoca";
            this.btncoca.Size = new System.Drawing.Size(100, 41);
            this.btncoca.TabIndex = 9;
            this.btncoca.Text = "Coca";
            this.btncoca.UseVisualStyleBackColor = true;
            this.btncoca.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpepsi
            // 
            this.btnpepsi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpepsi.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnpepsi.Location = new System.Drawing.Point(428, 47);
            this.btnpepsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpepsi.Name = "btnpepsi";
            this.btnpepsi.Size = new System.Drawing.Size(100, 41);
            this.btnpepsi.TabIndex = 8;
            this.btnpepsi.Text = "Pepsi";
            this.btnpepsi.UseVisualStyleBackColor = true;
            this.btnpepsi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncomga
            // 
            this.btncomga.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomga.ForeColor = System.Drawing.Color.SteelBlue;
            this.btncomga.Location = new System.Drawing.Point(227, 191);
            this.btncomga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncomga.Name = "btncomga";
            this.btncomga.Size = new System.Drawing.Size(176, 41);
            this.btncomga.TabIndex = 7;
            this.btncomga.Text = "Cơm Gà Tender";
            this.btncomga.UseVisualStyleBackColor = true;
            this.btncomga.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngaran
            // 
            this.btngaran.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngaran.ForeColor = System.Drawing.Color.SteelBlue;
            this.btngaran.Location = new System.Drawing.Point(227, 143);
            this.btngaran.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngaran.Name = "btngaran";
            this.btngaran.Size = new System.Drawing.Size(176, 41);
            this.btngaran.TabIndex = 6;
            this.btngaran.Text = "Gà Rán Phần";
            this.btngaran.UseVisualStyleBackColor = true;
            this.btngaran.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngavien
            // 
            this.btngavien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngavien.ForeColor = System.Drawing.Color.SteelBlue;
            this.btngavien.Location = new System.Drawing.Point(227, 95);
            this.btngavien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngavien.Name = "btngavien";
            this.btngavien.Size = new System.Drawing.Size(176, 41);
            this.btngavien.TabIndex = 5;
            this.btngavien.Text = "Gà Viên Cola";
            this.btngavien.UseVisualStyleBackColor = true;
            this.btngavien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntomvien
            // 
            this.btntomvien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntomvien.ForeColor = System.Drawing.Color.SteelBlue;
            this.btntomvien.Location = new System.Drawing.Point(227, 47);
            this.btntomvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntomvien.Name = "btntomvien";
            this.btntomvien.Size = new System.Drawing.Size(176, 41);
            this.btntomvien.TabIndex = 4;
            this.btntomvien.Text = "Tôm Viên Cola";
            this.btntomvien.UseVisualStyleBackColor = true;
            this.btntomvien.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnca
            // 
            this.btnca.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnca.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnca.Location = new System.Drawing.Point(25, 191);
            this.btnca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnca.Name = "btnca";
            this.btnca.Size = new System.Drawing.Size(176, 41);
            this.btnca.TabIndex = 3;
            this.btnca.Text = "Burger Phô Mai Cá";
            this.btnca.UseVisualStyleBackColor = true;
            this.btnca.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnga
            // 
            this.btnga.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnga.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnga.Location = new System.Drawing.Point(25, 95);
            this.btnga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnga.Name = "btnga";
            this.btnga.Size = new System.Drawing.Size(176, 41);
            this.btnga.TabIndex = 2;
            this.btnga.Text = "Burger Phô Mai Gà";
            this.btnga.UseVisualStyleBackColor = true;
            this.btnga.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntom
            // 
            this.btntom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntom.ForeColor = System.Drawing.Color.ForestGreen;
            this.btntom.Location = new System.Drawing.Point(25, 143);
            this.btntom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntom.Name = "btntom";
            this.btntom.Size = new System.Drawing.Size(176, 41);
            this.btntom.TabIndex = 1;
            this.btntom.Text = "Burger Phô Mai Tôm";
            this.btntom.UseVisualStyleBackColor = true;
            this.btntom.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbo
            // 
            this.btnbo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbo.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnbo.Location = new System.Drawing.Point(25, 47);
            this.btnbo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbo.Name = "btnbo";
            this.btnbo.Size = new System.Drawing.Size(176, 41);
            this.btnbo.TabIndex = 0;
            this.btnbo.Text = "Burger Phô Mai Bò";
            this.btnbo.UseVisualStyleBackColor = true;
            this.btnbo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(251, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fastfood Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gvOrder
            // 
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Location = new System.Drawing.Point(16, 454);
            this.gvOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.RowHeadersWidth = 51;
            this.gvOrder.Size = new System.Drawing.Size(683, 309);
            this.gvOrder.TabIndex = 3;
            this.gvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrder_CellContentClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Red;
            this.btnxoa.Location = new System.Drawing.Point(29, 404);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(167, 43);
            this.btnxoa.TabIndex = 4;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Bàn";
            // 
            // cbblist
            // 
            this.cbblist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbblist.FormattingEnabled = true;
            this.cbblist.Location = new System.Drawing.Point(332, 409);
            this.cbblist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbblist.Name = "cbblist";
            this.cbblist.Size = new System.Drawing.Size(199, 33);
            this.cbblist.TabIndex = 6;
            this.cbblist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnorder
            // 
            this.btnorder.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnorder.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnorder.Location = new System.Drawing.Point(556, 404);
            this.btnorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(128, 43);
            this.btnorder.TabIndex = 7;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            this.btnorder.Click += new System.EventHandler(this.btnorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 790);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.cbblist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.gvOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbo;
        private System.Windows.Forms.Button btncomga;
        private System.Windows.Forms.Button btngaran;
        private System.Windows.Forms.Button btngavien;
        private System.Windows.Forms.Button btntomvien;
        private System.Windows.Forms.Button btnca;
        private System.Windows.Forms.Button btnga;
        private System.Windows.Forms.Button btntom;
        private System.Windows.Forms.Button btnpepsi;
        private System.Windows.Forms.Button btnkhoaitaychien;
        private System.Windows.Forms.Button btncam;
        private System.Windows.Forms.Button btnlipton;
        private System.Windows.Forms.Button btn7up;
        private System.Windows.Forms.Button btncafe;
        private System.Windows.Forms.Button btncoca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbblist;
        private System.Windows.Forms.Button btnorder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

