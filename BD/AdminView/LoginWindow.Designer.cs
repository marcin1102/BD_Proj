namespace AdminView
{
    partial class LoginWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uNameTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uNameTB
            // 
            this.uNameTB.Location = new System.Drawing.Point(80, 65);
            this.uNameTB.Name = "uNameTB";
            this.uNameTB.Size = new System.Drawing.Size(123, 20);
            this.uNameTB.TabIndex = 0;
            this.uNameTB.Text = "Login";
            this.uNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(80, 107);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(123, 20);
            this.passTB.TabIndex = 1;
            this.passTB.Text = "Password";
            this.passTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(80, 158);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(123, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.uNameTB);
            this.Name = "LoginWindow";
            this.Size = new System.Drawing.Size(281, 242);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uNameTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button loginButton;
    }
}
