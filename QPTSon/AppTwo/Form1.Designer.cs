namespace WindowAppThree
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
            this.dgvMember = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.radList = new System.Windows.Forms.RadioButton();
            this.radDataTable = new System.Windows.Forms.RadioButton();
=======
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
>>>>>>> a862dc3ef777346408bcfe8d2612e29b207911b9
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dgvMember.Location = new System.Drawing.Point(34, 92);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(1041, 423);
            this.dgvMember.TabIndex = 0;
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.Location = new System.Drawing.Point(34, 12);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(174, 20);
            this.radList.TabIndex = 1;
            this.radList.TabStop = true;
            this.radList.Text = "Hiển thị theo Generic List";
            this.radList.UseVisualStyleBackColor = true;
            this.radList.CheckedChanged += new System.EventHandler(this.radList_CheckedChanged);
            // 
            // radDataTable
            // 
            this.radDataTable.AutoSize = true;
            this.radDataTable.Location = new System.Drawing.Point(34, 38);
            this.radDataTable.Name = "radDataTable";
            this.radDataTable.Size = new System.Drawing.Size(169, 20);
            this.radDataTable.TabIndex = 2;
            this.radDataTable.TabStop = true;
            this.radDataTable.Text = "Hiển thị theo DataTable";
            this.radDataTable.UseVisualStyleBackColor = true;
            this.radDataTable.CheckedChanged += new System.EventHandler(this.radDataTable_CheckedChanged);
=======
            this.dgvMember.Location = new System.Drawing.Point(18, 154);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.Size = new System.Drawing.Size(761, 282);
            this.dgvMember.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(37, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioList";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioTable";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
>>>>>>> a862dc3ef777346408bcfe8d2612e29b207911b9
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1114, 563);
            this.Controls.Add(this.radDataTable);
            this.Controls.Add(this.radList);
=======
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
>>>>>>> a862dc3ef777346408bcfe8d2612e29b207911b9
            this.Controls.Add(this.dgvMember);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMember;
<<<<<<< HEAD
        private System.Windows.Forms.RadioButton radList;
        private System.Windows.Forms.RadioButton radDataTable;
    }
}

=======
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}
>>>>>>> a862dc3ef777346408bcfe8d2612e29b207911b9
