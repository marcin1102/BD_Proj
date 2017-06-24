namespace BD.Manager
{
    partial class ManagerRequestEditForm
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
            this.requestStatusLabel = new System.Windows.Forms.Label();
            this.requestDescriptionLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.objectTypeLabel = new System.Windows.Forms.Label();
            this.groupBoxActivityDescription = new System.Windows.Forms.GroupBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.workerComboBox = new System.Windows.Forms.ComboBox();
            this.requestDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBOx = new System.Windows.Forms.TextBox();
            this.ObjectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.workerIdLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBoxActivityDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Location = new System.Drawing.Point(205, 26);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(103, 13);
            this.requestLabel.TabIndex = 0;
            this.requestLabel.Text = "Edycja zgłoszenia A";
            this.requestLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // requestStatusLabel
            // 
            this.requestStatusLabel.AutoSize = true;
            this.requestStatusLabel.Location = new System.Drawing.Point(24, 19);
            this.requestStatusLabel.Name = "requestStatusLabel";
            this.requestStatusLabel.Size = new System.Drawing.Size(37, 13);
            this.requestStatusLabel.TabIndex = 1;
            this.requestStatusLabel.Text = "Status";
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
            this.groupBoxActivityDescription.Controls.Add(this.statusTextBox);
            this.groupBoxActivityDescription.Controls.Add(this.workerComboBox);
            this.groupBoxActivityDescription.Controls.Add(this.requestDescriptionTextBox);
            this.groupBoxActivityDescription.Controls.Add(this.resultTextBOx);
            this.groupBoxActivityDescription.Controls.Add(this.ObjectTypeComboBox);
            this.groupBoxActivityDescription.Controls.Add(this.workerIdLabel);
            this.groupBoxActivityDescription.Controls.Add(this.resultLabel);
            this.groupBoxActivityDescription.Controls.Add(this.objectTypeLabel);
            this.groupBoxActivityDescription.Controls.Add(this.requestStatusLabel);
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
            this.statusTextBox.Location = new System.Drawing.Point(142, 19);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(100, 20);
            this.statusTextBox.TabIndex = 15;
            // 
            // workerComboBox
            // 
            this.workerComboBox.FormattingEnabled = true;
            this.workerComboBox.Location = new System.Drawing.Point(142, 190);
            this.workerComboBox.Name = "workerComboBox";
            this.workerComboBox.Size = new System.Drawing.Size(121, 21);
            this.workerComboBox.TabIndex = 14;
            // 
            // requestDescriptionTextBox
            // 
            this.requestDescriptionTextBox.Location = new System.Drawing.Point(142, 59);
            this.requestDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.requestDescriptionTextBox.Name = "requestDescriptionTextBox";
            this.requestDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.requestDescriptionTextBox.TabIndex = 13;
            // 
            // resultTextBOx
            // 
            this.resultTextBOx.Location = new System.Drawing.Point(142, 102);
            this.resultTextBOx.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.resultTextBOx.Name = "resultTextBOx";
            this.resultTextBOx.Size = new System.Drawing.Size(100, 20);
            this.resultTextBOx.TabIndex = 12;
            // 
            // ObjectTypeComboBox
            // 
            this.ObjectTypeComboBox.FormattingEnabled = true;
            this.ObjectTypeComboBox.Location = new System.Drawing.Point(142, 145);
            this.ObjectTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.ObjectTypeComboBox.Name = "ObjectTypeComboBox";
            this.ObjectTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ObjectTypeComboBox.TabIndex = 11;
            // 
            // workerIdLabel
            // 
            this.workerIdLabel.AutoSize = true;
            this.workerIdLabel.Location = new System.Drawing.Point(27, 190);
            this.workerIdLabel.Name = "workerIdLabel";
            this.workerIdLabel.Size = new System.Drawing.Size(57, 13);
            this.workerIdLabel.TabIndex = 9;
            this.workerIdLabel.Text = "Pracownik";
            // 
            // confirmButton
            // 
            this.confirmButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmButton.Location = new System.Drawing.Point(508, 123);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(74, 23);
            this.confirmButton.TabIndex = 9;
            this.confirmButton.Text = "Zatwierdź";
            this.confirmButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(508, 188);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ManagerRequestEditForm
            // 
            this.ClientSize = new System.Drawing.Size(714, 368);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.groupBoxActivityDescription);
            this.Controls.Add(this.requestLabel);
            this.Name = "ManagerRequestEditForm";
            this.groupBoxActivityDescription.ResumeLayout(false);
            this.groupBoxActivityDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label requestStatusLabel;
        private System.Windows.Forms.Label requestDescriptionLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label objectTypeLabel;
        private System.Windows.Forms.GroupBox groupBoxActivityDescription;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label workerIdLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox resultTextBOx;
        private System.Windows.Forms.ComboBox ObjectTypeComboBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ComboBox workerComboBox;
        private System.Windows.Forms.TextBox requestDescriptionTextBox;
    }
}