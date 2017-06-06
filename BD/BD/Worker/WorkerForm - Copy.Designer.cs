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
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.showActivityButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activitiesListLabel
            // 
            this.activitiesListLabel.AutoSize = true;
            this.activitiesListLabel.Location = new System.Drawing.Point(199, 9);
            this.activitiesListLabel.Name = "activitiesListLabel";
            this.activitiesListLabel.Size = new System.Drawing.Size(79, 13);
            this.activitiesListLabel.TabIndex = 0;
            this.activitiesListLabel.Text = "Lista czynności";
            this.activitiesListLabel.Click += new System.EventHandler(this.activitiesListLabel_Click);
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Location = new System.Drawing.Point(12, 35);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.Size = new System.Drawing.Size(485, 318);
            this.activitiesDataGridView.TabIndex = 3;
            // 
            // showActivityButton
            // 
            this.showActivityButton.Location = new System.Drawing.Point(518, 168);
            this.showActivityButton.Name = "showActivityButton";
            this.showActivityButton.Size = new System.Drawing.Size(85, 46);
            this.showActivityButton.TabIndex = 5;
            this.showActivityButton.Text = "Obsługa czynności";
            this.showActivityButton.UseVisualStyleBackColor = true;
            this.showActivityButton.Click += new System.EventHandler(this.showActivityButton_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 365);
            this.Controls.Add(this.showActivityButton);
            this.Controls.Add(this.activitiesDataGridView);
            this.Controls.Add(this.activitiesListLabel);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activitiesListLabel;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.Button showActivityButton;
    }
}