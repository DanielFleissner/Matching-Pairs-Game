﻿
namespace MatchingPairsGame
{
    partial class CreateProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.buttonProfileAccount = new System.Windows.Forms.Button();
            this.buttonReturnToLoginWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter new Profile Name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(406, 78);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(266, 31);
            this.textBoxUserName.TabIndex = 1;
            // 
            // buttonProfileAccount
            // 
            this.buttonProfileAccount.Location = new System.Drawing.Point(419, 177);
            this.buttonProfileAccount.Name = "buttonProfileAccount";
            this.buttonProfileAccount.Size = new System.Drawing.Size(253, 67);
            this.buttonProfileAccount.TabIndex = 2;
            this.buttonProfileAccount.Text = "Create Profile";
            this.buttonProfileAccount.UseVisualStyleBackColor = true;
            this.buttonProfileAccount.Click += new System.EventHandler(this.buttonCreateProfile_Click);
            // 
            // buttonReturnToLoginWindow
            // 
            this.buttonReturnToLoginWindow.Location = new System.Drawing.Point(111, 177);
            this.buttonReturnToLoginWindow.Name = "buttonReturnToLoginWindow";
            this.buttonReturnToLoginWindow.Size = new System.Drawing.Size(253, 67);
            this.buttonReturnToLoginWindow.TabIndex = 3;
            this.buttonReturnToLoginWindow.Text = "Return to Login Window";
            this.buttonReturnToLoginWindow.UseVisualStyleBackColor = true;
            this.buttonReturnToLoginWindow.Click += new System.EventHandler(this.buttonReturnToLoginWindow_Click);
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 281);
            this.Controls.Add(this.buttonReturnToLoginWindow);
            this.Controls.Add(this.buttonProfileAccount);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button buttonProfileAccount;
        private System.Windows.Forms.Button buttonReturnToLoginWindow;
    }
}