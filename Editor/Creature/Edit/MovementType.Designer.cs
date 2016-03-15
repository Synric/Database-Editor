namespace DatabaseEditor.CreatureEdit
{
    partial class MovementType
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
            this.StayRadioButton = new System.Windows.Forms.RadioButton();
            this.RandomRadioButton = new System.Windows.Forms.RadioButton();
            this.WaypointRadioButton = new System.Windows.Forms.RadioButton();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.RadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(190, 87);
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
            this.OkButton.Location = new System.Drawing.Point(109, 87);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // StayRadioButton
            // 
            this.StayRadioButton.AutoSize = true;
            this.StayRadioButton.Checked = true;
            this.StayRadioButton.Location = new System.Drawing.Point(0, 0);
            this.StayRadioButton.Name = "StayRadioButton";
            this.StayRadioButton.Size = new System.Drawing.Size(107, 17);
            this.StayRadioButton.TabIndex = 2;
            this.StayRadioButton.TabStop = true;
            this.StayRadioButton.Text = "Stay in one place";
            this.StayRadioButton.UseVisualStyleBackColor = true;
            // 
            // RandomRadioButton
            // 
            this.RandomRadioButton.AutoSize = true;
            this.RandomRadioButton.Location = new System.Drawing.Point(0, 23);
            this.RandomRadioButton.Name = "RandomRadioButton";
            this.RandomRadioButton.Size = new System.Drawing.Size(246, 17);
            this.RandomRadioButton.TabIndex = 3;
            this.RandomRadioButton.TabStop = true;
            this.RandomRadioButton.Text = "Random movement inside the spawndist radius";
            this.RandomRadioButton.UseVisualStyleBackColor = true;
            // 
            // WaypointRadioButton
            // 
            this.WaypointRadioButton.AutoSize = true;
            this.WaypointRadioButton.Location = new System.Drawing.Point(0, 46);
            this.WaypointRadioButton.Name = "WaypointRadioButton";
            this.WaypointRadioButton.Size = new System.Drawing.Size(122, 17);
            this.WaypointRadioButton.TabIndex = 4;
            this.WaypointRadioButton.TabStop = true;
            this.WaypointRadioButton.Text = "Waypoint movement";
            this.WaypointRadioButton.UseVisualStyleBackColor = true;
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.WaypointRadioButton);
            this.RadioPanel.Controls.Add(this.RandomRadioButton);
            this.RadioPanel.Controls.Add(this.StayRadioButton);
            this.RadioPanel.Location = new System.Drawing.Point(12, 12);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(250, 71);
            this.RadioPanel.TabIndex = 5;
            // 
            // MovementType
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 122);
            this.Controls.Add(this.RadioPanel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovementType";
            this.ShowIcon = false;
            this.Text = "Movement Type";
            this.Load += new System.EventHandler(this.MovementType_Load);
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton StayRadioButton;
        private System.Windows.Forms.RadioButton RandomRadioButton;
        private System.Windows.Forms.RadioButton WaypointRadioButton;
        private System.Windows.Forms.Panel RadioPanel;
    }
}