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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(323, 31);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(99, 23);
            this.addUserButton.TabIndex = 0;
            this.addUserButton.Text = "Dodaj";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(323, 89);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(99, 23);
            this.deleteUserButton.TabIndex = 1;
            this.deleteUserButton.Text = "Usuń";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.Location = new System.Drawing.Point(323, 60);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(99, 23);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Edytuj";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(6, 19);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(244, 162);
            this.usersDataGridView.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usersDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Użytkowników";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 211);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}