﻿namespace WindowAppThree
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
            this.radList = new System.Windows.Forms.RadioButton();
            this.radDataTable = new System.Windows.Forms.RadioButton();
            this.dgvMember = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).BeginInit();
            this.SuspendLayout();
            // 
            // radList
            // 
            this.radList.AutoSize = true;
            this.radList.Location = new System.Drawing.Point(28, 22);
            this.radList.Margin = new System.Windows.Forms.Padding(2);
            this.radList.Name = "radList";
            this.radList.Size = new System.Drawing.Size(144, 17);
            this.radList.TabIndex = 2;
            this.radList.TabStop = true;
            this.radList.Text = "Hiển thị theo Generic List";
            this.radList.UseVisualStyleBackColor = true;
            this.radList.CheckedChanged += new System.EventHandler(this.radList_CheckedChanged);
            // 
            // radDataTable
            // 
            this.radDataTable.AutoSize = true;
            this.radDataTable.Location = new System.Drawing.Point(28, 60);
            this.radDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.radDataTable.Name = "radDataTable";
            this.radDataTable.Size = new System.Drawing.Size(138, 17);
            this.radDataTable.TabIndex = 3;
            this.radDataTable.TabStop = true;
            this.radDataTable.Text = "Hiển thị theo DataTable";
            this.radDataTable.UseVisualStyleBackColor = true;
            this.radDataTable.CheckedChanged += new System.EventHandler(this.radDataTable_CheckedChanged);
            // 
            // dgvMember
            // 
            this.dgvMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMember.Location = new System.Drawing.Point(38, 95);
            this.dgvMember.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMember.Name = "dgvMember";
            this.dgvMember.RowHeadersWidth = 51;
            this.dgvMember.RowTemplate.Height = 24;
            this.dgvMember.Size = new System.Drawing.Size(671, 254);
            this.dgvMember.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMember);
            this.Controls.Add(this.radDataTable);
            this.Controls.Add(this.radList);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radList;
        private System.Windows.Forms.RadioButton radDataTable;
        private System.Windows.Forms.DataGridView dgvMember;
    }
}

