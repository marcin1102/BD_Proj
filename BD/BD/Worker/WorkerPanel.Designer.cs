namespace BD.Worker
{
    partial class WorkerPanel
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
            this.components = new System.ComponentModel.Container();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentObjectTextBox = new System.Windows.Forms.TextBox();
            this.openObjectListBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.finishRequestButton = new System.Windows.Forms.Button();
            this.cancelRequestButton = new System.Windows.Forms.Button();
            this.activityDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.AutoGenerateColumns = false;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.activitiesDataGridView.DataSource = this.activityDataBindingSource;
            this.activitiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activitiesDataGridView.Location = new System.Drawing.Point(3, 16);
            this.activitiesDataGridView.MultiSelect = false;
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.ReadOnly = true;
            this.activitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activitiesDataGridView.Size = new System.Drawing.Size(470, 280);
            this.activitiesDataGridView.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activitiesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 299);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Czynności";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(18, 7);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(284, 6);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 8;
            this.statusComboBox.Text = "OPN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "status";
            // 
            // currentObjectTextBox
            // 
            this.currentObjectTextBox.Location = new System.Drawing.Point(284, 33);
            this.currentObjectTextBox.Name = "currentObjectTextBox";
            this.currentObjectTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentObjectTextBox.TabIndex = 10;
            // 
            // openObjectListBtn
            // 
            this.openObjectListBtn.Location = new System.Drawing.Point(384, 33);
            this.openObjectListBtn.Name = "openObjectListBtn";
            this.openObjectListBtn.Size = new System.Drawing.Size(23, 20);
            this.openObjectListBtn.TabIndex = 11;
            this.openObjectListBtn.Text = "...";
            this.openObjectListBtn.UseVisualStyleBackColor = true;
            this.openObjectListBtn.Click += new System.EventHandler(this.openObjectListBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "obiekt";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(413, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 47);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Szukaj";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // finishRequestButton
            // 
            this.finishRequestButton.Location = new System.Drawing.Point(12, 359);
            this.finishRequestButton.Name = "finishRequestButton";
            this.finishRequestButton.Size = new System.Drawing.Size(235, 40);
            this.finishRequestButton.TabIndex = 30;
            this.finishRequestButton.Text = "Zakończ czynność";
            this.finishRequestButton.UseVisualStyleBackColor = true;
            this.finishRequestButton.Click += new System.EventHandler(this.finishRequestButton_Click);
            // 
            // cancelRequestButton
            // 
            this.cancelRequestButton.Location = new System.Drawing.Point(12, 405);
            this.cancelRequestButton.Name = "cancelRequestButton";
            this.cancelRequestButton.Size = new System.Drawing.Size(235, 40);
            this.cancelRequestButton.TabIndex = 31;
            this.cancelRequestButton.Text = "Anuluj czynność";
            this.cancelRequestButton.UseVisualStyleBackColor = true;
            this.cancelRequestButton.Click += new System.EventHandler(this.cancelRequestButton_Click);
            // 
            // activityDataBindingSource
            // 
            this.activityDataBindingSource.DataSource = typeof(BusinessLayer.DTO.ActivityData);
            // 
            // requestDataGridViewTextBoxColumn
            // 
            this.requestDataGridViewTextBoxColumn.DataPropertyName = "Request";
            this.requestDataGridViewTextBoxColumn.HeaderText = "Object";
            this.requestDataGridViewTextBoxColumn.Name = "requestDataGridViewTextBoxColumn";
            this.requestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "Descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "Descr";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            this.descrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // WorkerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.cancelRequestButton);
            this.Controls.Add(this.finishRequestButton);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openObjectListBtn);
            this.Controls.Add(this.currentObjectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Name = "WorkerPanel";
            this.Size = new System.Drawing.Size(500, 479);
            this.Load += new System.EventHandler(this.WorkerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentObjectTextBox;
        private System.Windows.Forms.Button openObjectListBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button finishRequestButton;
        private System.Windows.Forms.Button cancelRequestButton;
        private System.Windows.Forms.BindingSource activityDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
