namespace DatabaseEditor.Creature.CreatureSmartAI
{
    partial class EventFlags
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
            this.FlagBox1 = new System.Windows.Forms.CheckBox();
            this.FlagBox2 = new System.Windows.Forms.CheckBox();
            this.FlagBox4 = new System.Windows.Forms.CheckBox();
            this.FlagBox8 = new System.Windows.Forms.CheckBox();
            this.FlagBox16 = new System.Windows.Forms.CheckBox();
            this.FlagBox128 = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlagBox1
            // 
            this.FlagBox1.AutoSize = true;
            this.FlagBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagBox1.Location = new System.Drawing.Point(9, 10);
            this.FlagBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlagBox1.Name = "FlagBox1";
            this.FlagBox1.Size = new System.Drawing.Size(137, 19);
            this.FlagBox1.TabIndex = 0;
            this.FlagBox1.Text = "Event can not repeat";
            this.FlagBox1.UseVisualStyleBackColor = true;
            // 
            // FlagBox2
            // 
            this.FlagBox2.AutoSize = true;
            this.FlagBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagBox2.Location = new System.Drawing.Point(9, 32);
            this.FlagBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlagBox2.Name = "FlagBox2";
            this.FlagBox2.Size = new System.Drawing.Size(227, 19);
            this.FlagBox2.TabIndex = 1;
            this.FlagBox2.Text = "Event only occurs in normal dungeon";
            this.FlagBox2.UseVisualStyleBackColor = true;
            // 
            // FlagBox4
            // 
            this.FlagBox4.AutoSize = true;
            this.FlagBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagBox4.Location = new System.Drawing.Point(9, 54);
            this.FlagBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlagBox4.Name = "FlagBox4";
            this.FlagBox4.Size = new System.Drawing.Size(222, 19);
            this.FlagBox4.TabIndex = 2;
            this.FlagBox4.Text = "Event only occurs in heroic dungeon";
            this.FlagBox4.UseVisualStyleBackColor = true;
            // 
            // FlagBox8
            // 
            this.FlagBox8.AutoSize = true;
            this.FlagBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagBox8.Location = new System.Drawing.Point(9, 76);
            this.FlagBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlagBox8.Name = "FlagBox8";
            this.FlagBox8.Size = new System.Drawing.Size(199, 19);
            this.FlagBox8.TabIndex = 3;
            this.FlagBox8.Text = "Event only occurs in normal raid";
            this.FlagBox8.UseVisualStyleBackColor = true;
            // 
            // FlagBox16
            // 
            this.FlagBox16.AutoSize = true;
            this.FlagBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagBox16.Location = new System.Drawing.Point(9, 98);
            this.FlagBox16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlagBox16.Name = "FlagBox16";
            this.FlagBox16.Size = new System.Drawing.Size(194, 19);
            this.FlagBox16.TabIndex = 4;
            this.FlagBox16.Text = "Event only occurs in heroic raid";
            this.FlagBox16.UseVisualStyleBackColor = true;
            // 
            // FlagBox128
            // 
            this.FlagBox128.AutoSize = true;
            this.FlagBox128.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FlagBox128.Location = new System.Drawing.Point(9, 119);
            this.FlagBox128.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FlagBox128.Name = "FlagBox128";
            this.FlagBox128.Size = new System.Drawing.Size(201, 19);
            this.FlagBox128.TabIndex = 5;
            this.FlagBox128.Text = "Event only occurs in debug build";
            this.FlagBox128.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelButton.Location = new System.Drawing.Point(175, 151);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 23);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OkButton.Location = new System.Drawing.Point(115, 151);
            this.OkButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(56, 23);
            this.OkButton.TabIndex = 7;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // EventFlags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 184);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FlagBox128);
            this.Controls.Add(this.FlagBox16);
            this.Controls.Add(this.FlagBox8);
            this.Controls.Add(this.FlagBox4);
            this.Controls.Add(this.FlagBox2);
            this.Controls.Add(this.FlagBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventFlags";
            this.ShowIcon = false;
            this.Text = "EventFlags";
            this.Load += new System.EventHandler(this.EventFlags_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FlagBox1;
        private System.Windows.Forms.CheckBox FlagBox2;
        private System.Windows.Forms.CheckBox FlagBox4;
        private System.Windows.Forms.CheckBox FlagBox8;
        private System.Windows.Forms.CheckBox FlagBox16;
        private System.Windows.Forms.CheckBox FlagBox128;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}