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
            this.registerRequestButton = new System.Windows.Forms.Button();
            this.handleActivityButton = new System.Windows.Forms.Button();
            this.requestDataGridView = new System.Windows.Forms.DataGridView();
            this.requestListLabel = new System.Windows.Forms.Label();
            this.handleRequestButton = new System.Windows.Forms.Button();
            this.activitiesListLabel = new System.Windows.Forms.Label();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registerRequestButton
            // 
            this.registerRequestButton.Location = new System.Drawing.Point(30, 320);
            this.registerRequestButton.Name = "registerRequestButton";
            this.registerRequestButton.Size = new System.Drawing.Size(98, 38);
            this.registerRequestButton.TabIndex = 2;
            this.registerRequestButton.Text = "Rejestruj zgłoszenie";
            this.registerRequestButton.UseVisualStyleBackColor = true;
            this.registerRequestButton.Click += new System.EventHandler(this.requestsButton_Click);
            // 
            // handleActivityButton
            // 
            this.handleActivityButton.Location = new System.Drawing.Point(364, 320);
            this.handleActivityButton.Name = "handleActivityButton";
            this.handleActivityButton.Size = new System.Drawing.Size(114, 40);
            this.handleActivityButton.TabIndex = 3;
            this.handleActivityButton.Text = "Obsłuż czynność";
            this.handleActivityButton.UseVisualStyleBackColor = true;
            this.handleActivityButton.Click += new System.EventHandler(this.activitiesButton_Click);
            // 
            // requestDataGridView
            // 
            this.requestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDataGridView.Location = new System.Drawing.Point(30, 42);
            this.requestDataGridView.Name = "requestDataGridView";
            this.requestDataGridView.Size = new System.Drawing.Size(240, 266);
            this.requestDataGridView.TabIndex = 4;
            // 
            // requestListLabel
            // 
            this.requestListLabel.AutoSize = true;
            this.requestListLabel.Location = new System.Drawing.Point(102, 9);
            this.requestListLabel.Name = "requestListLabel";
            this.requestListLabel.Size = new System.Drawing.Size(75, 13);
            this.requestListLabel.TabIndex = 5;
            this.requestListLabel.Text = "Lista zgłoszeń";
            // 
            // handleRequestButton
            // 
            this.handleRequestButton.Location = new System.Drawing.Point(171, 320);
            this.handleRequestButton.Name = "handleRequestButton";
            this.handleRequestButton.Size = new System.Drawing.Size(99, 40);
            this.handleRequestButton.TabIndex = 6;
            this.handleRequestButton.Text = "Obsłuż zgłoszenie";
            this.handleRequestButton.UseVisualStyleBackColor = true;
            // 
            // activitiesListLabel
            // 
            this.activitiesListLabel.AutoSize = true;
            this.activitiesListLabel.Location = new System.Drawing.Point(372, 9);
            this.activitiesListLabel.Name = "activitiesListLabel";
            this.activitiesListLabel.Size = new System.Drawing.Size(79, 13);
            this.activitiesListLabel.TabIndex = 7;
            this.activitiesListLabel.Text = "Lista czynności";
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Location = new System.Drawing.Point(302, 42);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.Size = new System.Drawing.Size(240, 266);
            this.activitiesDataGridView.TabIndex = 8;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 370);
            this.Controls.Add(this.activitiesDataGridView);
            this.Controls.Add(this.activitiesListLabel);
            this.Controls.Add(this.handleRequestButton);
            this.Controls.Add(this.requestListLabel);
            this.Controls.Add(this.requestDataGridView);
            this.Controls.Add(this.handleActivityButton);
            this.Controls.Add(this.registerRequestButton);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.requestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registerRequestButton;
        private System.Windows.Forms.Button handleActivityButton;
        private System.Windows.Forms.DataGridView requestDataGridView;
        private System.Windows.Forms.Label requestListLabel;
        private System.Windows.Forms.Button handleRequestButton;
        private System.Windows.Forms.Label activitiesListLabel;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
    }
}