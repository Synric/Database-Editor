namespace DatabaseEditor.Creature.CreatureSmartAI
{
    partial class ActionType
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
            this.DataGridActionParam1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridActionParam2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridActionParam3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridActionParam4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridActionParam5Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridActionParam6Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridCommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(713, 353);
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
            this.OkButton.Location = new System.Drawing.Point(652, 353);
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
            this.DataGridActionParam1Column,
            this.DataGridActionParam2Column,
            this.DataGridActionParam3Column,
            this.DataGridActionParam4Column,
            this.DataGridActionParam5Column,
            this.DataGridActionParam6Column,
            this.DataGridCommentColumn});
            this.DataGrid.Location = new System.Drawing.Point(11, 11);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(756, 338);
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
            // DataGridActionParam1Column
            // 
            this.DataGridActionParam1Column.HeaderText = "Action Param 1";
            this.DataGridActionParam1Column.Name = "DataGridActionParam1Column";
            this.DataGridActionParam1Column.ReadOnly = true;
            // 
            // DataGridActionParam2Column
            // 
            this.DataGridActionParam2Column.HeaderText = "Action Param 2";
            this.DataGridActionParam2Column.Name = "DataGridActionParam2Column";
            this.DataGridActionParam2Column.ReadOnly = true;
            // 
            // DataGridActionParam3Column
            // 
            this.DataGridActionParam3Column.HeaderText = "Action Param 3";
            this.DataGridActionParam3Column.Name = "DataGridActionParam3Column";
            this.DataGridActionParam3Column.ReadOnly = true;
            // 
            // DataGridActionParam4Column
            // 
            this.DataGridActionParam4Column.HeaderText = "Action Param 4";
            this.DataGridActionParam4Column.Name = "DataGridActionParam4Column";
            this.DataGridActionParam4Column.ReadOnly = true;
            // 
            // DataGridActionParam5Column
            // 
            this.DataGridActionParam5Column.HeaderText = "Action Param 5";
            this.DataGridActionParam5Column.Name = "DataGridActionParam5Column";
            this.DataGridActionParam5Column.ReadOnly = true;
            // 
            // DataGridActionParam6Column
            // 
            this.DataGridActionParam6Column.HeaderText = "Action Param 6";
            this.DataGridActionParam6Column.Name = "DataGridActionParam6Column";
            this.DataGridActionParam6Column.ReadOnly = true;
            // 
            // DataGridCommentColumn
            // 
            this.DataGridCommentColumn.HeaderText = "Comment";
            this.DataGridCommentColumn.Name = "DataGridCommentColumn";
            this.DataGridCommentColumn.ReadOnly = true;
            this.DataGridCommentColumn.Width = 250;
            // 
            // ActionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 387);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ActionType";
            this.Text = "Action Type";
            this.Load += new System.EventHandler(this.ActionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridActionParam1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridActionParam2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridActionParam3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridActionParam4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridActionParam5Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridActionParam6Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridCommentColumn;
    }
}