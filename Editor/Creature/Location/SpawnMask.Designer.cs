namespace DatabaseEditor.CreatureLocation
{
    partial class SpawnMask
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
            this.SpawnMask0RadioButton = new System.Windows.Forms.RadioButton();
            this.SpawnMask1RadioButton = new System.Windows.Forms.RadioButton();
            this.SpawnMask2RadioButton = new System.Windows.Forms.RadioButton();
            this.SpawnMask4RadioButton = new System.Windows.Forms.RadioButton();
            this.SpawnMask8RadioButton = new System.Windows.Forms.RadioButton();
            this.SpawnMask15RadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(93, 165);
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
            this.OkButton.Location = new System.Drawing.Point(12, 165);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SpawnMask0RadioButton
            // 
            this.SpawnMask0RadioButton.AutoSize = true;
            this.SpawnMask0RadioButton.Checked = true;
            this.SpawnMask0RadioButton.Location = new System.Drawing.Point(0, 0);
            this.SpawnMask0RadioButton.Name = "SpawnMask0RadioButton";
            this.SpawnMask0RadioButton.Size = new System.Drawing.Size(105, 17);
            this.SpawnMask0RadioButton.TabIndex = 2;
            this.SpawnMask0RadioButton.TabStop = true;
            this.SpawnMask0RadioButton.Text = "0 - Not Spawned";
            this.SpawnMask0RadioButton.UseVisualStyleBackColor = true;
            // 
            // SpawnMask1RadioButton
            // 
            this.SpawnMask1RadioButton.AutoSize = true;
            this.SpawnMask1RadioButton.Location = new System.Drawing.Point(0, 23);
            this.SpawnMask1RadioButton.Name = "SpawnMask1RadioButton";
            this.SpawnMask1RadioButton.Size = new System.Drawing.Size(111, 17);
            this.SpawnMask1RadioButton.TabIndex = 3;
            this.SpawnMask1RadioButton.Text = "1 - Normal 10 man";
            this.SpawnMask1RadioButton.UseVisualStyleBackColor = true;
            // 
            // SpawnMask2RadioButton
            // 
            this.SpawnMask2RadioButton.AutoSize = true;
            this.SpawnMask2RadioButton.Location = new System.Drawing.Point(0, 46);
            this.SpawnMask2RadioButton.Name = "SpawnMask2RadioButton";
            this.SpawnMask2RadioButton.Size = new System.Drawing.Size(111, 17);
            this.SpawnMask2RadioButton.TabIndex = 4;
            this.SpawnMask2RadioButton.Text = "2 - Normal 25 man";
            this.SpawnMask2RadioButton.UseVisualStyleBackColor = true;
            // 
            // SpawnMask4RadioButton
            // 
            this.SpawnMask4RadioButton.AutoSize = true;
            this.SpawnMask4RadioButton.Location = new System.Drawing.Point(0, 69);
            this.SpawnMask4RadioButton.Name = "SpawnMask4RadioButton";
            this.SpawnMask4RadioButton.Size = new System.Drawing.Size(109, 17);
            this.SpawnMask4RadioButton.TabIndex = 5;
            this.SpawnMask4RadioButton.Text = "4 - Heroic 10 man";
            this.SpawnMask4RadioButton.UseVisualStyleBackColor = true;
            // 
            // SpawnMask8RadioButton
            // 
            this.SpawnMask8RadioButton.AutoSize = true;
            this.SpawnMask8RadioButton.Location = new System.Drawing.Point(0, 92);
            this.SpawnMask8RadioButton.Name = "SpawnMask8RadioButton";
            this.SpawnMask8RadioButton.Size = new System.Drawing.Size(109, 17);
            this.SpawnMask8RadioButton.TabIndex = 6;
            this.SpawnMask8RadioButton.Text = "8 - Heroic 25 man";
            this.SpawnMask8RadioButton.UseVisualStyleBackColor = true;
            // 
            // SpawnMask15RadioButton
            // 
            this.SpawnMask15RadioButton.AutoSize = true;
            this.SpawnMask15RadioButton.Location = new System.Drawing.Point(0, 115);
            this.SpawnMask15RadioButton.Name = "SpawnMask15RadioButton";
            this.SpawnMask15RadioButton.Size = new System.Drawing.Size(57, 17);
            this.SpawnMask15RadioButton.TabIndex = 7;
            this.SpawnMask15RadioButton.Text = "15 - All";
            this.SpawnMask15RadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.SpawnMask15RadioButton);
            this.panel1.Controls.Add(this.SpawnMask8RadioButton);
            this.panel1.Controls.Add(this.SpawnMask4RadioButton);
            this.panel1.Controls.Add(this.SpawnMask2RadioButton);
            this.panel1.Controls.Add(this.SpawnMask1RadioButton);
            this.panel1.Controls.Add(this.SpawnMask0RadioButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 147);
            this.panel1.TabIndex = 8;
            // 
            // SpawnMask
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpawnMask";
            this.ShowIcon = false;
            this.Text = "SpawnMask";
            this.Load += new System.EventHandler(this.SpawnMask_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.RadioButton SpawnMask0RadioButton;
        private System.Windows.Forms.RadioButton SpawnMask1RadioButton;
        private System.Windows.Forms.RadioButton SpawnMask2RadioButton;
        private System.Windows.Forms.RadioButton SpawnMask4RadioButton;
        private System.Windows.Forms.RadioButton SpawnMask8RadioButton;
        private System.Windows.Forms.RadioButton SpawnMask15RadioButton;
        private System.Windows.Forms.Panel panel1;
    }
}