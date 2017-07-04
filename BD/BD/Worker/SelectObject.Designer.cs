namespace BD.Worker
{
    partial class SelectObject
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
            this.objectDataGridView = new System.Windows.Forms.DataGridView();
            this.goBackButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // objectDataGridView
            // 
            this.objectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objectDataGridView.Location = new System.Drawing.Point(13, 13);
            this.objectDataGridView.MultiSelect = false;
            this.objectDataGridView.Name = "objectDataGridView";
            this.objectDataGridView.ReadOnly = true;
            this.objectDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.objectDataGridView.Size = new System.Drawing.Size(418, 237);
            this.objectDataGridView.TabIndex = 0;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(215, 256);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(90, 23);
            this.goBackButton.TabIndex = 17;
            this.goBackButton.Text = "Wróć";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(123, 256);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(90, 23);
            this.selectButton.TabIndex = 16;
            this.selectButton.Text = "Wybierz";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SelectObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.objectDataGridView);
            this.Name = "SelectObject";
            this.Size = new System.Drawing.Size(443, 293);
            ((System.ComponentModel.ISupportInitialize)(this.objectDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView objectDataGridView;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button selectButton;
    }
}