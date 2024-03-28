namespace WindowsFormsThree
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMember.Location = new System.Drawing.Point(55, 126);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(758, 384);
            this.dgvMember.TabIndex = 0;
            this.dgvMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMember_CellContentClick);
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radList.Location = new System.Drawing.Point(55, 23);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(328, 33);
            this.radList.TabIndex = 1;
            this.radList.TabStop = true;
            this.radList.Text = "Hiển thị theo Generic List";
            this.radList.UseVisualStyleBackColor = false;
            this.radList.CheckedChanged += new System.EventHandler(this.radList_CheckedChanged);
            // 
            // radDataTable
            // 
            this.radDataTable.AutoSize = true;
            this.radDataTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radDataTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDataTable.ForeColor = System.Drawing.Color.Red;
            this.radDataTable.Location = new System.Drawing.Point(55, 72);
            this.radDataTable.Name = "radDataTable";
            this.radDataTable.Size = new System.Drawing.Size(309, 33);
            this.radDataTable.TabIndex = 2;
            this.radDataTable.TabStop = true;
            this.radDataTable.Text = "Hiển thị theo DataTable";
            this.radDataTable.UseVisualStyleBackColor = false;
            this.radDataTable.CheckedChanged += new System.EventHandler(this.radDataTable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 522);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}

