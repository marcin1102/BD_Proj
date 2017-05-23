namespace BD
{
    partial class ManagerRequestsForm
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
            this.requestsDataGridView = new System.Windows.Forms.DataGridView();
            this.requestsListLabel = new System.Windows.Forms.Label();
            this.registerRequestButton = new System.Windows.Forms.Button();
            this.cancelRequestButton = new System.Windows.Forms.Button();
            this.closeRequestButton = new System.Windows.Forms.Button();
            this.createActivityButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // requestsDataGridView
            // 
            this.requestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsDataGridView.Location = new System.Drawing.Point(305, 51);
            this.requestsDataGridView.Name = "requestsDataGridView";
            this.requestsDataGridView.Size = new System.Drawing.Size(240, 311);
            this.requestsDataGridView.TabIndex = 0;
            this.requestsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestsDataGridView_CellContentClick);
            // 
            // requestsListLabel
            // 
            this.requestsListLabel.AutoSize = true;
            this.requestsListLabel.Location = new System.Drawing.Point(387, 18);
            this.requestsListLabel.Name = "requestsListLabel";
            this.requestsListLabel.Size = new System.Drawing.Size(75, 13);
            this.requestsListLabel.TabIndex = 1;
            this.requestsListLabel.Text = "Lista zgłoszeń";
            // 
            // registerRequestButton
            // 
            this.registerRequestButton.Location = new System.Drawing.Point(58, 74);
            this.registerRequestButton.Name = "registerRequestButton";
            this.registerRequestButton.Size = new System.Drawing.Size(129, 23);
            this.registerRequestButton.TabIndex = 2;
            this.registerRequestButton.Text = "Rejestruj zgłoszenie";
            this.registerRequestButton.UseVisualStyleBackColor = true;
            this.registerRequestButton.Click += new System.EventHandler(this.registerRequestButton_Click);
            // 
            // cancelRequestButton
            // 
            this.cancelRequestButton.Location = new System.Drawing.Point(58, 142);
            this.cancelRequestButton.Name = "cancelRequestButton";
            this.cancelRequestButton.Size = new System.Drawing.Size(129, 23);
            this.cancelRequestButton.TabIndex = 3;
            this.cancelRequestButton.Text = "Anuluj zgłoszenie";
            this.cancelRequestButton.UseVisualStyleBackColor = true;
            this.cancelRequestButton.Click += new System.EventHandler(this.cancelRequestButton_Click);
            // 
            // closeRequestButton
            // 
            this.closeRequestButton.Location = new System.Drawing.Point(58, 214);
            this.closeRequestButton.Name = "closeRequestButton";
            this.closeRequestButton.Size = new System.Drawing.Size(129, 23);
            this.closeRequestButton.TabIndex = 4;
            this.closeRequestButton.Text = "Zamknij zgłoszenie";
            this.closeRequestButton.UseVisualStyleBackColor = true;
            this.closeRequestButton.Click += new System.EventHandler(this.closeRequestButton_Click);
            // 
            // createActivityButton
            // 
            this.createActivityButton.Location = new System.Drawing.Point(58, 285);
            this.createActivityButton.Name = "createActivityButton";
            this.createActivityButton.Size = new System.Drawing.Size(129, 23);
            this.createActivityButton.TabIndex = 5;
            this.createActivityButton.Text = "Stwórz czynność";
            this.createActivityButton.UseVisualStyleBackColor = true;
            this.createActivityButton.Click += new System.EventHandler(this.createActivityButton_Click);
            // 
            // ManagerRequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 374);
            this.Controls.Add(this.createActivityButton);
            this.Controls.Add(this.closeRequestButton);
            this.Controls.Add(this.cancelRequestButton);
            this.Controls.Add(this.registerRequestButton);
            this.Controls.Add(this.requestsListLabel);
            this.Controls.Add(this.requestsDataGridView);
            this.Name = "ManagerRequestsForm";
            this.Text = "ManagerRequestsForm";
            ((System.ComponentModel.ISupportInitialize)(this.requestsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requestsDataGridView;
        private System.Windows.Forms.Label requestsListLabel;
        private System.Windows.Forms.Button registerRequestButton;
        private System.Windows.Forms.Button cancelRequestButton;
        private System.Windows.Forms.Button closeRequestButton;
        private System.Windows.Forms.Button createActivityButton;
    }
}