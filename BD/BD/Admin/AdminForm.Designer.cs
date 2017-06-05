namespace BD
{
    partial class AdminForm
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.setUserRoleButton = new System.Windows.Forms.Button();
            this.usersRoleComboBox = new System.Windows.Forms.ComboBox();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.usersListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(58, 51);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(99, 23);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Dodaj";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(58, 104);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(99, 23);
            this.deleteUserButton.TabIndex = 1;
            this.deleteUserButton.Text = "Usuń";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(58, 158);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(99, 23);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Edytuj";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // setUserRoleButton
            // 
            this.setUserRoleButton.Location = new System.Drawing.Point(58, 212);
            this.setUserRoleButton.Name = "setUserRoleButton";
            this.setUserRoleButton.Size = new System.Drawing.Size(99, 23);
            this.setUserRoleButton.TabIndex = 3;
            this.setUserRoleButton.Text = "Przydziel rolę";
            this.setUserRoleButton.UseVisualStyleBackColor = true;
            this.setUserRoleButton.Click += new System.EventHandler(this.setUserRoleButton_Click);
            // 
            // usersRoleComboBox
            // 
            this.usersRoleComboBox.FormattingEnabled = true;
            this.usersRoleComboBox.Location = new System.Drawing.Point(58, 252);
            this.usersRoleComboBox.Name = "usersRoleComboBox";
            this.usersRoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.usersRoleComboBox.TabIndex = 4;
            this.usersRoleComboBox.SelectedIndexChanged += new System.EventHandler(this.usersRoleComboBox_SelectedIndexChanged);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(246, 51);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(240, 276);
            this.usersDataGridView.TabIndex = 5;
            // 
            // usersListLabel
            // 
            this.usersListLabel.AutoSize = true;
            this.usersListLabel.Location = new System.Drawing.Point(311, 20);
            this.usersListLabel.Name = "usersListLabel";
            this.usersListLabel.Size = new System.Drawing.Size(99, 13);
            this.usersListLabel.TabIndex = 6;
            this.usersListLabel.Text = "Lista użytkowników";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 367);
            this.Controls.Add(this.usersListLabel);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.usersRoleComboBox);
            this.Controls.Add(this.setUserRoleButton);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button setUserRoleButton;
        private System.Windows.Forms.ComboBox usersRoleComboBox;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Label usersListLabel;
    }
}