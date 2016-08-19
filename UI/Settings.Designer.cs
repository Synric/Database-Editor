namespace DatabaseEditor
{
    partial class Settings
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
            this.DatabaseGroupBox = new System.Windows.Forms.GroupBox();
            this.DatabaseReplaceRadioButton = new System.Windows.Forms.RadioButton();
            this.DatabaseInsertRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.versionBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.WrathVersionButton = new System.Windows.Forms.RadioButton();
            this.DatabaseGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.versionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(277, 223);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(81, 34);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OkButton.Location = new System.Drawing.Point(204, 223);
            this.OkButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(68, 34);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // DatabaseGroupBox
            // 
            this.DatabaseGroupBox.Controls.Add(this.DatabaseReplaceRadioButton);
            this.DatabaseGroupBox.Controls.Add(this.DatabaseInsertRadioButton);
            this.DatabaseGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseGroupBox.Location = new System.Drawing.Point(12, 12);
            this.DatabaseGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseGroupBox.Name = "DatabaseGroupBox";
            this.DatabaseGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseGroupBox.Size = new System.Drawing.Size(348, 50);
            this.DatabaseGroupBox.TabIndex = 2;
            this.DatabaseGroupBox.TabStop = false;
            this.DatabaseGroupBox.Text = "Database Settings";
            // 
            // DatabaseReplaceRadioButton
            // 
            this.DatabaseReplaceRadioButton.AutoSize = true;
            this.DatabaseReplaceRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseReplaceRadioButton.Location = new System.Drawing.Point(192, 21);
            this.DatabaseReplaceRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseReplaceRadioButton.Name = "DatabaseReplaceRadioButton";
            this.DatabaseReplaceRadioButton.Size = new System.Drawing.Size(111, 22);
            this.DatabaseReplaceRadioButton.TabIndex = 4;
            this.DatabaseReplaceRadioButton.Text = "Replace Into";
            this.DatabaseReplaceRadioButton.UseVisualStyleBackColor = true;
            // 
            // DatabaseInsertRadioButton
            // 
            this.DatabaseInsertRadioButton.AutoSize = true;
            this.DatabaseInsertRadioButton.Checked = true;
            this.DatabaseInsertRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatabaseInsertRadioButton.Location = new System.Drawing.Point(5, 21);
            this.DatabaseInsertRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseInsertRadioButton.Name = "DatabaseInsertRadioButton";
            this.DatabaseInsertRadioButton.Size = new System.Drawing.Size(93, 22);
            this.DatabaseInsertRadioButton.TabIndex = 3;
            this.DatabaseInsertRadioButton.TabStop = true;
            this.DatabaseInsertRadioButton.Text = "Insert Into";
            this.DatabaseInsertRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(348, 55);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Code Tabs";
            this.groupBox1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(192, 21);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "One main";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 21);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Everyone self";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // versionBox
            // 
            this.versionBox.Controls.Add(this.radioButton3);
            this.versionBox.Controls.Add(this.WrathVersionButton);
            this.versionBox.Location = new System.Drawing.Point(12, 76);
            this.versionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.versionBox.Name = "versionBox";
            this.versionBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.versionBox.Size = new System.Drawing.Size(348, 55);
            this.versionBox.TabIndex = 4;
            this.versionBox.TabStop = false;
            this.versionBox.Text = "Version Select";
            this.versionBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(192, 21);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 21);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cataclysm";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // WrathVersionButton
            // 
            this.WrathVersionButton.AutoSize = true;
            this.WrathVersionButton.Location = new System.Drawing.Point(5, 21);
            this.WrathVersionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WrathVersionButton.Name = "WrathVersionButton";
            this.WrathVersionButton.Size = new System.Drawing.Size(169, 21);
            this.WrathVersionButton.TabIndex = 0;
            this.WrathVersionButton.Text = "Wrath of the Lich King";
            this.WrathVersionButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.WrathVersionButton.UseVisualStyleBackColor = true;
            this.WrathVersionButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 261);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DatabaseGroupBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 308);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 308);
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.DatabaseGroupBox.ResumeLayout(false);
            this.DatabaseGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.versionBox.ResumeLayout(false);
            this.versionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox DatabaseGroupBox;
        private System.Windows.Forms.RadioButton DatabaseReplaceRadioButton;
        private System.Windows.Forms.RadioButton DatabaseInsertRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox versionBox;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton WrathVersionButton;
    }
}