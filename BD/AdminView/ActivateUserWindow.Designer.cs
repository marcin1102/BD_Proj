﻿namespace AdminView
{
    partial class ActivateUserWindow
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
            this.activateBT = new System.Windows.Forms.Button();
            this.returnBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activateBT
            // 
            this.activateBT.Location = new System.Drawing.Point(25, 138);
            this.activateBT.Name = "activateBT";
            this.activateBT.Size = new System.Drawing.Size(200, 23);
            this.activateBT.TabIndex = 6;
            this.activateBT.Text = "Activate user and return";
            this.activateBT.UseVisualStyleBackColor = true;
            this.activateBT.Click += new System.EventHandler(this.activateBT_Click);
            // 
            // returnBT
            // 
            this.returnBT.Location = new System.Drawing.Point(58, 167);
            this.returnBT.Name = "returnBT";
            this.returnBT.Size = new System.Drawing.Size(121, 23);
            this.returnBT.TabIndex = 11;
            this.returnBT.Text = "Return";
            this.returnBT.UseVisualStyleBackColor = true;
            this.returnBT.Click += new System.EventHandler(this.returnBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // ActivateUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnBT);
            this.Controls.Add(this.activateBT);
            this.Name = "ActivateUserWindow";
            this.Size = new System.Drawing.Size(250, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button activateBT;
        private System.Windows.Forms.Button returnBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
