namespace DatabaseEditor.CreatureEdit
{
    partial class Rank
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
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.EliteRadioButton = new System.Windows.Forms.RadioButton();
            this.RareEliteRadioButton = new System.Windows.Forms.RadioButton();
            this.WorldBossRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.RareRadioButton = new System.Windows.Forms.RadioButton();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.RadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Checked = true;
            this.NoneRadioButton.Location = new System.Drawing.Point(0, 0);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneRadioButton.TabIndex = 0;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "None";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // EliteRadioButton
            // 
            this.EliteRadioButton.AutoSize = true;
            this.EliteRadioButton.Location = new System.Drawing.Point(0, 23);
            this.EliteRadioButton.Name = "EliteRadioButton";
            this.EliteRadioButton.Size = new System.Drawing.Size(45, 17);
            this.EliteRadioButton.TabIndex = 1;
            this.EliteRadioButton.Text = "Elite";
            this.EliteRadioButton.UseVisualStyleBackColor = true;
            // 
            // RareEliteRadioButton
            // 
            this.RareEliteRadioButton.AutoSize = true;
            this.RareEliteRadioButton.Location = new System.Drawing.Point(0, 69);
            this.RareEliteRadioButton.Name = "RareEliteRadioButton";
            this.RareEliteRadioButton.Size = new System.Drawing.Size(71, 17);
            this.RareEliteRadioButton.TabIndex = 2;
            this.RareEliteRadioButton.Text = "Rare Elite";
            this.RareEliteRadioButton.UseVisualStyleBackColor = true;
            // 
            // WorldBossRadioButton
            // 
            this.WorldBossRadioButton.AutoSize = true;
            this.WorldBossRadioButton.Location = new System.Drawing.Point(1, 92);
            this.WorldBossRadioButton.Name = "WorldBossRadioButton";
            this.WorldBossRadioButton.Size = new System.Drawing.Size(76, 17);
            this.WorldBossRadioButton.TabIndex = 3;
            this.WorldBossRadioButton.Text = "WorldBoss";
            this.WorldBossRadioButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(98, 138);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(17, 138);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // RareRadioButton
            // 
            this.RareRadioButton.AutoSize = true;
            this.RareRadioButton.Location = new System.Drawing.Point(1, 46);
            this.RareRadioButton.Name = "RareRadioButton";
            this.RareRadioButton.Size = new System.Drawing.Size(48, 17);
            this.RareRadioButton.TabIndex = 6;
            this.RareRadioButton.Text = "Rare";
            this.RareRadioButton.UseVisualStyleBackColor = true;
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.RareRadioButton);
            this.RadioPanel.Controls.Add(this.WorldBossRadioButton);
            this.RadioPanel.Controls.Add(this.RareEliteRadioButton);
            this.RadioPanel.Controls.Add(this.EliteRadioButton);
            this.RadioPanel.Controls.Add(this.NoneRadioButton);
            this.RadioPanel.Location = new System.Drawing.Point(12, 12);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(157, 115);
            this.RadioPanel.TabIndex = 7;
            // 
            // Rank
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 173);
            this.Controls.Add(this.RadioPanel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Rank";
            this.ShowIcon = false;
            this.Text = "Rank";
            this.Load += new System.EventHandler(this.Rank_Load);
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton NoneRadioButton;
        private System.Windows.Forms.RadioButton EliteRadioButton;
        private System.Windows.Forms.RadioButton RareEliteRadioButton;
        private System.Windows.Forms.RadioButton WorldBossRadioButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton RareRadioButton;
        private System.Windows.Forms.Panel RadioPanel;
    }
}