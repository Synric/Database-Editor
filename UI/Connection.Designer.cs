namespace DatabaseEditor
{
    partial class Connection
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
            this.ConnectButton = new System.Windows.Forms.Button();
            this.PortBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.StorePassBox = new System.Windows.Forms.CheckBox();
            this.IPBox = new System.Windows.Forms.ComboBox();
            this.CharBox = new System.Windows.Forms.ComboBox();
            this.WorldBox = new System.Windows.Forms.ComboBox();
            this.AuthBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(300, 131);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // PortBox
            // 
            this.PortBox.Location = new System.Drawing.Point(259, 17);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(116, 20);
            this.PortBox.TabIndex = 4;
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(61, 46);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(100, 20);
            this.UserBox.TabIndex = 1;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(61, 75);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '-';
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 2;
            // 
            // StorePassBox
            // 
            this.StorePassBox.AutoSize = true;
            this.StorePassBox.Location = new System.Drawing.Point(61, 103);
            this.StorePassBox.Name = "StorePassBox";
            this.StorePassBox.Size = new System.Drawing.Size(100, 17);
            this.StorePassBox.TabIndex = 3;
            this.StorePassBox.Text = "Store Password";
            this.StorePassBox.UseVisualStyleBackColor = true;
            // 
            // IPBox
            // 
            this.IPBox.FormattingEnabled = true;
            this.IPBox.Location = new System.Drawing.Point(61, 16);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 21);
            this.IPBox.TabIndex = 0;
            // 
            // CharBox
            // 
            this.CharBox.FormattingEnabled = true;
            this.CharBox.Location = new System.Drawing.Point(259, 45);
            this.CharBox.Name = "CharBox";
            this.CharBox.Size = new System.Drawing.Size(116, 21);
            this.CharBox.TabIndex = 5;
            // 
            // WorldBox
            // 
            this.WorldBox.FormattingEnabled = true;
            this.WorldBox.Location = new System.Drawing.Point(259, 75);
            this.WorldBox.Name = "WorldBox";
            this.WorldBox.Size = new System.Drawing.Size(116, 21);
            this.WorldBox.TabIndex = 6;
            // 
            // AuthBox
            // 
            this.AuthBox.FormattingEnabled = true;
            this.AuthBox.Location = new System.Drawing.Point(259, 104);
            this.AuthBox.Name = "AuthBox";
            this.AuthBox.Size = new System.Drawing.Size(116, 21);
            this.AuthBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Pass:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Char DB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "World DB:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Auth DB:";
            // 
            // Connection
            // 
            this.AcceptButton = this.ConnectButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 170);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AuthBox);
            this.Controls.Add(this.WorldBox);
            this.Controls.Add(this.CharBox);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.StorePassBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.PortBox);
            this.Controls.Add(this.ConnectButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(414, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(414, 209);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL - Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox PortBox;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.CheckBox StorePassBox;
        private System.Windows.Forms.ComboBox IPBox;
        private System.Windows.Forms.ComboBox CharBox;
        private System.Windows.Forms.ComboBox WorldBox;
        private System.Windows.Forms.ComboBox AuthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}