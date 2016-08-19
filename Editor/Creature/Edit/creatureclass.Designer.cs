namespace DatabaseEditor.CreatureEdit
{
    partial class CreatureClass
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
            this.WarriorRadioButton = new System.Windows.Forms.RadioButton();
            this.PaladinRadioButton = new System.Windows.Forms.RadioButton();
            this.RogueRadioButton = new System.Windows.Forms.RadioButton();
            this.MageRadioButton = new System.Windows.Forms.RadioButton();
            this.RadioPanel = new System.Windows.Forms.Panel();
            this.RadioPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(26, 167);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 28);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(26, 131);
            this.OkButton.Margin = new System.Windows.Forms.Padding(4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 28);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // WarriorRadioButton
            // 
            this.WarriorRadioButton.AutoSize = true;
            this.WarriorRadioButton.Location = new System.Drawing.Point(4, 4);
            this.WarriorRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.WarriorRadioButton.Name = "WarriorRadioButton";
            this.WarriorRadioButton.Size = new System.Drawing.Size(76, 21);
            this.WarriorRadioButton.TabIndex = 1;
            this.WarriorRadioButton.TabStop = true;
            this.WarriorRadioButton.Text = "Warrior";
            this.WarriorRadioButton.UseVisualStyleBackColor = true;
            this.WarriorRadioButton.CheckedChanged += new System.EventHandler(this.WarriorRadioButton_CheckedChanged);
            // 
            // PaladinRadioButton
            // 
            this.PaladinRadioButton.AutoSize = true;
            this.PaladinRadioButton.Location = new System.Drawing.Point(4, 33);
            this.PaladinRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.PaladinRadioButton.Name = "PaladinRadioButton";
            this.PaladinRadioButton.Size = new System.Drawing.Size(76, 21);
            this.PaladinRadioButton.TabIndex = 2;
            this.PaladinRadioButton.TabStop = true;
            this.PaladinRadioButton.Text = "Paladin";
            this.PaladinRadioButton.UseVisualStyleBackColor = true;
            this.PaladinRadioButton.CheckedChanged += new System.EventHandler(this.PaladinRadioButton_CheckedChanged);
            // 
            // RogueRadioButton
            // 
            this.RogueRadioButton.AutoSize = true;
            this.RogueRadioButton.Location = new System.Drawing.Point(4, 62);
            this.RogueRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.RogueRadioButton.Name = "RogueRadioButton";
            this.RogueRadioButton.Size = new System.Drawing.Size(71, 21);
            this.RogueRadioButton.TabIndex = 3;
            this.RogueRadioButton.TabStop = true;
            this.RogueRadioButton.Text = "Rogue";
            this.RogueRadioButton.UseVisualStyleBackColor = true;
            this.RogueRadioButton.CheckedChanged += new System.EventHandler(this.RogueRadioButton_CheckedChanged);
            // 
            // MageRadioButton
            // 
            this.MageRadioButton.AutoSize = true;
            this.MageRadioButton.Location = new System.Drawing.Point(4, 93);
            this.MageRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.MageRadioButton.Name = "MageRadioButton";
            this.MageRadioButton.Size = new System.Drawing.Size(64, 21);
            this.MageRadioButton.TabIndex = 4;
            this.MageRadioButton.TabStop = true;
            this.MageRadioButton.Text = "Mage";
            this.MageRadioButton.UseVisualStyleBackColor = true;
            this.MageRadioButton.CheckedChanged += new System.EventHandler(this.MageRadioButton_CheckedChanged);
            // 
            // RadioPanel
            // 
            this.RadioPanel.Controls.Add(this.WarriorRadioButton);
            this.RadioPanel.Controls.Add(this.PaladinRadioButton);
            this.RadioPanel.Controls.Add(this.RogueRadioButton);
            this.RadioPanel.Controls.Add(this.MageRadioButton);
            this.RadioPanel.Location = new System.Drawing.Point(35, 4);
            this.RadioPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RadioPanel.Name = "RadioPanel";
            this.RadioPanel.Size = new System.Drawing.Size(82, 118);
            this.RadioPanel.TabIndex = 13;
            // 
            // CreatureClass
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 208);
            this.Controls.Add(this.RadioPanel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreatureClass";
            this.ShowIcon = false;
            this.Text = "Creature Class";
            this.Load += new System.EventHandler(this.CreatureClass_Load);
            this.RadioPanel.ResumeLayout(false);
            this.RadioPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton WarriorRadioButton;
        private System.Windows.Forms.RadioButton PaladinRadioButton;
        private System.Windows.Forms.RadioButton RogueRadioButton;
        private System.Windows.Forms.RadioButton MageRadioButton;
        private System.Windows.Forms.Panel RadioPanel;
    }
}