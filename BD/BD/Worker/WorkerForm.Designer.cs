namespace BD
{
    partial class WorkerForm
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
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.showActivityButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.Size = new System.Drawing.Size(464, 316);
            this.activitiesDataGridView.TabIndex = 3;
            // 
            // showActivityButton
            // 
            this.showActivityButton.Location = new System.Drawing.Point(509, 165);
            this.showActivityButton.Name = "showActivityButton";
            this.showActivityButton.Size = new System.Drawing.Size(85, 46);
            this.showActivityButton.TabIndex = 5;
            this.showActivityButton.Text = "Do Obsługi";
            this.showActivityButton.UseVisualStyleBackColor = true;
            this.showActivityButton.Click += new System.EventHandler(this.showActivityButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activitiesDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 341);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Czynności";
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 365);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showActivityButton);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.Button showActivityButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}