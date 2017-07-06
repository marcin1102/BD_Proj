namespace BD.Manager
{
	partial class SelectActivityType
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
            this.activityTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.selectButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activityTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // activityTypesDataGridView
            // 
            this.activityTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityTypesDataGridView.Location = new System.Drawing.Point(4, 29);
            this.activityTypesDataGridView.MultiSelect = false;
            this.activityTypesDataGridView.Name = "activityTypesDataGridView";
            this.activityTypesDataGridView.ReadOnly = true;
            this.activityTypesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activityTypesDataGridView.Size = new System.Drawing.Size(292, 184);
            this.activityTypesDataGridView.TabIndex = 0;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(4, 219);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Wybierz";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(85, 219);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Wróc";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(4, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(211, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(221, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 20);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(268, 219);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(28, 23);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "+";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // SelectActivityType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.activityTypesDataGridView);
            this.Name = "SelectActivityType";
            this.Size = new System.Drawing.Size(299, 245);
            ((System.ComponentModel.ISupportInitialize)(this.activityTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView activityTypesDataGridView;
		private System.Windows.Forms.Button selectButton;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button createButton;
	}
}
