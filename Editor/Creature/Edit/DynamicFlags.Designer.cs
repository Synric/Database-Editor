namespace DatabaseEditor.CreatureEdit
{
    partial class DynamicFlags
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
            this.LootableBox = new System.Windows.Forms.CheckBox();
            this.TrackUnitBox = new System.Windows.Forms.CheckBox();
            this.TappedByPlayerBox = new System.Windows.Forms.CheckBox();
            this.TappedBox = new System.Windows.Forms.CheckBox();
            this.TappedByAllThreatListBox = new System.Windows.Forms.CheckBox();
            this.ReferAFriendBox = new System.Windows.Forms.CheckBox();
            this.DeadBox = new System.Windows.Forms.CheckBox();
            this.SpecialInfoBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(285, 213);
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
            this.OkButton.Location = new System.Drawing.Point(204, 213);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // LootableBox
            // 
            this.LootableBox.AutoSize = true;
            this.LootableBox.Location = new System.Drawing.Point(16, 12);
            this.LootableBox.Name = "LootableBox";
            this.LootableBox.Size = new System.Drawing.Size(82, 17);
            this.LootableBox.TabIndex = 2;
            this.LootableBox.Text = "LOOTABLE";
            this.LootableBox.UseVisualStyleBackColor = true;
            // 
            // TrackUnitBox
            // 
            this.TrackUnitBox.AutoSize = true;
            this.TrackUnitBox.Location = new System.Drawing.Point(16, 35);
            this.TrackUnitBox.Name = "TrackUnitBox";
            this.TrackUnitBox.Size = new System.Drawing.Size(91, 17);
            this.TrackUnitBox.TabIndex = 3;
            this.TrackUnitBox.Text = "TRACK UNIT";
            this.TrackUnitBox.UseVisualStyleBackColor = true;
            // 
            // TappedByPlayerBox
            // 
            this.TappedByPlayerBox.AutoSize = true;
            this.TappedByPlayerBox.Location = new System.Drawing.Point(16, 81);
            this.TappedByPlayerBox.Name = "TappedByPlayerBox";
            this.TappedByPlayerBox.Size = new System.Drawing.Size(269, 17);
            this.TappedByPlayerBox.TabIndex = 5;
            this.TappedByPlayerBox.Text = "TAPPED BY PLAYER (Lua_UnitIsTappedByPlayer)";
            this.TappedByPlayerBox.UseVisualStyleBackColor = true;
            // 
            // TappedBox
            // 
            this.TappedBox.AutoSize = true;
            this.TappedBox.Location = new System.Drawing.Point(16, 58);
            this.TappedBox.Name = "TappedBox";
            this.TappedBox.Size = new System.Drawing.Size(166, 17);
            this.TappedBox.TabIndex = 4;
            this.TappedBox.Text = "TAPPED (Lua_UnitIsTapped)";
            this.TappedBox.UseVisualStyleBackColor = true;
            // 
            // TappedByAllThreatListBox
            // 
            this.TappedByAllThreatListBox.AutoSize = true;
            this.TappedByAllThreatListBox.Location = new System.Drawing.Point(16, 173);
            this.TappedByAllThreatListBox.Name = "TappedByAllThreatListBox";
            this.TappedByAllThreatListBox.Size = new System.Drawing.Size(348, 17);
            this.TappedByAllThreatListBox.TabIndex = 9;
            this.TappedByAllThreatListBox.Text = "TAPPED BY ALL THREAT LIST (Lua_UnitIsTappedByAllThreatList)";
            this.TappedByAllThreatListBox.UseVisualStyleBackColor = true;
            // 
            // ReferAFriendBox
            // 
            this.ReferAFriendBox.AutoSize = true;
            this.ReferAFriendBox.Location = new System.Drawing.Point(16, 150);
            this.ReferAFriendBox.Name = "ReferAFriendBox";
            this.ReferAFriendBox.Size = new System.Drawing.Size(115, 17);
            this.ReferAFriendBox.TabIndex = 8;
            this.ReferAFriendBox.Text = "REFER A FRIEND";
            this.ReferAFriendBox.UseVisualStyleBackColor = true;
            // 
            // DeadBox
            // 
            this.DeadBox.AutoSize = true;
            this.DeadBox.Location = new System.Drawing.Point(16, 127);
            this.DeadBox.Name = "DeadBox";
            this.DeadBox.Size = new System.Drawing.Size(56, 17);
            this.DeadBox.TabIndex = 7;
            this.DeadBox.Text = "DEAD";
            this.DeadBox.UseVisualStyleBackColor = true;
            // 
            // SpecialInfoBox
            // 
            this.SpecialInfoBox.AutoSize = true;
            this.SpecialInfoBox.Location = new System.Drawing.Point(16, 104);
            this.SpecialInfoBox.Name = "SpecialInfoBox";
            this.SpecialInfoBox.Size = new System.Drawing.Size(95, 17);
            this.SpecialInfoBox.TabIndex = 6;
            this.SpecialInfoBox.Text = "SPECIALINFO";
            this.SpecialInfoBox.UseVisualStyleBackColor = true;
            // 
            // DynamicFlags
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 248);
            this.Controls.Add(this.TappedByAllThreatListBox);
            this.Controls.Add(this.ReferAFriendBox);
            this.Controls.Add(this.DeadBox);
            this.Controls.Add(this.SpecialInfoBox);
            this.Controls.Add(this.TappedByPlayerBox);
            this.Controls.Add(this.TappedBox);
            this.Controls.Add(this.TrackUnitBox);
            this.Controls.Add(this.LootableBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DynamicFlags";
            this.ShowIcon = false;
            this.Text = "Dynamic Flags";
            this.Load += new System.EventHandler(this.DynamicFlags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.CheckBox LootableBox;
        private System.Windows.Forms.CheckBox TrackUnitBox;
        private System.Windows.Forms.CheckBox TappedByPlayerBox;
        private System.Windows.Forms.CheckBox TappedBox;
        private System.Windows.Forms.CheckBox TappedByAllThreatListBox;
        private System.Windows.Forms.CheckBox ReferAFriendBox;
        private System.Windows.Forms.CheckBox DeadBox;
        private System.Windows.Forms.CheckBox SpecialInfoBox;
    }
}