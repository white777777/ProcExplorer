﻿namespace ProcExplorer
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
            this.refresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProcDataGrid = new System.Windows.Forms.DataGridView();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProcDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(72, 23);
            this.refresh.TabIndex = 0;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ProcDataGrid
            // 
            this.ProcDataGrid.AllowUserToAddRows = false;
            this.ProcDataGrid.AllowUserToDeleteRows = false;
            this.ProcDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProcDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProcDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.ProcDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PName,
            this.ID,
            this.PFullName,
            this.POwner,
            this.Type});
            this.ProcDataGrid.Location = new System.Drawing.Point(404, 12);
            this.ProcDataGrid.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.ProcDataGrid.Name = "ProcDataGrid";
            this.ProcDataGrid.ReadOnly = true;
            this.ProcDataGrid.RowHeadersVisible = false;
            this.ProcDataGrid.RowTemplate.Height = 24;
            this.ProcDataGrid.Size = new System.Drawing.Size(764, 485);
            this.ProcDataGrid.TabIndex = 4;
            // 
            // PName
            // 
            this.PName.HeaderText = "PName";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            this.PName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ID
            // 
            this.ID.HeaderText = "PID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // PFullName
            // 
            this.PFullName.HeaderText = "PFullName";
            this.PFullName.Name = "PFullName";
            this.PFullName.ReadOnly = true;
            // 
            // POwner
            // 
            this.POwner.HeaderText = "POwner";
            this.POwner.Name = "POwner";
            this.POwner.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 569);
            this.Controls.Add(this.ProcDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.refresh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProcDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn POwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}

