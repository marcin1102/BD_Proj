namespace BD
{
    partial class WorkerActivityFormFinish
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
            this.requestIdLabel = new System.Windows.Forms.Label();
            this.requestIdText = new System.Windows.Forms.Label();
            this.groupBoxActivityDescription = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.endButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBoxActivityDescription.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestIdLabel
            // 
            this.requestIdLabel.AutoSize = true;
            this.requestIdLabel.Location = new System.Drawing.Point(28, 19);
            this.requestIdLabel.Name = "requestIdLabel";
            this.requestIdLabel.Size = new System.Drawing.Size(18, 13);
            this.requestIdLabel.TabIndex = 1;
            this.requestIdLabel.Text = "ID";
            // 
            // requestIdText
            // 
            this.requestIdText.Location = new System.Drawing.Point(113, 19);
            this.requestIdText.Name = "requestIdText";
            this.requestIdText.Size = new System.Drawing.Size(61, 20);
            this.requestIdText.TabIndex = 2;
            this.requestIdText.Text = "label3";
            // 
            // groupBoxActivityDescription
            // 
            this.groupBoxActivityDescription.Controls.Add(this.comboBox1);
            this.groupBoxActivityDescription.Controls.Add(this.statusLabel);
            this.groupBoxActivityDescription.Controls.Add(this.requestIdLabel);
            this.groupBoxActivityDescription.Controls.Add(this.requestIdText);
            this.groupBoxActivityDescription.Location = new System.Drawing.Point(12, 12);
            this.groupBoxActivityDescription.Name = "groupBoxActivityDescription";
            this.groupBoxActivityDescription.Size = new System.Drawing.Size(194, 62);
            this.groupBoxActivityDescription.TabIndex = 8;
            this.groupBoxActivityDescription.TabStop = false;
            this.groupBoxActivityDescription.Text = "Czynność";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(28, 40);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 9;
            this.statusLabel.Text = "Status";
            this.statusLabel.Click += new System.EventHandler(this.statusLabel_Click);
            // 
            // endButton
            // 
            this.endButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.endButton.Location = new System.Drawing.Point(252, 248);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(74, 23);
            this.endButton.TabIndex = 9;
            this.endButton.Text = "Zatwierdź";
            this.endButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(365, 248);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opis Zgłoszenia";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(188, 75);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opis Czynności";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 19);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(188, 75);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox3);
            this.groupBox3.Location = new System.Drawing.Point(246, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wynik";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(6, 19);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(188, 75);
            this.richTextBox3.TabIndex = 14;
            this.richTextBox3.Text = "";
            // 
            // WorkerActivityFormFinish
            // 
            this.ClientSize = new System.Drawing.Size(478, 318);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.groupBoxActivityDescription);
            this.Name = "WorkerActivityFormFinish";
            this.groupBoxActivityDescription.ResumeLayout(false);
            this.groupBoxActivityDescription.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label requestIdLabel;
        private System.Windows.Forms.Label requestIdText;
        private System.Windows.Forms.GroupBox groupBoxActivityDescription;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}