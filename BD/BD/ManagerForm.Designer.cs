namespace BD
{
    partial class ManagerForm
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
            this.clientsDataButton = new System.Windows.Forms.Button();
            this.objectsDataButton = new System.Windows.Forms.Button();
            this.requestsButton = new System.Windows.Forms.Button();
            this.activitiesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientsDataButton
            // 
            this.clientsDataButton.Location = new System.Drawing.Point(90, 66);
            this.clientsDataButton.Name = "clientsDataButton";
            this.clientsDataButton.Size = new System.Drawing.Size(114, 23);
            this.clientsDataButton.TabIndex = 0;
            this.clientsDataButton.Text = "Baza klientów";
            this.clientsDataButton.UseVisualStyleBackColor = true;
            this.clientsDataButton.Click += new System.EventHandler(this.clientsDataButton_Click);
            // 
            // objectsDataButton
            // 
            this.objectsDataButton.Location = new System.Drawing.Point(90, 124);
            this.objectsDataButton.Name = "objectsDataButton";
            this.objectsDataButton.Size = new System.Drawing.Size(114, 23);
            this.objectsDataButton.TabIndex = 1;
            this.objectsDataButton.Text = "Baza obiektów";
            this.objectsDataButton.UseVisualStyleBackColor = true;
            this.objectsDataButton.Click += new System.EventHandler(this.objectsDataButton_Click);
            // 
            // requestsButton
            // 
            this.requestsButton.Location = new System.Drawing.Point(90, 183);
            this.requestsButton.Name = "requestsButton";
            this.requestsButton.Size = new System.Drawing.Size(114, 23);
            this.requestsButton.TabIndex = 2;
            this.requestsButton.Text = "Zgłoszenia";
            this.requestsButton.UseVisualStyleBackColor = true;
            this.requestsButton.Click += new System.EventHandler(this.requestsButton_Click);
            // 
            // activitiesButton
            // 
            this.activitiesButton.Location = new System.Drawing.Point(90, 246);
            this.activitiesButton.Name = "activitiesButton";
            this.activitiesButton.Size = new System.Drawing.Size(114, 23);
            this.activitiesButton.TabIndex = 3;
            this.activitiesButton.Text = "Czynności";
            this.activitiesButton.UseVisualStyleBackColor = true;
            this.activitiesButton.Click += new System.EventHandler(this.activitiesButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 370);
            this.Controls.Add(this.activitiesButton);
            this.Controls.Add(this.requestsButton);
            this.Controls.Add(this.objectsDataButton);
            this.Controls.Add(this.clientsDataButton);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clientsDataButton;
        private System.Windows.Forms.Button objectsDataButton;
        private System.Windows.Forms.Button requestsButton;
        private System.Windows.Forms.Button activitiesButton;
    }
}