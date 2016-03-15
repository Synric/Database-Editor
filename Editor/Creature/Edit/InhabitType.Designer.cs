namespace DatabaseEditor.CreatureEdit
{
    partial class InhabitType
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
            this.GroundRadioButton = new System.Windows.Forms.RadioButton();
            this.WaterRadioButton = new System.Windows.Forms.RadioButton();
            this.AirRadioButton = new System.Windows.Forms.RadioButton();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.RadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(98, 115);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(17, 115);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // GroundRadioButton
            // 
            this.GroundRadioButton.AutoSize = true;
            this.GroundRadioButton.Checked = true;
            this.GroundRadioButton.Location = new System.Drawing.Point(0, 6);
            this.GroundRadioButton.Name = "GroundRadioButton";
            this.GroundRadioButton.Size = new System.Drawing.Size(82, 17);
            this.GroundRadioButton.TabIndex = 2;
            this.GroundRadioButton.TabStop = true;
            this.GroundRadioButton.Text = "Ground only";
            this.GroundRadioButton.UseVisualStyleBackColor = true;
            // 
            // WaterRadioButton
            // 
            this.WaterRadioButton.AutoSize = true;
            this.WaterRadioButton.Location = new System.Drawing.Point(0, 29);
            this.WaterRadioButton.Name = "WaterRadioButton";
            this.WaterRadioButton.Size = new System.Drawing.Size(76, 17);
            this.WaterRadioButton.TabIndex = 3;
            this.WaterRadioButton.TabStop = true;
            this.WaterRadioButton.Text = "Water only";
            this.WaterRadioButton.UseVisualStyleBackColor = true;
            // 
            // AirRadioButton
            // 
            this.AirRadioButton.AutoSize = true;
            this.AirRadioButton.Location = new System.Drawing.Point(0, 52);
            this.AirRadioButton.Name = "AirRadioButton";
            this.AirRadioButton.Size = new System.Drawing.Size(59, 17);
            this.AirRadioButton.TabIndex = 4;
            this.AirRadioButton.TabStop = true;
            this.AirRadioButton.Text = "Air only";
            this.AirRadioButton.UseVisualStyleBackColor = true;
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Location = new System.Drawing.Point(0, 75);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(36, 17);
            this.AllRadioButton.TabIndex = 5;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.AllRadioButton);
            this.RadioPanel.Controls.Add(this.AirRadioButton);
            this.RadioPanel.Controls.Add(this.WaterRadioButton);
            this.RadioPanel.Controls.Add(this.GroundRadioButton);
            this.RadioPanel.Location = new System.Drawing.Point(12, 6);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(113, 100);
            this.RadioPanel.TabIndex = 6;
            // 
            // InhabitType
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 150);
            this.Controls.Add(this.RadioPanel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InhabitType";
            this.ShowIcon = false;
            this.Text = "Inhabit Type";
            this.Load += new System.EventHandler(this.InhabitType_Load);
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton GroundRadioButton;
        private System.Windows.Forms.RadioButton WaterRadioButton;
        private System.Windows.Forms.RadioButton AirRadioButton;
        private System.Windows.Forms.RadioButton AllRadioButton;
        private System.Windows.Forms.Panel RadioPanel;
    }
}