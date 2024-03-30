namespace WindowsFormsAppThree
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
            this.radList = new System.Windows.Forms.RadioButton();
            this.radDataTable = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(29, 131);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.Size = new System.Drawing.Size(769, 302);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radList.Location = new System.Drawing.Point(39, 31);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(238, 26);
            this.radList.TabIndex = 1;
            this.radList.TabStop = true;
            this.radList.Text = "Hiển thị theo Generic List";
            this.radList.UseVisualStyleBackColor = true;
            this.radList.CheckedChanged += new System.EventHandler(this.radList_CheckedChanged);
            // 
            // radDataTable
            // 
            this.radDataTable.AutoSize = true;
            this.radDataTable.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDataTable.Location = new System.Drawing.Point(39, 73);
            this.radDataTable.Name = "radDataTable";
            this.radDataTable.Size = new System.Drawing.Size(222, 26);
            this.radDataTable.TabIndex = 2;
            this.radDataTable.TabStop = true;
            this.radDataTable.Text = "Hiển thị theo DataTable";
            this.radDataTable.UseVisualStyleBackColor = true;
            this.radDataTable.CheckedChanged += new System.EventHandler(this.radDataTable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 454);
            this.Controls.Add(this.radDataTable);
            this.Controls.Add(this.radList);
            this.Controls.Add(this.dgvMember);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.RadioButton radList;
        private System.Windows.Forms.RadioButton radDataTable;
    }
}

