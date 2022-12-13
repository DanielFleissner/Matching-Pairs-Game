
namespace MatchingPairsGame
{
    partial class Login
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
            this.buttonNewCreateAccount = new System.Windows.Forms.Button();
            this.comboBoxSelectAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewCreateAccount
            // 
            this.buttonNewCreateAccount.Location = new System.Drawing.Point(153, 302);
            this.buttonNewCreateAccount.Name = "buttonNewCreateAccount";
            this.buttonNewCreateAccount.Size = new System.Drawing.Size(253, 67);
            this.buttonNewCreateAccount.TabIndex = 0;
            this.buttonNewCreateAccount.Text = "Create new account";
            this.buttonNewCreateAccount.UseVisualStyleBackColor = true;
            this.buttonNewCreateAccount.Click += new System.EventHandler(this.buttonNewCreateAccount_Click);
            // 
            // comboBoxSelectAccount
            // 
            this.comboBoxSelectAccount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSelectAccount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSelectAccount.FormattingEnabled = true;
            this.comboBoxSelectAccount.Location = new System.Drawing.Point(448, 111);
            this.comboBoxSelectAccount.Name = "comboBoxSelectAccount";
            this.comboBoxSelectAccount.Size = new System.Drawing.Size(121, 33);
            this.comboBoxSelectAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Existing Account";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(153, 203);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(156, 60);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAccount.Location = new System.Drawing.Point(413, 203);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(190, 60);
            this.buttonDeleteAccount.TabIndex = 4;
            this.buttonDeleteAccount.Text = "Delete Account";
            this.buttonDeleteAccount.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectAccount);
            this.Controls.Add(this.buttonNewCreateAccount);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewCreateAccount;
        private System.Windows.Forms.ComboBox comboBoxSelectAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonDeleteAccount;
    }
}