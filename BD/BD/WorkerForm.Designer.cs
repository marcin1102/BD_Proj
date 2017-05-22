namespace BD
{
    partial class WorkerForm
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
            this.activitiesListLabel = new System.Windows.Forms.Label();
            this.activitiesListInProgressLabel = new System.Windows.Forms.Label();
            this.activitiesInProgressDataGridView = new System.Windows.Forms.DataGridView();
            this.allActivitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.cancelActivityButton = new System.Windows.Forms.Button();
            this.executeActivityButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesInProgressDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allActivitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activitiesListLabel
            // 
            this.activitiesListLabel.AutoSize = true;
            this.activitiesListLabel.Location = new System.Drawing.Point(108, 50);
            this.activitiesListLabel.Name = "activitiesListLabel";
            this.activitiesListLabel.Size = new System.Drawing.Size(79, 13);
            this.activitiesListLabel.TabIndex = 0;
            this.activitiesListLabel.Text = "Lista czynności";
            // 
            // activitiesListInProgressLabel
            // 
            this.activitiesListInProgressLabel.AutoSize = true;
            this.activitiesListInProgressLabel.Location = new System.Drawing.Point(358, 50);
            this.activitiesListInProgressLabel.Name = "activitiesListInProgressLabel";
            this.activitiesListInProgressLabel.Size = new System.Drawing.Size(162, 13);
            this.activitiesListInProgressLabel.TabIndex = 1;
            this.activitiesListInProgressLabel.Text = "Lista czynności w trakcie trwania";
            // 
            // activitiesInProgressDataGridView
            // 
            this.activitiesInProgressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesInProgressDataGridView.Location = new System.Drawing.Point(318, 92);
            this.activitiesInProgressDataGridView.Name = "activitiesInProgressDataGridView";
            this.activitiesInProgressDataGridView.Size = new System.Drawing.Size(240, 219);
            this.activitiesInProgressDataGridView.TabIndex = 2;
            // 
            // allActivitiesDataGridView
            // 
            this.allActivitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allActivitiesDataGridView.Location = new System.Drawing.Point(28, 92);
            this.allActivitiesDataGridView.Name = "allActivitiesDataGridView";
            this.allActivitiesDataGridView.Size = new System.Drawing.Size(240, 219);
            this.allActivitiesDataGridView.TabIndex = 3;
            // 
            // cancelActivityButton
            // 
            this.cancelActivityButton.Location = new System.Drawing.Point(402, 330);
            this.cancelActivityButton.Name = "cancelActivityButton";
            this.cancelActivityButton.Size = new System.Drawing.Size(75, 23);
            this.cancelActivityButton.TabIndex = 4;
            this.cancelActivityButton.Text = "Anuluj czynność";
            this.cancelActivityButton.UseVisualStyleBackColor = true;
            this.cancelActivityButton.Click += new System.EventHandler(this.cancelActivityButton_Click);
            // 
            // executeActivityButton
            // 
            this.executeActivityButton.Location = new System.Drawing.Point(112, 330);
            this.executeActivityButton.Name = "executeActivityButton";
            this.executeActivityButton.Size = new System.Drawing.Size(75, 23);
            this.executeActivityButton.TabIndex = 5;
            this.executeActivityButton.Text = "Realizuj czynność";
            this.executeActivityButton.UseVisualStyleBackColor = true;
            this.executeActivityButton.Click += new System.EventHandler(this.executeActivityButton_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 365);
            this.Controls.Add(this.executeActivityButton);
            this.Controls.Add(this.cancelActivityButton);
            this.Controls.Add(this.allActivitiesDataGridView);
            this.Controls.Add(this.activitiesInProgressDataGridView);
            this.Controls.Add(this.activitiesListInProgressLabel);
            this.Controls.Add(this.activitiesListLabel);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.activitiesInProgressDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allActivitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activitiesListLabel;
        private System.Windows.Forms.Label activitiesListInProgressLabel;
        private System.Windows.Forms.DataGridView activitiesInProgressDataGridView;
        private System.Windows.Forms.DataGridView allActivitiesDataGridView;
        private System.Windows.Forms.Button cancelActivityButton;
        private System.Windows.Forms.Button executeActivityButton;
    }
}