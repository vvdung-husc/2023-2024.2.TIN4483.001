namespace WindowsFormsApp3_lab5
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
            this.rdTable = new System.Windows.Forms.RadioButton();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // rdList
            // 
            this.rdList.AutoSize = true;
            this.rdList.Location = new System.Drawing.Point(94, 33);
            this.rdList.Name = "rdList";
            this.rdList.Size = new System.Drawing.Size(161, 24);
            this.rdList.TabIndex = 0;
            this.rdList.TabStop = true;
            this.rdList.Text = "Hiển Thị Theo List";
            this.rdList.UseVisualStyleBackColor = true;
            this.rdList.CheckedChanged += new System.EventHandler(this.rdList_CheckedChanged);
            // 
            // rdTable
            // 
            this.rdTable.AutoSize = true;
            this.rdTable.Location = new System.Drawing.Point(94, 87);
            this.rdTable.Name = "rdTable";
            this.rdTable.Size = new System.Drawing.Size(210, 24);
            this.rdTable.TabIndex = 1;
            this.rdTable.TabStop = true;
            this.rdTable.Text = "Hiển Thị Theo DataTable";
            this.rdTable.UseVisualStyleBackColor = true;
            this.rdTable.CheckedChanged += new System.EventHandler(this.rdTable_CheckedChanged);
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(36, 147);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 62;
            this.dgvMember.RowTemplate.Height = 28;
            this.dgvMember.Size = new System.Drawing.Size(599, 272);
            this.dgvMember.TabIndex = 2;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.rdTable);
            this.Controls.Add(this.rdList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdList;
        private System.Windows.Forms.RadioButton rdTable;
        private System.Windows.Forms.DataGridView dgvMember;
    }
}

