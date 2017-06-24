namespace BD
{
    partial class WorkerActivityCancelForm
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
            this.activityLabel = new System.Windows.Forms.Label();
            this.requestIdLabel = new System.Windows.Forms.Label();
            this.requestIdText = new System.Windows.Forms.Label();
            this.requestDescriptionLabel = new System.Windows.Forms.Label();
            this.requestDescriptionText = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.activityDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBoxActivityDescription = new System.Windows.Forms.GroupBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.activityDescriptionText = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBoxActivityDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Location = new System.Drawing.Point(205, 26);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(122, 13);
            this.activityLabel.TabIndex = 0;
            this.activityLabel.Text = "Anulowanie czynności A";
            this.activityLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // requestIdLabel
            // 
            this.requestIdLabel.AutoSize = true;
            this.requestIdLabel.Location = new System.Drawing.Point(24, 19);
            this.requestIdLabel.Name = "requestIdLabel";
            this.requestIdLabel.Size = new System.Drawing.Size(18, 13);
            this.requestIdLabel.TabIndex = 1;
            this.requestIdLabel.Text = "ID";
            // 
            // requestIdText
            // 
            this.requestIdText.Location = new System.Drawing.Point(139, 19);
            this.requestIdText.Name = "requestIdText";
            this.requestIdText.Size = new System.Drawing.Size(35, 20);
            this.requestIdText.TabIndex = 2;
            this.requestIdText.Text = "label3";
            // 
            // requestDescriptionLabel
            // 
            this.requestDescriptionLabel.AutoSize = true;
            this.requestDescriptionLabel.Location = new System.Drawing.Point(24, 62);
            this.requestDescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.requestDescriptionLabel.Name = "requestDescriptionLabel";
            this.requestDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.requestDescriptionLabel.TabIndex = 3;
            this.requestDescriptionLabel.Text = "Opis Zgłoszenia";
            // 
            // requestDescriptionText
            // 
            this.requestDescriptionText.Location = new System.Drawing.Point(139, 62);
            this.requestDescriptionText.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.requestDescriptionText.Name = "requestDescriptionText";
            this.requestDescriptionText.Size = new System.Drawing.Size(35, 20);
            this.requestDescriptionText.TabIndex = 4;
            this.requestDescriptionText.Text = "label5";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(24, 105);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "Wynik";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(139, 105);
            this.resultTextBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(35, 20);
            this.resultTextBox.TabIndex = 6;
            this.resultTextBox.Text = "label7";
            // 
            // activityDescriptionLabel
            // 
            this.activityDescriptionLabel.Location = new System.Drawing.Point(24, 148);
            this.activityDescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.activityDescriptionLabel.Name = "activityDescriptionLabel";
            this.activityDescriptionLabel.Size = new System.Drawing.Size(78, 20);
            this.activityDescriptionLabel.TabIndex = 7;
            this.activityDescriptionLabel.Text = "Opis czynności";
            // 
            // groupBoxActivityDescription
            // 
            this.groupBoxActivityDescription.Controls.Add(this.statusTextBox);
            this.groupBoxActivityDescription.Controls.Add(this.statusLabel);
            this.groupBoxActivityDescription.Controls.Add(this.activityDescriptionText);
            this.groupBoxActivityDescription.Controls.Add(this.resultLabel);
            this.groupBoxActivityDescription.Controls.Add(this.activityDescriptionLabel);
            this.groupBoxActivityDescription.Controls.Add(this.requestIdLabel);
            this.groupBoxActivityDescription.Controls.Add(this.resultTextBox);
            this.groupBoxActivityDescription.Controls.Add(this.requestIdText);
            this.groupBoxActivityDescription.Controls.Add(this.requestDescriptionText);
            this.groupBoxActivityDescription.Controls.Add(this.requestDescriptionLabel);
            this.groupBoxActivityDescription.Location = new System.Drawing.Point(92, 61);
            this.groupBoxActivityDescription.Name = "groupBoxActivityDescription";
            this.groupBoxActivityDescription.Size = new System.Drawing.Size(283, 255);
            this.groupBoxActivityDescription.TabIndex = 8;
            this.groupBoxActivityDescription.TabStop = false;
            this.groupBoxActivityDescription.Text = "groupBox1";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(139, 187);
            this.statusTextBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(35, 20);
            this.statusTextBox.TabIndex = 10;
            this.statusTextBox.Text = "label2";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(24, 190);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status";
            // 
            // activityDescriptionText
            // 
            this.activityDescriptionText.Location = new System.Drawing.Point(139, 148);
            this.activityDescriptionText.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.activityDescriptionText.Name = "activityDescriptionText";
            this.activityDescriptionText.Size = new System.Drawing.Size(35, 20);
            this.activityDescriptionText.TabIndex = 8;
            this.activityDescriptionText.Text = "label9";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(508, 135);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(508, 221);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // WorkerActivityCancelForm
            // 
            this.ClientSize = new System.Drawing.Size(714, 368);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBoxActivityDescription);
            this.Controls.Add(this.activityLabel);
            this.Name = "WorkerActivityCancelForm";
            this.groupBoxActivityDescription.ResumeLayout(false);
            this.groupBoxActivityDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label requestIdLabel;
        private System.Windows.Forms.Label requestIdText;
        private System.Windows.Forms.Label requestDescriptionLabel;
        private System.Windows.Forms.Label requestDescriptionText;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label activityDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBoxActivityDescription;
        private System.Windows.Forms.Label activityDescriptionText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button backButton;
    }
}