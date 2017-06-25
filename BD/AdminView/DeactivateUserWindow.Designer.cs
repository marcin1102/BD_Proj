namespace AdminView
{
    partial class DeactivateUserWindow
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
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.expirationDP = new System.Windows.Forms.DateTimePicker();
            this.setExpirationBT = new System.Windows.Forms.Button();
            this.returnBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(126, 72);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(121, 20);
            this.lastNameTB.TabIndex = 4;
            this.lastNameTB.Text = "Last Name";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(3, 72);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(121, 20);
            this.firstNameTB.TabIndex = 3;
            this.firstNameTB.Text = "First Name";
            // 
            // expirationDP
            // 
            this.expirationDP.Location = new System.Drawing.Point(25, 112);
            this.expirationDP.Name = "expirationDP";
            this.expirationDP.Size = new System.Drawing.Size(200, 20);
            this.expirationDP.TabIndex = 5;
            // 
            // setExpirationBT
            // 
            this.setExpirationBT.Location = new System.Drawing.Point(25, 170);
            this.setExpirationBT.Name = "setExpirationBT";
            this.setExpirationBT.Size = new System.Drawing.Size(200, 23);
            this.setExpirationBT.TabIndex = 6;
            this.setExpirationBT.Text = "Set Expiration Date and return";
            this.setExpirationBT.UseVisualStyleBackColor = true;
            this.setExpirationBT.Click += new System.EventHandler(this.setExpirationBT_Click);
            // 
            // returnBT
            // 
            this.returnBT.Location = new System.Drawing.Point(58, 199);
            this.returnBT.Name = "returnBT";
            this.returnBT.Size = new System.Drawing.Size(121, 23);
            this.returnBT.TabIndex = 11;
            this.returnBT.Text = "Return";
            this.returnBT.UseVisualStyleBackColor = true;
            this.returnBT.Click += new System.EventHandler(this.returnBT_Click);
            // 
            // DeactivateUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnBT);
            this.Controls.Add(this.setExpirationBT);
            this.Controls.Add(this.expirationDP);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Name = "DeactivateUserWindow";
            this.Size = new System.Drawing.Size(250, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.DateTimePicker expirationDP;
        private System.Windows.Forms.Button setExpirationBT;
        private System.Windows.Forms.Button returnBT;
    }
}
