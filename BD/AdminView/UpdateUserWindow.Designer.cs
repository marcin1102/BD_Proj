namespace AdminView
{
    partial class UpdateUserWindow
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
            this.passTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.roleCB = new System.Windows.Forms.ComboBox();
            this.updateBT = new System.Windows.Forms.Button();
            this.returnBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(65, 133);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(121, 20);
            this.passTB.TabIndex = 8;
            this.passTB.Text = "Password";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(65, 80);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(121, 20);
            this.lastNameTB.TabIndex = 7;
            this.lastNameTB.Text = "Last Name";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(65, 54);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(121, 20);
            this.firstNameTB.TabIndex = 6;
            this.firstNameTB.Text = "First Name";
            // 
            // roleCB
            // 
            this.roleCB.FormattingEnabled = true;
            this.roleCB.Location = new System.Drawing.Point(65, 106);
            this.roleCB.Name = "roleCB";
            this.roleCB.Size = new System.Drawing.Size(121, 21);
            this.roleCB.TabIndex = 5;
            this.roleCB.Text = "Choose role";
            // 
            // updateBT
            // 
            this.updateBT.Location = new System.Drawing.Point(65, 180);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(121, 23);
            this.updateBT.TabIndex = 9;
            this.updateBT.Text = "Update and return";
            this.updateBT.UseVisualStyleBackColor = true;
            this.updateBT.Click += new System.EventHandler(this.updateBT_Click);
            // 
            // returnBT
            // 
            this.returnBT.Location = new System.Drawing.Point(65, 210);
            this.returnBT.Name = "returnBT";
            this.returnBT.Size = new System.Drawing.Size(121, 23);
            this.returnBT.TabIndex = 10;
            this.returnBT.Text = "Return";
            this.returnBT.UseVisualStyleBackColor = true;
            this.returnBT.Click += new System.EventHandler(this.returnBT_Click);
            // 
            // UpdateUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnBT);
            this.Controls.Add(this.updateBT);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.roleCB);
            this.Name = "UpdateUserWindow";
            this.Size = new System.Drawing.Size(250, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.Button updateBT;
        private System.Windows.Forms.Button returnBT;
    }
}
