namespace DatabaseEditor.Editor.Item.Edit
{
    partial class Classes
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
            this.checkListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(148, 195);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(229, 195);
            // 
            // checkListBox
            // 
            this.checkListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkListBox.FormattingEnabled = true;
            this.checkListBox.Items.AddRange(new object[] {
            "Warrior",
            "Paladin",
            "Hunter",
            "Rogue",
            "Priest",
            "Death Knight",
            "Shaman",
            "Mage",
            "Warlock",
            "Monk",
            "Druid"});
            this.checkListBox.Location = new System.Drawing.Point(12, 12);
            this.checkListBox.Name = "checkListBox";
            this.checkListBox.Size = new System.Drawing.Size(292, 169);
            this.checkListBox.TabIndex = 4;
            // 
            // Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(316, 230);
            this.Controls.Add(this.checkListBox);
            this.Name = "Classes";
            this.Text = "Classes";
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.OkButton, 0);
            this.Controls.SetChildIndex(this.checkListBox, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBox;
    }
}
