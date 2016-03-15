namespace DatabaseEditor.CreatureEdit
{
    partial class TrainerType
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
            this.ClassRadioButton = new System.Windows.Forms.RadioButton();
            this.MountsRadioButton = new System.Windows.Forms.RadioButton();
            this.TradeSkillsRadioButton = new System.Windows.Forms.RadioButton();
            this.PetsRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassRadioButton
            // 
            this.ClassRadioButton.AutoSize = true;
            this.ClassRadioButton.Checked = true;
            this.ClassRadioButton.Location = new System.Drawing.Point(0, 0);
            this.ClassRadioButton.Name = "ClassRadioButton";
            this.ClassRadioButton.Size = new System.Drawing.Size(50, 17);
            this.ClassRadioButton.TabIndex = 0;
            this.ClassRadioButton.TabStop = true;
            this.ClassRadioButton.Text = "Class";
            this.ClassRadioButton.UseVisualStyleBackColor = true;
            // 
            // MountsRadioButton
            // 
            this.MountsRadioButton.AutoSize = true;
            this.MountsRadioButton.Location = new System.Drawing.Point(0, 23);
            this.MountsRadioButton.Name = "MountsRadioButton";
            this.MountsRadioButton.Size = new System.Drawing.Size(60, 17);
            this.MountsRadioButton.TabIndex = 1;
            this.MountsRadioButton.Text = "Mounts";
            this.MountsRadioButton.UseVisualStyleBackColor = true;
            // 
            // TradeSkillsRadioButton
            // 
            this.TradeSkillsRadioButton.AutoSize = true;
            this.TradeSkillsRadioButton.Location = new System.Drawing.Point(0, 46);
            this.TradeSkillsRadioButton.Name = "TradeSkillsRadioButton";
            this.TradeSkillsRadioButton.Size = new System.Drawing.Size(77, 17);
            this.TradeSkillsRadioButton.TabIndex = 2;
            this.TradeSkillsRadioButton.Text = "TradeSkills";
            this.TradeSkillsRadioButton.UseVisualStyleBackColor = true;
            // 
            // PetsRadioButton
            // 
            this.PetsRadioButton.AutoSize = true;
            this.PetsRadioButton.Location = new System.Drawing.Point(0, 69);
            this.PetsRadioButton.Name = "PetsRadioButton";
            this.PetsRadioButton.Size = new System.Drawing.Size(46, 17);
            this.PetsRadioButton.TabIndex = 3;
            this.PetsRadioButton.Text = "Pets";
            this.PetsRadioButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(93, 108);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(12, 108);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PetsRadioButton);
            this.panel1.Controls.Add(this.TradeSkillsRadioButton);
            this.panel1.Controls.Add(this.MountsRadioButton);
            this.panel1.Controls.Add(this.ClassRadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 90);
            this.panel1.TabIndex = 6;
            // 
            // TrainerType
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 143);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainerType";
            this.ShowIcon = false;
            this.Text = "Trainer Type";
            this.Load += new System.EventHandler(this.TrainerType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton ClassRadioButton;
        private System.Windows.Forms.RadioButton MountsRadioButton;
        private System.Windows.Forms.RadioButton TradeSkillsRadioButton;
        private System.Windows.Forms.RadioButton PetsRadioButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Panel panel1;
    }
}