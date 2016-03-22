namespace DatabaseEditor.Editor.Item.Edit
{
    partial class ItemFlags
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
            this.OkButton.Location = new System.Drawing.Point(214, 267);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(295, 267);
            // 
            // checkListBox
            // 
            this.checkListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkListBox.FormattingEnabled = true;
            this.checkListBox.Items.AddRange(new object[] {
            "UNK1",
            "Conjured",
            "Openable",
            "Heroic",
            "Deprecated",
            "Can\'t be destroyed",
            "UNK2",
            "No default 30 seconds cooldown when equipped",
            "UNK3",
            "Can wrap other items",
            "UNK4",
            "Is party loot",
            "Is refundable",
            "Charter",
            "UNK5",
            "UNK6",
            "UNK7",
            "UNK8",
            "Can be prospected",
            "Unique equipped",
            "UNK9",
            "Can be used during arena match",
            "Throwable",
            "Can be used in shapeshift forms",
            "UNK10",
            "Profession recipes",
            "Cannot be used in arena",
            "Bind to Account",
            "Spell is cast with triggered flag",
            "Millable",
            "UNK11",
            "Bind on Pickup tradeable"});
            this.checkListBox.Location = new System.Drawing.Point(12, 12);
            this.checkListBox.Name = "checkListBox";
            this.checkListBox.Size = new System.Drawing.Size(358, 244);
            this.checkListBox.TabIndex = 4;
            // 
            // ItemFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(382, 302);
            this.Controls.Add(this.checkListBox);
            this.Name = "ItemFlags";
            this.Text = "Item Flags";
            this.Controls.SetChildIndex(this.CancelButton, 0);
            this.Controls.SetChildIndex(this.OkButton, 0);
            this.Controls.SetChildIndex(this.checkListBox, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListBox;
    }
}
