namespace BD
{
    partial class Form1
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
            this.addClientButton = new System.Windows.Forms.Button();
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowClients = new System.Windows.Forms.Button();
            this.AddObjectToClient = new System.Windows.Forms.Button();
            this.AddObjectType = new System.Windows.Forms.Button();
            this.ObjectDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowObjects = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(27, 86);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(140, 67);
            this.addClientButton.TabIndex = 0;
            this.addClientButton.Text = "AddClientToDatabase";
            this.addClientButton.UseVisualStyleBackColor = true;
            this.addClientButton.Click += new System.EventHandler(this.addClientButton_Click);
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGridView.Location = new System.Drawing.Point(223, 61);
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.Size = new System.Drawing.Size(240, 150);
            this.ClientDataGridView.TabIndex = 1;
            // 
            // ShowClients
            // 
            this.ShowClients.Location = new System.Drawing.Point(272, 217);
            this.ShowClients.Name = "ShowClients";
            this.ShowClients.Size = new System.Drawing.Size(145, 23);
            this.ShowClients.TabIndex = 2;
            this.ShowClients.Text = "ShowClients";
            this.ShowClients.UseVisualStyleBackColor = true;
            this.ShowClients.Click += new System.EventHandler(this.ShowClients_Click);
            // 
            // AddObjectToClient
            // 
            this.AddObjectToClient.Location = new System.Drawing.Point(27, 188);
            this.AddObjectToClient.Name = "AddObjectToClient";
            this.AddObjectToClient.Size = new System.Drawing.Size(160, 23);
            this.AddObjectToClient.TabIndex = 3;
            this.AddObjectToClient.Text = "AddObjectToClient";
            this.AddObjectToClient.UseVisualStyleBackColor = true;
            this.AddObjectToClient.Click += new System.EventHandler(this.AddObjectToClient_Click);
            // 
            // AddObjectType
            // 
            this.AddObjectType.Location = new System.Drawing.Point(27, 159);
            this.AddObjectType.Name = "AddObjectType";
            this.AddObjectType.Size = new System.Drawing.Size(152, 23);
            this.AddObjectType.TabIndex = 4;
            this.AddObjectType.Text = "AddObjectType";
            this.AddObjectType.UseVisualStyleBackColor = true;
            this.AddObjectType.Click += new System.EventHandler(this.AddObjectType_Click);
            // 
            // ObjectDataGridView
            // 
            this.ObjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectDataGridView.Location = new System.Drawing.Point(530, 61);
            this.ObjectDataGridView.Name = "ObjectDataGridView";
            this.ObjectDataGridView.Size = new System.Drawing.Size(240, 150);
            this.ObjectDataGridView.TabIndex = 5;
            // 
            // ShowObjects
            // 
            this.ShowObjects.Location = new System.Drawing.Point(584, 217);
            this.ShowObjects.Name = "ShowObjects";
            this.ShowObjects.Size = new System.Drawing.Size(149, 23);
            this.ShowObjects.TabIndex = 6;
            this.ShowObjects.Text = "ShowObjects";
            this.ShowObjects.UseVisualStyleBackColor = true;
            this.ShowObjects.Click += new System.EventHandler(this.ShowObjects_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 332);
            this.Controls.Add(this.ShowObjects);
            this.Controls.Add(this.ObjectDataGridView);
            this.Controls.Add(this.AddObjectType);
            this.Controls.Add(this.AddObjectToClient);
            this.Controls.Add(this.ShowClients);
            this.Controls.Add(this.ClientDataGridView);
            this.Controls.Add(this.addClientButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addClientButton;
        private System.Windows.Forms.DataGridView ClientDataGridView;
        private System.Windows.Forms.Button ShowClients;
        private System.Windows.Forms.Button AddObjectToClient;
        private System.Windows.Forms.Button AddObjectType;
        private System.Windows.Forms.DataGridView ObjectDataGridView;
        private System.Windows.Forms.Button ShowObjects;
    }
}

