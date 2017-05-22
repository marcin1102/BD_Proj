namespace BD
{
    partial class ClientForm
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
            this.clientTopLabel = new System.Windows.Forms.Label();
            this.clientReparationsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.clientReparationsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientTopLabel
            // 
            this.clientTopLabel.AutoSize = true;
            this.clientTopLabel.Location = new System.Drawing.Point(175, 35);
            this.clientTopLabel.Name = "clientTopLabel";
            this.clientTopLabel.Size = new System.Drawing.Size(109, 13);
            this.clientTopLabel.TabIndex = 0;
            this.clientTopLabel.Text = "Status moich napraw:";
            // 
            // clientReparationsDataGridView
            // 
            this.clientReparationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientReparationsDataGridView.Location = new System.Drawing.Point(125, 67);
            this.clientReparationsDataGridView.Name = "clientReparationsDataGridView";
            this.clientReparationsDataGridView.Size = new System.Drawing.Size(240, 247);
            this.clientReparationsDataGridView.TabIndex = 1;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 344);
            this.Controls.Add(this.clientReparationsDataGridView);
            this.Controls.Add(this.clientTopLabel);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)(this.clientReparationsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientTopLabel;
        private System.Windows.Forms.DataGridView clientReparationsDataGridView;
    }
}