namespace AdminView
{
    partial class AddUserWindow
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
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.createUserBT = new System.Windows.Forms.Button();
            this.returnBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roleCB
            // 
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Location = new System.Drawing.Point(64, 103);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(121, 21);
            this.roleCB.TabIndex = 0;
            this.roleCB.Text = "Choose role";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(64, 51);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(121, 20);
            this.firstNameTB.TabIndex = 1;
            this.firstNameTB.Text = "First Name";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(64, 77);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(121, 20);
            this.lastNameTB.TabIndex = 2;
            this.lastNameTB.Text = "Last Name";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(64, 130);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(121, 20);
            this.loginTB.TabIndex = 3;
            this.loginTB.Text = "Login";
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(64, 156);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(121, 20);
            this.passTB.TabIndex = 4;
            this.passTB.Text = "Password";
            // 
            // createUserBT
            // 
            this.createUserBT.Location = new System.Drawing.Point(64, 182);
            this.createUserBT.Name = "createUserBT";
            this.createUserBT.Size = new System.Drawing.Size(121, 23);
            this.createUserBT.TabIndex = 5;
            this.createUserBT.Text = "Create User";
            this.createUserBT.UseVisualStyleBackColor = true;
            this.createUserBT.Click += new System.EventHandler(this.createUserBT_Click);
            // 
            // returnBT
            // 
            this.returnBT.Location = new System.Drawing.Point(64, 211);
            this.returnBT.Name = "returnBT";
            this.returnBT.Size = new System.Drawing.Size(121, 23);
            this.returnBT.TabIndex = 11;
            this.returnBT.Text = "Return";
            this.returnBT.UseVisualStyleBackColor = true;
            this.returnBT.Click += new System.EventHandler(this.returnBT_Click);
            // 
            // AddUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnBT);
            this.Controls.Add(this.createUserBT);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.roleCB);
            this.Name = "AddUserWindow";
            this.Size = new System.Drawing.Size(250, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button createUserBT;
        private System.Windows.Forms.Button returnBT;
    }
}
