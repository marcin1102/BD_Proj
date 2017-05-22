namespace BD
{
    partial class LoginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(178, 204);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(78, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButtonClick);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(133, 70);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(39, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Login: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(133, 119);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(42, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Hasło: ";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(178, 70);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(78, 20);
            this.loginTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(178, 119);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(77, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
    }
}