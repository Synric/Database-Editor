namespace DatabaseEditor
{
    partial class FAQ
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
            this.Q1 = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Label();
            this.A3 = new System.Windows.Forms.Label();
            this.Q3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Location = new System.Drawing.Point(12, 60);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(174, 13);
            this.Q1.TabIndex = 0;
            this.Q1.Text = "Q: Why not working Model Viewer?";
            this.Q1.Visible = false;
            // 
            // A1
            // 
            this.A1.AutoSize = true;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A1.Location = new System.Drawing.Point(12, 82);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(310, 13);
            this.A1.TabIndex = 1;
            this.A1.Text = "A: You don\'t have installed Flash on Internet Explorer";
            this.A1.Visible = false;
            // 
            // A3
            // 
            this.A3.AutoSize = true;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A3.Location = new System.Drawing.Point(12, 31);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(239, 13);
            this.A3.TabIndex = 5;
            this.A3.Text = "A: Use email form glararan[at]glararan.eu";
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Location = new System.Drawing.Point(12, 9);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(146, 13);
            this.Q3.TabIndex = 4;
            this.Q3.Text = "Q: Where i can report bug/s?";
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 262);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.Q3);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.Q1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAQ";
            this.ShowIcon = false;
            this.Text = "FAQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Q1;
        private System.Windows.Forms.Label A1;
        private System.Windows.Forms.Label A3;
        private System.Windows.Forms.Label Q3;
    }
}