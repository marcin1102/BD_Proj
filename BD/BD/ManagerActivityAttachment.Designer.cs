namespace BD
{
    partial class ManagerActivityAttachment
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
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.workersListLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Location = new System.Drawing.Point(348, 74);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.Size = new System.Drawing.Size(240, 289);
            this.workersDataGridView.TabIndex = 0;
            this.workersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workersDataGridView_CellContentClick);
            // 
            // workersListLabel
            // 
            this.workersListLabel.AutoSize = true;
            this.workersListLabel.Location = new System.Drawing.Point(421, 48);
            this.workersListLabel.Name = "workersListLabel";
            this.workersListLabel.Size = new System.Drawing.Size(97, 13);
            this.workersListLabel.TabIndex = 1;
            this.workersListLabel.Text = "Lista wykonawców";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Przydziel/Zmień Wykonawcę";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybór wykonawcy czynności A dla zgłoszenia B";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManagerActivityAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workersListLabel);
            this.Controls.Add(this.workersDataGridView);
            this.Name = "ManagerActivityAttachment";
            this.Text = "ManagerActivityAttachment";
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.Label workersListLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}