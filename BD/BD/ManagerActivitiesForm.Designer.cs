namespace BD
{
    partial class ManagerActivitiesForm
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
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.activitiesListLabel = new System.Windows.Forms.Label();
            this.closeActivityButton = new System.Windows.Forms.Button();
            this.cancelActivityButton = new System.Windows.Forms.Button();
            this.attachWorkerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Location = new System.Drawing.Point(344, 48);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.Size = new System.Drawing.Size(240, 309);
            this.activitiesDataGridView.TabIndex = 0;
            this.activitiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activitiesDataGridView_CellContentClick);
            // 
            // activitiesListLabel
            // 
            this.activitiesListLabel.AutoSize = true;
            this.activitiesListLabel.Location = new System.Drawing.Point(430, 18);
            this.activitiesListLabel.Name = "activitiesListLabel";
            this.activitiesListLabel.Size = new System.Drawing.Size(79, 13);
            this.activitiesListLabel.TabIndex = 1;
            this.activitiesListLabel.Text = "Lista czynności";
            // 
            // closeActivityButton
            // 
            this.closeActivityButton.Location = new System.Drawing.Point(102, 68);
            this.closeActivityButton.Name = "closeActivityButton";
            this.closeActivityButton.Size = new System.Drawing.Size(128, 23);
            this.closeActivityButton.TabIndex = 2;
            this.closeActivityButton.Text = "Zamknij";
            this.closeActivityButton.UseVisualStyleBackColor = true;
            this.closeActivityButton.Click += new System.EventHandler(this.closeActivityButton_Click);
            // 
            // cancelActivityButton
            // 
            this.cancelActivityButton.Location = new System.Drawing.Point(102, 130);
            this.cancelActivityButton.Name = "cancelActivityButton";
            this.cancelActivityButton.Size = new System.Drawing.Size(128, 23);
            this.cancelActivityButton.TabIndex = 3;
            this.cancelActivityButton.Text = "Anuluj";
            this.cancelActivityButton.UseVisualStyleBackColor = true;
            this.cancelActivityButton.Click += new System.EventHandler(this.cancelActivityButton_Click);
            // 
            // attachWorkerButton
            // 
            this.attachWorkerButton.Location = new System.Drawing.Point(102, 189);
            this.attachWorkerButton.Name = "attachWorkerButton";
            this.attachWorkerButton.Size = new System.Drawing.Size(128, 23);
            this.attachWorkerButton.TabIndex = 4;
            this.attachWorkerButton.Text = "Przydziel wykonawcę";
            this.attachWorkerButton.UseVisualStyleBackColor = true;
            this.attachWorkerButton.Click += new System.EventHandler(this.attachWorkerButton_Click);
            // 
            // ManagerActivitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 369);
            this.Controls.Add(this.attachWorkerButton);
            this.Controls.Add(this.cancelActivityButton);
            this.Controls.Add(this.closeActivityButton);
            this.Controls.Add(this.activitiesListLabel);
            this.Controls.Add(this.activitiesDataGridView);
            this.Name = "ManagerActivitiesForm";
            this.Text = "ManagerActivitiesForm";
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.Label activitiesListLabel;
        private System.Windows.Forms.Button closeActivityButton;
        private System.Windows.Forms.Button cancelActivityButton;
        private System.Windows.Forms.Button attachWorkerButton;
    }
}