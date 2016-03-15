namespace DatabaseEditor.Creature.CreatureSmartAI
{
    partial class TargetType
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.DataGridValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTargetParam1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTargetParam2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTargetParam3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTargetXColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTargetYColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTargetZColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridTargetOColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridCommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(690, 348);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 25);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OkButton.Location = new System.Drawing.Point(630, 348);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(56, 25);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridValueColumn,
            this.DataGridNameColumn,
            this.DataGridTargetParam1Column,
            this.DataGridTargetParam2Column,
            this.DataGridTargetParam3Column,
            this.DataGridTargetXColumn,
            this.DataGridTargetYColumn,
            this.DataGridTargetZColumn,
            this.DataGridTargetOColumn,
            this.DataGridCommentColumn});
            this.DataGrid.Location = new System.Drawing.Point(11, 11);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(735, 333);
            this.DataGrid.TabIndex = 2;
            this.DataGrid.DoubleClick += new System.EventHandler(this.DataGrid_DoubleClick);
            // 
            // DataGridValueColumn
            // 
            this.DataGridValueColumn.HeaderText = "Value";
            this.DataGridValueColumn.Name = "DataGridValueColumn";
            this.DataGridValueColumn.ReadOnly = true;
            // 
            // DataGridNameColumn
            // 
            this.DataGridNameColumn.HeaderText = "Name";
            this.DataGridNameColumn.Name = "DataGridNameColumn";
            this.DataGridNameColumn.ReadOnly = true;
            this.DataGridNameColumn.Width = 250;
            // 
            // DataGridTargetParam1Column
            // 
            this.DataGridTargetParam1Column.HeaderText = "Target Param 1";
            this.DataGridTargetParam1Column.Name = "DataGridTargetParam1Column";
            this.DataGridTargetParam1Column.ReadOnly = true;
            // 
            // DataGridTargetParam2Column
            // 
            this.DataGridTargetParam2Column.HeaderText = "Target Param 2";
            this.DataGridTargetParam2Column.Name = "DataGridTargetParam2Column";
            this.DataGridTargetParam2Column.ReadOnly = true;
            // 
            // DataGridTargetParam3Column
            // 
            this.DataGridTargetParam3Column.HeaderText = "Target Param 3";
            this.DataGridTargetParam3Column.Name = "DataGridTargetParam3Column";
            this.DataGridTargetParam3Column.ReadOnly = true;
            // 
            // DataGridTargetXColumn
            // 
            this.DataGridTargetXColumn.HeaderText = "Target X";
            this.DataGridTargetXColumn.Name = "DataGridTargetXColumn";
            this.DataGridTargetXColumn.ReadOnly = true;
            // 
            // DataGridTargetYColumn
            // 
            this.DataGridTargetYColumn.HeaderText = "Target Y";
            this.DataGridTargetYColumn.Name = "DataGridTargetYColumn";
            this.DataGridTargetYColumn.ReadOnly = true;
            // 
            // DataGridTargetZColumn
            // 
            this.DataGridTargetZColumn.HeaderText = "Target Z";
            this.DataGridTargetZColumn.Name = "DataGridTargetZColumn";
            this.DataGridTargetZColumn.ReadOnly = true;
            // 
            // DataGridTargetOColumn
            // 
            this.DataGridTargetOColumn.HeaderText = "Target O";
            this.DataGridTargetOColumn.Name = "DataGridTargetOColumn";
            this.DataGridTargetOColumn.ReadOnly = true;
            // 
            // DataGridCommentColumn
            // 
            this.DataGridCommentColumn.HeaderText = "Comment";
            this.DataGridCommentColumn.Name = "DataGridCommentColumn";
            this.DataGridCommentColumn.ReadOnly = true;
            this.DataGridCommentColumn.Width = 300;
            // 
            // TargetType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 384);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TargetType";
            this.ShowIcon = false;
            this.Text = "Target Type";
            this.Load += new System.EventHandler(this.TargetType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTargetParam1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTargetParam2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTargetParam3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTargetXColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTargetYColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTargetZColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridTargetOColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridCommentColumn;
    }
}