﻿namespace BD.Manager.beta
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
            this.activityDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.objectNameLabel = new System.Windows.Forms.Label();
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
            this.managerLabel = new System.Windows.Forms.TextBox();
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
            this.activityDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editButton = new System.Windows.Forms.Button();
            this.editRequestButton = new System.Windows.Forms.Button();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataBindingSource1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataBindingSource)).BeginInit();
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
            this.activitiesDataGridView.AutoGenerateColumns = false;
            this.activitiesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn});
            this.activitiesDataGridView.DataSource = this.activityDataBindingSource;
            this.activitiesDataGridView.Location = new System.Drawing.Point(6, 16);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.ReadOnly = true;
            this.activitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activitiesDataGridView.Size = new System.Drawing.Size(197, 84);
            this.activitiesDataGridView.TabIndex = 16;
            this.activitiesDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.activitiesDataGridView_CellEnter);
            // 
            // activityDataBindingSource1
            // 
            this.activityDataBindingSource1.DataSource = typeof(BusinessLayer.DTO.ActivityData);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.objectNameLabel);
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
            // objectNameLabel
            // 
            this.objectNameLabel.AutoSize = true;
            this.objectNameLabel.Location = new System.Drawing.Point(64, 34);
            this.objectNameLabel.Name = "objectNameLabel";
            this.objectNameLabel.Size = new System.Drawing.Size(35, 13);
            this.objectNameLabel.TabIndex = 13;
            this.objectNameLabel.Text = "label2";
            // 
            // objectTypeLabel
            // 
            this.objectTypeLabel.AutoSize = true;
            this.objectTypeLabel.Location = new System.Drawing.Point(64, 16);
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
            this.groupBox5.Controls.Add(this.managerLabel);
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
            // managerLabel
            // 
            this.managerLabel.Location = new System.Drawing.Point(68, 13);
            this.managerLabel.Name = "managerLabel";
            this.managerLabel.Size = new System.Drawing.Size(137, 20);
            this.managerLabel.TabIndex = 24;
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
            this.addActivityButton.Location = new System.Drawing.Point(20, 495);
            this.addActivityButton.Name = "addActivityButton";
            this.addActivityButton.Size = new System.Drawing.Size(189, 39);
            this.addActivityButton.TabIndex = 22;
            this.addActivityButton.Text = "Dodaj Czynność";
            this.addActivityButton.UseVisualStyleBackColor = true;
            this.addActivityButton.Click += new System.EventHandler(this.addActivityButton_Click);
            // 
            // cancelActivityButton
            // 
            this.cancelActivityButton.Location = new System.Drawing.Point(215, 540);
            this.cancelActivityButton.Name = "cancelActivityButton";
            this.cancelActivityButton.Size = new System.Drawing.Size(191, 41);
            this.cancelActivityButton.TabIndex = 40;
            this.cancelActivityButton.Text = "Anuluj Zgłoszenie";
            this.cancelActivityButton.UseVisualStyleBackColor = true;
            this.cancelActivityButton.Click += new System.EventHandler(this.cancelActivityButton_Click);
            // 
            // finishRequestButton
            // 
            this.finishRequestButton.Location = new System.Drawing.Point(20, 587);
            this.finishRequestButton.Name = "finishRequestButton";
            this.finishRequestButton.Size = new System.Drawing.Size(189, 37);
            this.finishRequestButton.TabIndex = 39;
            this.finishRequestButton.Text = "Zakończ Zgłoszenie";
            this.finishRequestButton.UseVisualStyleBackColor = true;
            this.finishRequestButton.Click += new System.EventHandler(this.finishRequestButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(215, 587);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(191, 37);
            this.goBackButton.TabIndex = 41;
            this.goBackButton.Text = "Wróć";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // activityDataBindingSource
            // 
            this.activityDataBindingSource.DataSource = typeof(BusinessLayer.DTO.ActivityData);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(215, 495);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(191, 40);
            this.editButton.TabIndex = 42;
            this.editButton.Text = "Edytuj czynność";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // editRequestButton
            // 
            this.editRequestButton.Location = new System.Drawing.Point(20, 540);
            this.editRequestButton.Name = "editRequestButton";
            this.editRequestButton.Size = new System.Drawing.Size(189, 41);
            this.editRequestButton.TabIndex = 43;
            this.editRequestButton.Text = "Edytuj zgłoszenie";
            this.editRequestButton.UseVisualStyleBackColor = true;
            this.editRequestButton.Click += new System.EventHandler(this.editRequestButton_Click);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "Worker";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HandleRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editRequestButton);
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
            this.Size = new System.Drawing.Size(420, 675);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataBindingSource1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label objectNameLabel;
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
        private System.Windows.Forms.TextBox managerLabel;
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
        private System.Windows.Forms.BindingSource activityDataBindingSource;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.BindingSource activityDataBindingSource1;
		private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button editRequestButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;
    }
}
