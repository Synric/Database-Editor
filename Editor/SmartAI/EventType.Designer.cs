namespace DatabaseEditor.Creature.CreatureSmartAI
{
    partial class EventType
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
            this.DataGridParam1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridParam2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridParam3Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridParam4Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridCommentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(731, 352);
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
            this.OkButton.Location = new System.Drawing.Point(670, 352);
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
            this.DataGridParam1Column,
            this.DataGridParam2Column,
            this.DataGridParam3Column,
            this.DataGridParam4Column,
            this.DataGridCommentColumn});
            this.DataGrid.Location = new System.Drawing.Point(11, 11);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(774, 337);
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
            this.DataGridNameColumn.Width = 300;
            // 
            // DataGridParam1Column
            // 
            this.DataGridParam1Column.HeaderText = "Param 1";
            this.DataGridParam1Column.Name = "DataGridParam1Column";
            this.DataGridParam1Column.ReadOnly = true;
            this.DataGridParam1Column.Width = 200;
            // 
            // DataGridParam2Column
            // 
            this.DataGridParam2Column.HeaderText = "Param 2";
            this.DataGridParam2Column.Name = "DataGridParam2Column";
            this.DataGridParam2Column.ReadOnly = true;
            // 
            // DataGridParam3Column
            // 
            this.DataGridParam3Column.HeaderText = "Param 3";
            this.DataGridParam3Column.Name = "DataGridParam3Column";
            this.DataGridParam3Column.ReadOnly = true;
            // 
            // DataGridParam4Column
            // 
            this.DataGridParam4Column.HeaderText = "Param 4";
            this.DataGridParam4Column.Name = "DataGridParam4Column";
            this.DataGridParam4Column.ReadOnly = true;
            // 
            // DataGridCommentColumn
            // 
            this.DataGridCommentColumn.HeaderText = "Comment";
            this.DataGridCommentColumn.Name = "DataGridCommentColumn";
            this.DataGridCommentColumn.ReadOnly = true;
            this.DataGridCommentColumn.Width = 300;
            // 
            // EventType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 386);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventType";
            this.ShowIcon = false;
            this.Text = "Event Type";
            this.Load += new System.EventHandler(this.EventType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridParam1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridParam2Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridParam3Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridParam4Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridCommentColumn;
    }
}