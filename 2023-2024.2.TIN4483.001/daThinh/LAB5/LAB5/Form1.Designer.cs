namespace LAB5
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
            this.btpmb = new System.Windows.Forms.Button();
            this.btpmg = new System.Windows.Forms.Button();
            this.btpmc = new System.Windows.Forms.Button();
            this.btpmt = new System.Windows.Forms.Button();
            this.bttvc = new System.Windows.Forms.Button();
            this.btcgt = new System.Windows.Forms.Button();
            this.btgrp = new System.Windows.Forms.Button();
            this.btgvc = new System.Windows.Forms.Button();
            this.btpepsi = new System.Windows.Forms.Button();
            this.btcoca = new System.Windows.Forms.Button();
            this.btlipton = new System.Windows.Forms.Button();
            this.bt7up = new System.Windows.Forms.Button();
            this.btcam = new System.Windows.Forms.Button();
            this.btcafe = new System.Windows.Forms.Button();
            this.btktc = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btorder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbblist = new System.Windows.Forms.ComboBox();
            this.gvorder = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvorder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fastfood Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh mục món ăn";
            // 
            // btpmb
            // 
            this.btpmb.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpmb.Location = new System.Drawing.Point(65, 136);
            this.btpmb.Name = "btpmb";
            this.btpmb.Size = new System.Drawing.Size(189, 32);
            this.btpmb.TabIndex = 2;
            this.btpmb.Text = "Burger Phô mai bò";
            this.btpmb.UseVisualStyleBackColor = true;
            this.btpmb.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btpmg
            // 
            this.btpmg.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpmg.Location = new System.Drawing.Point(65, 200);
            this.btpmg.Name = "btpmg";
            this.btpmg.Size = new System.Drawing.Size(189, 32);
            this.btpmg.TabIndex = 4;
            this.btpmg.Text = "Burger Phô mai gà";
            this.btpmg.UseVisualStyleBackColor = true;
            this.btpmg.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btpmc
            // 
            this.btpmc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpmc.Location = new System.Drawing.Point(65, 320);
            this.btpmc.Name = "btpmc";
            this.btpmc.Size = new System.Drawing.Size(189, 32);
            this.btpmc.TabIndex = 5;
            this.btpmc.Text = "Burger Phô mai cá";
            this.btpmc.UseVisualStyleBackColor = true;
            this.btpmc.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btpmt
            // 
            this.btpmt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpmt.Location = new System.Drawing.Point(65, 263);
            this.btpmt.Name = "btpmt";
            this.btpmt.Size = new System.Drawing.Size(189, 32);
            this.btpmt.TabIndex = 6;
            this.btpmt.Text = "Burger Phô mai tôm";
            this.btpmt.UseVisualStyleBackColor = true;
            this.btpmt.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // bttvc
            // 
            this.bttvc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bttvc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bttvc.Location = new System.Drawing.Point(290, 136);
            this.bttvc.Name = "bttvc";
            this.bttvc.Size = new System.Drawing.Size(189, 32);
            this.bttvc.TabIndex = 7;
            this.bttvc.Text = "Tôm viên cola";
            this.bttvc.UseVisualStyleBackColor = true;
            this.bttvc.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btcgt
            // 
            this.btcgt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btcgt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btcgt.Location = new System.Drawing.Point(290, 320);
            this.btcgt.Name = "btcgt";
            this.btcgt.Size = new System.Drawing.Size(189, 32);
            this.btcgt.TabIndex = 9;
            this.btcgt.Text = "Cơm gà tender";
            this.btcgt.UseVisualStyleBackColor = true;
            this.btcgt.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btgrp
            // 
            this.btgrp.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btgrp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btgrp.Location = new System.Drawing.Point(290, 263);
            this.btgrp.Name = "btgrp";
            this.btgrp.Size = new System.Drawing.Size(189, 32);
            this.btgrp.TabIndex = 10;
            this.btgrp.Text = "Gà rán phần";
            this.btgrp.UseVisualStyleBackColor = true;
            this.btgrp.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btgvc
            // 
            this.btgvc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btgvc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btgvc.Location = new System.Drawing.Point(290, 200);
            this.btgvc.Name = "btgvc";
            this.btgvc.Size = new System.Drawing.Size(189, 32);
            this.btgvc.TabIndex = 11;
            this.btgvc.Text = "Gà viên cola";
            this.btgvc.UseVisualStyleBackColor = true;
            this.btgvc.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btpepsi
            // 
            this.btpepsi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btpepsi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btpepsi.Location = new System.Drawing.Point(504, 136);
            this.btpepsi.Name = "btpepsi";
            this.btpepsi.Size = new System.Drawing.Size(107, 32);
            this.btpepsi.TabIndex = 12;
            this.btpepsi.Text = "Pepsi";
            this.btpepsi.UseVisualStyleBackColor = true;
            this.btpepsi.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btcoca
            // 
            this.btcoca.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btcoca.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btcoca.Location = new System.Drawing.Point(617, 136);
            this.btcoca.Name = "btcoca";
            this.btcoca.Size = new System.Drawing.Size(107, 32);
            this.btcoca.TabIndex = 13;
            this.btcoca.Text = "Coca";
            this.btcoca.UseVisualStyleBackColor = true;
            this.btcoca.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btlipton
            // 
            this.btlipton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btlipton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btlipton.Location = new System.Drawing.Point(617, 200);
            this.btlipton.Name = "btlipton";
            this.btlipton.Size = new System.Drawing.Size(107, 32);
            this.btlipton.TabIndex = 14;
            this.btlipton.Text = "Lipton";
            this.btlipton.UseVisualStyleBackColor = true;
            this.btlipton.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // bt7up
            // 
            this.bt7up.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt7up.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bt7up.Location = new System.Drawing.Point(504, 200);
            this.bt7up.Name = "bt7up";
            this.bt7up.Size = new System.Drawing.Size(107, 32);
            this.bt7up.TabIndex = 15;
            this.bt7up.Text = "7up";
            this.bt7up.UseVisualStyleBackColor = true;
            this.bt7up.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btcam
            // 
            this.btcam.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btcam.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btcam.Location = new System.Drawing.Point(617, 263);
            this.btcam.Name = "btcam";
            this.btcam.Size = new System.Drawing.Size(107, 32);
            this.btcam.TabIndex = 16;
            this.btcam.Text = "Cam";
            this.btcam.UseVisualStyleBackColor = true;
            this.btcam.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btcafe
            // 
            this.btcafe.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btcafe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btcafe.Location = new System.Drawing.Point(504, 263);
            this.btcafe.Name = "btcafe";
            this.btcafe.Size = new System.Drawing.Size(107, 32);
            this.btcafe.TabIndex = 17;
            this.btcafe.Text = "Cafe";
            this.btcafe.UseVisualStyleBackColor = true;
            this.btcafe.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btktc
            // 
            this.btktc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btktc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btktc.Location = new System.Drawing.Point(504, 320);
            this.btktc.Name = "btktc";
            this.btktc.Size = new System.Drawing.Size(220, 32);
            this.btktc.TabIndex = 18;
            this.btktc.Text = "Khoai tây chiên";
            this.btktc.UseVisualStyleBackColor = true;
            this.btktc.Click += new System.EventHandler(this.btpmb_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(65, 395);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 34);
            this.btxoa.TabIndex = 19;
            this.btxoa.Text = "Xoa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btorder
            // 
            this.btorder.Location = new System.Drawing.Point(644, 395);
            this.btorder.Name = "btorder";
            this.btorder.Size = new System.Drawing.Size(80, 34);
            this.btorder.TabIndex = 20;
            this.btorder.Text = "Order";
            this.btorder.UseVisualStyleBackColor = true;
            this.btorder.Click += new System.EventHandler(this.btorder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên bàn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbblist
            // 
            this.cbblist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbblist.FormattingEnabled = true;
            this.cbblist.Location = new System.Drawing.Point(290, 400);
            this.cbblist.Name = "cbblist";
            this.cbblist.Size = new System.Drawing.Size(255, 33);
            this.cbblist.TabIndex = 22;
            // 
            // gvorder
            // 
            this.gvorder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvorder.Location = new System.Drawing.Point(82, 454);
            this.gvorder.Name = "gvorder";
            this.gvorder.RowHeadersWidth = 62;
            this.gvorder.RowTemplate.Height = 28;
            this.gvorder.Size = new System.Drawing.Size(642, 365);
            this.gvorder.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 853);
            this.Controls.Add(this.gvorder);
            this.Controls.Add(this.cbblist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btorder);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btktc);
            this.Controls.Add(this.btcafe);
            this.Controls.Add(this.btcam);
            this.Controls.Add(this.bt7up);
            this.Controls.Add(this.btlipton);
            this.Controls.Add(this.btcoca);
            this.Controls.Add(this.btpepsi);
            this.Controls.Add(this.btgvc);
            this.Controls.Add(this.btgrp);
            this.Controls.Add(this.btcgt);
            this.Controls.Add(this.bttvc);
            this.Controls.Add(this.btpmt);
            this.Controls.Add(this.btpmc);
            this.Controls.Add(this.btpmg);
            this.Controls.Add(this.btpmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btpmb_Click);
            ((System.ComponentModel.ISupportInitialize)(this.gvorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btpmb;
        private System.Windows.Forms.Button btpmg;
        private System.Windows.Forms.Button btpmc;
        private System.Windows.Forms.Button btpmt;
        private System.Windows.Forms.Button bttvc;
        private System.Windows.Forms.Button btcgt;
        private System.Windows.Forms.Button btgrp;
        private System.Windows.Forms.Button btgvc;
        private System.Windows.Forms.Button btpepsi;
        private System.Windows.Forms.Button btcoca;
        private System.Windows.Forms.Button btlipton;
        private System.Windows.Forms.Button bt7up;
        private System.Windows.Forms.Button btcam;
        private System.Windows.Forms.Button btcafe;
        private System.Windows.Forms.Button btktc;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbblist;
        private System.Windows.Forms.DataGridView gvorder;
    }
}

