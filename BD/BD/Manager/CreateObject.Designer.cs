﻿namespace BD.Manager
{
    partial class CreateObject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.objectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.objectTypeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(75, 222);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Dodaj";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(183, 222);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "Wróc";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(137, 107);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // objectTypeComboBox
            // 
            this.objectTypeComboBox.FormattingEnabled = true;
            this.objectTypeComboBox.Location = new System.Drawing.Point(137, 153);
            this.objectTypeComboBox.Name = "objectTypeComboBox";
            this.objectTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.objectTypeComboBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(91, 111);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(40, 13);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Nazwa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Typ obiektu";
            // 
            // objectTypeButton
            // 
            this.objectTypeButton.Location = new System.Drawing.Point(265, 153);
            this.objectTypeButton.Name = "objectTypeButton";
            this.objectTypeButton.Size = new System.Drawing.Size(23, 20);
            this.objectTypeButton.TabIndex = 6;
            this.objectTypeButton.Text = "...";
            this.objectTypeButton.UseVisualStyleBackColor = true;
            this.objectTypeButton.Click += new System.EventHandler(this.objectTypeButton_Click);
            // 
            // CreateObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.objectTypeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.objectTypeComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addButton);
            this.Name = "CreateObject";
            this.Size = new System.Drawing.Size(332, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox objectTypeComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button objectTypeButton;
    }
}
