namespace BD.Manager
{
    partial class ManagerActivityFinishForm
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
            this.requestLabel = new System.Windows.Forms.Label();
            this.activityIdLabel = new System.Windows.Forms.Label();
            this.activityIdText = new System.Windows.Forms.Label();
            this.activityDescriptionLabel = new System.Windows.Forms.Label();
            this.activityDescriptionText = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.objectTypeLabel = new System.Windows.Forms.Label();
            this.groupBoxActivityDescription = new System.Windows.Forms.GroupBox();
            this.workerIDText = new System.Windows.Forms.Label();
            this.workerIDLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.objectTypeText = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBoxActivityDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Location = new System.Drawing.Point(142, 28);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(181, 13);
            this.requestLabel.TabIndex = 0;
            this.requestLabel.Text = "Kończenie czynności A zgłoszenia B";
            this.requestLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // activityIdLabel
            // 
            this.activityIdLabel.AutoSize = true;
            this.activityIdLabel.Location = new System.Drawing.Point(24, 19);
            this.activityIdLabel.Name = "activityIdLabel";
            this.activityIdLabel.Size = new System.Drawing.Size(18, 13);
            this.activityIdLabel.TabIndex = 1;
            this.activityIdLabel.Text = "ID";
            // 
            // activityIdText
            // 
            this.activityIdText.Location = new System.Drawing.Point(139, 19);
            this.activityIdText.Name = "activityIdText";
            this.activityIdText.Size = new System.Drawing.Size(35, 20);
            this.activityIdText.TabIndex = 2;
            this.activityIdText.Text = "label3";
            // 
            // activityDescriptionLabel
            // 
            this.activityDescriptionLabel.AutoSize = true;
            this.activityDescriptionLabel.Location = new System.Drawing.Point(24, 62);
            this.activityDescriptionLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.activityDescriptionLabel.Name = "activityDescriptionLabel";
            this.activityDescriptionLabel.Size = new System.Drawing.Size(79, 13);
            this.activityDescriptionLabel.TabIndex = 3;
            this.activityDescriptionLabel.Text = "Opis Czynności";
            // 
            // activityDescriptionText
            // 
            this.activityDescriptionText.Location = new System.Drawing.Point(139, 62);
            this.activityDescriptionText.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.activityDescriptionText.Name = "activityDescriptionText";
            this.activityDescriptionText.Size = new System.Drawing.Size(35, 20);
            this.activityDescriptionText.TabIndex = 4;
            this.activityDescriptionText.Text = "label5";
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
            // objectTypeLabel
            // 
            this.objectTypeLabel.Location = new System.Drawing.Point(24, 148);
            this.objectTypeLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.objectTypeLabel.Name = "objectTypeLabel";
            this.objectTypeLabel.Size = new System.Drawing.Size(78, 20);
            this.objectTypeLabel.TabIndex = 7;
            this.objectTypeLabel.Text = "Typ obiektu";
            // 
            // groupBoxActivityDescription
            // 
            this.groupBoxActivityDescription.Controls.Add(this.workerIDText);
            this.groupBoxActivityDescription.Controls.Add(this.workerIDLabel);
            this.groupBoxActivityDescription.Controls.Add(this.statusTextBox);
            this.groupBoxActivityDescription.Controls.Add(this.statusLabel);
            this.groupBoxActivityDescription.Controls.Add(this.objectTypeText);
            this.groupBoxActivityDescription.Controls.Add(this.resultLabel);
            this.groupBoxActivityDescription.Controls.Add(this.objectTypeLabel);
            this.groupBoxActivityDescription.Controls.Add(this.activityIdLabel);
            this.groupBoxActivityDescription.Controls.Add(this.resultTextBox);
            this.groupBoxActivityDescription.Controls.Add(this.activityIdText);
            this.groupBoxActivityDescription.Controls.Add(this.activityDescriptionText);
            this.groupBoxActivityDescription.Controls.Add(this.activityDescriptionLabel);
            this.groupBoxActivityDescription.Location = new System.Drawing.Point(92, 61);
            this.groupBoxActivityDescription.Name = "groupBoxActivityDescription";
            this.groupBoxActivityDescription.Size = new System.Drawing.Size(283, 255);
            this.groupBoxActivityDescription.TabIndex = 8;
            this.groupBoxActivityDescription.TabStop = false;
            this.groupBoxActivityDescription.Text = "groupBox1";
            // 
            // workerIDText
            // 
            this.workerIDText.AutoSize = true;
            this.workerIDText.Location = new System.Drawing.Point(136, 222);
            this.workerIDText.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.workerIDText.Name = "workerIDText";
            this.workerIDText.Size = new System.Drawing.Size(35, 13);
            this.workerIDText.TabIndex = 12;
            this.workerIDText.Text = "label1";
            // 
            // workerIDLabel
            // 
            this.workerIDLabel.AutoSize = true;
            this.workerIDLabel.Location = new System.Drawing.Point(24, 222);
            this.workerIDLabel.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.workerIDLabel.Name = "workerIDLabel";
            this.workerIDLabel.Size = new System.Drawing.Size(57, 13);
            this.workerIDLabel.TabIndex = 11;
            this.workerIDLabel.Text = "Pracownik";
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
            // objectTypeText
            // 
            this.objectTypeText.Location = new System.Drawing.Point(139, 148);
            this.objectTypeText.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.objectTypeText.Name = "objectTypeText";
            this.objectTypeText.Size = new System.Drawing.Size(35, 20);
            this.objectTypeText.TabIndex = 8;
            this.objectTypeText.Text = "label9";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(508, 135);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 11;
            this.finishButton.Text = "Zakończ";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(508, 221);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // ManagerActivityFinishForm
            // 
            this.ClientSize = new System.Drawing.Size(714, 368);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.groupBoxActivityDescription);
            this.Controls.Add(this.requestLabel);
            this.Name = "ManagerActivityFinishForm";
            this.groupBoxActivityDescription.ResumeLayout(false);
            this.groupBoxActivityDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label activityIdLabel;
        private System.Windows.Forms.Label activityIdText;
        private System.Windows.Forms.Label activityDescriptionLabel;
        private System.Windows.Forms.Label activityDescriptionText;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label objectTypeLabel;
        private System.Windows.Forms.GroupBox groupBoxActivityDescription;
        private System.Windows.Forms.Label objectTypeText;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label workerIDText;
        private System.Windows.Forms.Label workerIDLabel;
    }
}