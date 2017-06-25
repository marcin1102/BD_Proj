﻿namespace BD.Manager
{
    partial class ManagerRequestShowForm
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
            this.requestIdLabel = new System.Windows.Forms.Label();
            this.requestIdText = new System.Windows.Forms.Label();
            this.requestDescriptionLabel = new System.Windows.Forms.Label();
            this.requestDescriptionText = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.activityDescriptionLabel = new System.Windows.Forms.Label();
            this.groupBoxActivityDescription = new System.Windows.Forms.GroupBox();
            this.statusText = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.workerIDText = new System.Windows.Forms.Label();
            this.workerIDLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.objectTypeText = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addActivityButton = new System.Windows.Forms.Button();
            this.groupBoxActivityDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Location = new System.Drawing.Point(182, 25);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(70, 13);
            this.requestLabel.TabIndex = 0;
            this.requestLabel.Text = "Zgłoszenie A";
            this.requestLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.groupBoxActivityDescription.Controls.Add(this.statusText);
            this.groupBoxActivityDescription.Controls.Add(this.resultText);
            this.groupBoxActivityDescription.Controls.Add(this.workerIDText);
            this.groupBoxActivityDescription.Controls.Add(this.workerIDLabel);
            this.groupBoxActivityDescription.Controls.Add(this.statusLabel);
            this.groupBoxActivityDescription.Controls.Add(this.objectTypeText);
            this.groupBoxActivityDescription.Controls.Add(this.resultLabel);
            this.groupBoxActivityDescription.Controls.Add(this.activityDescriptionLabel);
            this.groupBoxActivityDescription.Controls.Add(this.requestIdLabel);
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
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(139, 189);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(35, 13);
            this.statusText.TabIndex = 14;
            this.statusText.Text = "label2";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(139, 105);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(35, 13);
            this.resultText.TabIndex = 13;
            this.resultText.Text = "label1";
            // 
            // workerIDText
            // 
            this.workerIDText.AutoSize = true;
            this.workerIDText.Location = new System.Drawing.Point(139, 222);
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
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(508, 123);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(508, 283);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(508, 76);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 13;
            this.finishButton.Text = "Zakończ";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Edycja";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addActivityButton
            // 
            this.addActivityButton.Location = new System.Drawing.Point(508, 223);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(75, 40);
            this.addActivityButton.TabIndex = 15;
            this.addActivityButton.Text = "Dodaj czynność";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // ManagerRequestShowForm
            // 
            this.ClientSize = new System.Drawing.Size(714, 368);
            this.Controls.Add(this.addActivityButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBoxActivityDescription);
            this.Controls.Add(this.requestLabel);
            this.Name = "ManagerRequestShowForm";
            this.groupBoxActivityDescription.ResumeLayout(false);
            this.groupBoxActivityDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label requestIdLabel;
        private System.Windows.Forms.Label requestIdText;
        private System.Windows.Forms.Label requestDescriptionLabel;
        private System.Windows.Forms.Label requestDescriptionText;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label activityDescriptionLabel;
        private System.Windows.Forms.GroupBox groupBoxActivityDescription;
        private System.Windows.Forms.Label objectTypeText;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label workerIDText;
        private System.Windows.Forms.Label workerIDLabel;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addActivityButton;
    }
}