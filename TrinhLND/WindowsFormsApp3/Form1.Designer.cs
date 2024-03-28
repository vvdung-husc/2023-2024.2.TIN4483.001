namespace WindowsFormsApp3
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
            this.rdList = new System.Windows.Forms.RadioButton();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            this.rdTable = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // rdList
            // 
            this.rdList.AutoSize = true;
            this.rdList.Location = new System.Drawing.Point(38, 15);
            this.rdList.Name = "rdList";
            this.rdList.Size = new System.Drawing.Size(112, 17);
            this.rdList.TabIndex = 0;
            this.rdList.TabStop = true;
            this.rdList.Text = "Hiển Thị Theo List";
            this.rdList.UseVisualStyleBackColor = true;
            this.rdList.CheckedChanged += new System.EventHandler(this.rdList_CheckedChanged);
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(38, 61);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.Size = new System.Drawing.Size(722, 377);
            this.dgvMember.TabIndex = 1;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            // 
            // rdTable
            // 
            this.rdTable.AutoSize = true;
            this.rdTable.Location = new System.Drawing.Point(38, 38);
            this.rdTable.Name = "rdTable";
            this.rdTable.Size = new System.Drawing.Size(146, 17);
            this.rdTable.TabIndex = 2;
            this.rdTable.TabStop = true;
            this.rdTable.Text = "Hiển Thị Theo DataTable";
            this.rdTable.UseVisualStyleBackColor = true;
            this.rdTable.CheckedChanged += new System.EventHandler(this.rdTable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdTable);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.rdList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdList;
        private System.Windows.Forms.DataGridView dgvMember;
        private System.Windows.Forms.RadioButton rdTable;
    }
}

