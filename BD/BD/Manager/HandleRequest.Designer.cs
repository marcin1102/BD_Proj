namespace BD.Manager.beta
{
    partial class HandleRequest
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
			this.components = new System.ComponentModel.Container();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.ObjectNameLabel = new System.Windows.Forms.Label();
			this.objectTypeLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.requestDescrRichTextBox = new System.Windows.Forms.RichTextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.activityDescrRichTextBox = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.requestStatusLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.workerAssignedToActivityLabel = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.activityResultRichTextBox = new System.Windows.Forms.RichTextBox();
			this.richTextBox4 = new System.Windows.Forms.RichTextBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.requestResultRichTextBox = new System.Windows.Forms.RichTextBox();
			this.richTextBox6 = new System.Windows.Forms.RichTextBox();
			this.addActivityButton = new System.Windows.Forms.Button();
			this.cancelActivityButton = new System.Windows.Forms.Button();
			this.finishRequestButton = new System.Windows.Forms.Button();
			this.goBackButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.activitiesDataGridView);
			this.groupBox2.Location = new System.Drawing.Point(6, 177);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 100);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Czynności w Zgłoszeniu";
			// 
			// activitiesDataGridView
			// 
			this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.activitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activitiesDataGridView.Location = new System.Drawing.Point(3, 16);
			this.activitiesDataGridView.Name = "activitiesDataGridView";
			this.activitiesDataGridView.Size = new System.Drawing.Size(194, 81);
			this.activitiesDataGridView.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.ObjectNameLabel);
			this.groupBox4.Controls.Add(this.objectTypeLabel);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Location = new System.Drawing.Point(3, 4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(192, 61);
			this.groupBox4.TabIndex = 31;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Obiekt";
			// 
			// ObjectNameLabel
			// 
			this.ObjectNameLabel.AutoSize = true;
			this.ObjectNameLabel.Location = new System.Drawing.Point(132, 34);
			this.ObjectNameLabel.Name = "ObjectNameLabel";
			this.ObjectNameLabel.Size = new System.Drawing.Size(35, 13);
			this.ObjectNameLabel.TabIndex = 13;
			this.ObjectNameLabel.Text = "label2";
			// 
			// objectTypeLabel
			// 
			this.objectTypeLabel.AutoSize = true;
			this.objectTypeLabel.Location = new System.Drawing.Point(132, 16);
			this.objectTypeLabel.Name = "objectTypeLabel";
			this.objectTypeLabel.Size = new System.Drawing.Size(35, 13);
			this.objectTypeLabel.TabIndex = 11;
			this.objectTypeLabel.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Nazwa";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Typ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.requestDescrRichTextBox);
			this.groupBox1.Location = new System.Drawing.Point(3, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(409, 100);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Opis Zgłoszenia";
			// 
			// requestDescrRichTextBox
			// 
			this.requestDescrRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.requestDescrRichTextBox.Enabled = false;
			this.requestDescrRichTextBox.Location = new System.Drawing.Point(3, 16);
			this.requestDescrRichTextBox.Name = "requestDescrRichTextBox";
			this.requestDescrRichTextBox.ReadOnly = true;
			this.requestDescrRichTextBox.Size = new System.Drawing.Size(403, 81);
			this.requestDescrRichTextBox.TabIndex = 14;
			this.requestDescrRichTextBox.Text = "";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.activityDescrRichTextBox);
			this.groupBox3.Location = new System.Drawing.Point(212, 177);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 100);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Opis Czynności";
			// 
			// activityDescrRichTextBox
			// 
			this.activityDescrRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activityDescrRichTextBox.Enabled = false;
			this.activityDescrRichTextBox.Location = new System.Drawing.Point(3, 16);
			this.activityDescrRichTextBox.Name = "activityDescrRichTextBox";
			this.activityDescrRichTextBox.ReadOnly = true;
			this.activityDescrRichTextBox.Size = new System.Drawing.Size(194, 81);
			this.activityDescrRichTextBox.TabIndex = 0;
			this.activityDescrRichTextBox.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.requestStatusLabel);
			this.groupBox5.Controls.Add(this.label7);
			this.groupBox5.Controls.Add(this.label2);
			this.groupBox5.Controls.Add(this.workerAssignedToActivityLabel);
			this.groupBox5.Location = new System.Drawing.Point(201, 4);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(211, 61);
			this.groupBox5.TabIndex = 36;
			this.groupBox5.TabStop = false;
			// 
			// requestStatusLabel
			// 
			this.requestStatusLabel.AutoSize = true;
			this.requestStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.requestStatusLabel.Location = new System.Drawing.Point(122, 36);
			this.requestStatusLabel.Name = "requestStatusLabel";
			this.requestStatusLabel.Size = new System.Drawing.Size(32, 15);
			this.requestStatusLabel.TabIndex = 27;
			this.requestStatusLabel.Text = "OPN";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Status Zgłoszenia";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 26;
			this.label2.Text = "Pracownik";
			// 
			// workerAssignedToActivityLabel
			// 
			this.workerAssignedToActivityLabel.Location = new System.Drawing.Point(68, 13);
			this.workerAssignedToActivityLabel.Name = "workerAssignedToActivityLabel";
			this.workerAssignedToActivityLabel.Size = new System.Drawing.Size(137, 20);
			this.workerAssignedToActivityLabel.TabIndex = 24;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.activityResultRichTextBox);
			this.groupBox6.Controls.Add(this.richTextBox4);
			this.groupBox6.Location = new System.Drawing.Point(9, 283);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(403, 100);
			this.groupBox6.TabIndex = 37;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Wynik Czynności";
			// 
			// activityResultRichTextBox
			// 
			this.activityResultRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activityResultRichTextBox.Enabled = false;
			this.activityResultRichTextBox.Location = new System.Drawing.Point(3, 16);
			this.activityResultRichTextBox.Name = "activityResultRichTextBox";
			this.activityResultRichTextBox.ReadOnly = true;
			this.activityResultRichTextBox.Size = new System.Drawing.Size(397, 81);
			this.activityResultRichTextBox.TabIndex = 15;
			this.activityResultRichTextBox.Text = "status czynności będzie widoczny w gridview \'czynosci w zgłoszeniu\'";
			// 
			// richTextBox4
			// 
			this.richTextBox4.Location = new System.Drawing.Point(6, 19);
			this.richTextBox4.Name = "richTextBox4";
			this.richTextBox4.Size = new System.Drawing.Size(378, 75);
			this.richTextBox4.TabIndex = 14;
			this.richTextBox4.Text = "";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.requestResultRichTextBox);
			this.groupBox7.Controls.Add(this.richTextBox6);
			this.groupBox7.Location = new System.Drawing.Point(6, 389);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(403, 100);
			this.groupBox7.TabIndex = 38;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Wynik Zgłoszenia";
			// 
			// requestResultRichTextBox
			// 
			this.requestResultRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.requestResultRichTextBox.Enabled = false;
			this.requestResultRichTextBox.Location = new System.Drawing.Point(3, 16);
			this.requestResultRichTextBox.Name = "requestResultRichTextBox";
			this.requestResultRichTextBox.ReadOnly = true;
			this.requestResultRichTextBox.Size = new System.Drawing.Size(397, 81);
			this.requestResultRichTextBox.TabIndex = 15;
			this.requestResultRichTextBox.Text = "";
			// 
			// richTextBox6
			// 
			this.richTextBox6.Location = new System.Drawing.Point(6, 19);
			this.richTextBox6.Name = "richTextBox6";
			this.richTextBox6.Size = new System.Drawing.Size(378, 75);
			this.richTextBox6.TabIndex = 14;
			this.richTextBox6.Text = "";
			// 
			// addActivityButton
			// 
			this.addActivityButton.Location = new System.Drawing.Point(6, 495);
			this.addActivityButton.Name = "addActivityButton";
			this.addActivityButton.Size = new System.Drawing.Size(200, 40);
			this.addActivityButton.TabIndex = 22;
			this.addActivityButton.Text = "Dodaj Czynność";
			this.addActivityButton.UseVisualStyleBackColor = true;
			this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
			// 
			// cancelActivityButton
			// 
			this.cancelActivityButton.Location = new System.Drawing.Point(6, 586);
			this.cancelActivityButton.Name = "cancelActivityButton";
			this.cancelActivityButton.Size = new System.Drawing.Size(200, 40);
			this.cancelActivityButton.TabIndex = 40;
			this.cancelActivityButton.Text = "Anuluj Zgłoszenie";
			this.cancelActivityButton.UseVisualStyleBackColor = true;
			// 
			// finishRequestButton
			// 
			this.finishRequestButton.Location = new System.Drawing.Point(6, 541);
			this.finishRequestButton.Name = "finishRequestButton";
			this.finishRequestButton.Size = new System.Drawing.Size(200, 40);
			this.finishRequestButton.TabIndex = 39;
			this.finishRequestButton.Text = "Zakończ Zgłoszenie";
			this.finishRequestButton.UseVisualStyleBackColor = true;
			// 
			// goBackButton
			// 
			this.goBackButton.Location = new System.Drawing.Point(6, 633);
			this.goBackButton.Name = "goBackButton";
			this.goBackButton.Size = new System.Drawing.Size(200, 40);
			this.goBackButton.TabIndex = 41;
			this.goBackButton.Text = "Wróć";
			this.goBackButton.UseVisualStyleBackColor = true;
			this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
			// 
			// editButton
			// 
			this.editButton.Location = new System.Drawing.Point(215, 496);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(191, 39);
			this.editButton.TabIndex = 42;
			this.editButton.Text = "Edytuj czynność";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// HandleRequest
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.goBackButton);
			this.Controls.Add(this.cancelActivityButton);
			this.Controls.Add(this.finishRequestButton);
			this.Controls.Add(this.addActivityButton);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox4);
			this.Name = "HandleRequest";
			this.Size = new System.Drawing.Size(424, 711);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ObjectNameLabel;
        private System.Windows.Forms.Label objectTypeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox requestDescrRichTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox activityDescrRichTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workerAssignedToActivityLabel;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox activityResultRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox requestResultRichTextBox;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Label requestStatusLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addActivityButton;
        private System.Windows.Forms.Button cancelActivityButton;
        private System.Windows.Forms.Button finishRequestButton;
        private System.Windows.Forms.Button goBackButton;
		private System.Windows.Forms.Button editButton;
	}
}
