namespace BD
{
    partial class ManagerActivitiesCreateForm
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
            this.activityCreateTopLabel = new System.Windows.Forms.Label();
            this.activityNamelabel = new System.Windows.Forms.Label();
            this.activityNameTextBox = new System.Windows.Forms.TextBox();
            this.actuallyAttachedWorkerLabel = new System.Windows.Forms.Label();
            this.actuallyAttachedWorkerTextBox = new System.Windows.Forms.TextBox();
            this.attachWorkerButton = new System.Windows.Forms.Button();
            this.addNewActivityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activityCreateTopLabel
            // 
            this.activityCreateTopLabel.AutoSize = true;
            this.activityCreateTopLabel.Location = new System.Drawing.Point(197, 25);
            this.activityCreateTopLabel.Name = "activityCreateTopLabel";
            this.activityCreateTopLabel.Size = new System.Drawing.Size(164, 13);
            this.activityCreateTopLabel.TabIndex = 0;
            this.activityCreateTopLabel.Text = "Nowa czynność dla zgłoszenia X";
            this.activityCreateTopLabel.Click += new System.EventHandler(this.activityCreateTopLabel_Click);
            // 
            // activityNamelabel
            // 
            this.activityNamelabel.AutoSize = true;
            this.activityNamelabel.Location = new System.Drawing.Point(138, 82);
            this.activityNamelabel.Name = "activityNamelabel";
            this.activityNamelabel.Size = new System.Drawing.Size(90, 13);
            this.activityNamelabel.TabIndex = 1;
            this.activityNamelabel.Text = "Nazwa czynności";
            // 
            // activityNameTextBox
            // 
            this.activityNameTextBox.Location = new System.Drawing.Point(307, 79);
            this.activityNameTextBox.Name = "activityNameTextBox";
            this.activityNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.activityNameTextBox.TabIndex = 2;
            this.activityNameTextBox.TextChanged += new System.EventHandler(this.activityNameTextBox_TextChanged);
            // 
            // actuallyAttachedWorkerLabel
            // 
            this.actuallyAttachedWorkerLabel.AutoSize = true;
            this.actuallyAttachedWorkerLabel.Location = new System.Drawing.Point(129, 134);
            this.actuallyAttachedWorkerLabel.Name = "actuallyAttachedWorkerLabel";
            this.actuallyAttachedWorkerLabel.Size = new System.Drawing.Size(108, 13);
            this.actuallyAttachedWorkerLabel.TabIndex = 3;
            this.actuallyAttachedWorkerLabel.Text = "Aktualny wykonawca";
            // 
            // actuallyAttachedWorkerTextBox
            // 
            this.actuallyAttachedWorkerTextBox.Location = new System.Drawing.Point(307, 127);
            this.actuallyAttachedWorkerTextBox.Name = "actuallyAttachedWorkerTextBox";
            this.actuallyAttachedWorkerTextBox.Size = new System.Drawing.Size(100, 20);
            this.actuallyAttachedWorkerTextBox.TabIndex = 4;
            this.actuallyAttachedWorkerTextBox.TextChanged += new System.EventHandler(this.actuallyAttachedWorkerTextBox_TextChanged);
            // 
            // attachWorkerButton
            // 
            this.attachWorkerButton.Location = new System.Drawing.Point(210, 182);
            this.attachWorkerButton.Name = "attachWorkerButton";
            this.attachWorkerButton.Size = new System.Drawing.Size(138, 23);
            this.attachWorkerButton.TabIndex = 5;
            this.attachWorkerButton.Text = "Przydziel wykonawcę";
            this.attachWorkerButton.UseVisualStyleBackColor = true;
            this.attachWorkerButton.Click += new System.EventHandler(this.attachWorkerButton_Click);
            // 
            // addNewActivityButton
            // 
            this.addNewActivityButton.Location = new System.Drawing.Point(210, 238);
            this.addNewActivityButton.Name = "addNewActivityButton";
            this.addNewActivityButton.Size = new System.Drawing.Size(138, 23);
            this.addNewActivityButton.TabIndex = 6;
            this.addNewActivityButton.Text = "Stwórz czynność";
            this.addNewActivityButton.UseVisualStyleBackColor = true;
            this.addNewActivityButton.Click += new System.EventHandler(this.addNewActivityButton_Click);
            // 
            // ManagerActivitiesCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 379);
            this.Controls.Add(this.addNewActivityButton);
            this.Controls.Add(this.attachWorkerButton);
            this.Controls.Add(this.actuallyAttachedWorkerTextBox);
            this.Controls.Add(this.actuallyAttachedWorkerLabel);
            this.Controls.Add(this.activityNameTextBox);
            this.Controls.Add(this.activityNamelabel);
            this.Controls.Add(this.activityCreateTopLabel);
            this.Name = "ManagerActivitiesCreateForm";
            this.Text = "ManagerActivitiesCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label activityCreateTopLabel;
        private System.Windows.Forms.Label activityNamelabel;
        private System.Windows.Forms.TextBox activityNameTextBox;
        private System.Windows.Forms.Label actuallyAttachedWorkerLabel;
        private System.Windows.Forms.TextBox actuallyAttachedWorkerTextBox;
        private System.Windows.Forms.Button attachWorkerButton;
        private System.Windows.Forms.Button addNewActivityButton;
    }
}