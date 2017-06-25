namespace AdminView
{
    partial class FindUserWindow
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
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchBT = new System.Windows.Forms.Button();
            this.nextViewBT = new System.Windows.Forms.Button();
            this.returnBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDGV
            // 
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(3, 53);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.Size = new System.Drawing.Size(244, 161);
            this.usersDGV.TabIndex = 0;
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(3, 27);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(166, 20);
            this.searchTB.TabIndex = 1;
            this.searchTB.Text = "First name, last name or login";
            // 
            // searchBT
            // 
            this.searchBT.Location = new System.Drawing.Point(176, 27);
            this.searchBT.Name = "searchBT";
            this.searchBT.Size = new System.Drawing.Size(71, 20);
            this.searchBT.TabIndex = 2;
            this.searchBT.Text = "Search";
            this.searchBT.UseVisualStyleBackColor = true;
            this.searchBT.Click += new System.EventHandler(this.searchBT_Click);
            // 
            // nextViewBT
            // 
            this.nextViewBT.Location = new System.Drawing.Point(130, 220);
            this.nextViewBT.Name = "nextViewBT";
            this.nextViewBT.Size = new System.Drawing.Size(117, 23);
            this.nextViewBT.TabIndex = 3;
            this.nextViewBT.Text = "Next";
            this.nextViewBT.UseVisualStyleBackColor = true;
            this.nextViewBT.Click += new System.EventHandler(this.nextViewBT_Click);
            // 
            // returnBT
            // 
            this.returnBT.Location = new System.Drawing.Point(3, 220);
            this.returnBT.Name = "returnBT";
            this.returnBT.Size = new System.Drawing.Size(121, 23);
            this.returnBT.TabIndex = 12;
            this.returnBT.Text = "Return";
            this.returnBT.UseVisualStyleBackColor = true;
            this.returnBT.Click += new System.EventHandler(this.returnBT_Click);
            // 
            // FindUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnBT);
            this.Controls.Add(this.nextViewBT);
            this.Controls.Add(this.searchBT);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.usersDGV);
            this.Name = "FindUserWindow";
            this.Size = new System.Drawing.Size(250, 250);
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button searchBT;
        private System.Windows.Forms.Button nextViewBT;
        private System.Windows.Forms.Button returnBT;
    }
}
