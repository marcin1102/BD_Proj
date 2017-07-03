namespace AdminView
{
    partial class ManageUsersWindow
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.deactivateUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(69, 48);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(142, 34);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(69, 112);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(142, 34);
            this.updateUserButton.TabIndex = 1;
            this.updateUserButton.Text = "Update User";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // deactivateUserButton
            // 
            this.deactivateUserButton.Location = new System.Drawing.Point(69, 175);
            this.deactivateUserButton.Name = "deactivateUserButton";
            this.deactivateUserButton.Size = new System.Drawing.Size(142, 34);
            this.deactivateUserButton.TabIndex = 2;
            this.deactivateUserButton.Text = "Activate/Deactivate User";
            this.deactivateUserButton.UseVisualStyleBackColor = true;
            this.deactivateUserButton.Click += new System.EventHandler(this.deactivateUserButton_Click);
            // 
            // ManageUsersWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deactivateUserButton);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "ManageUsersWindow";
            this.Size = new System.Drawing.Size(285, 262);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button deactivateUserButton;
    }
}
