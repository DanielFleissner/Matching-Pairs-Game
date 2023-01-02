
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
            this.buttonCreateNewProfile = new System.Windows.Forms.Button();
            this.comboBoxSelectProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateNewProfile
            // 
            this.buttonCreateNewProfile.Location = new System.Drawing.Point(153, 302);
            this.buttonCreateNewProfile.Name = "buttonCreateNewProfile";
            this.buttonCreateNewProfile.Size = new System.Drawing.Size(253, 67);
            this.buttonCreateNewProfile.TabIndex = 0;
            this.buttonCreateNewProfile.Text = "Create new profile";
            this.buttonCreateNewProfile.UseVisualStyleBackColor = true;
            this.buttonCreateNewProfile.Click += new System.EventHandler(this.buttonCreateNewProfile_Click);
            // 
            // comboBoxSelectProfile
            // 
            this.comboBoxSelectProfile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxSelectProfile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSelectProfile.FormattingEnabled = true;
            this.comboBoxSelectProfile.Location = new System.Drawing.Point(448, 111);
            this.comboBoxSelectProfile.Name = "comboBoxSelectProfile";
            this.comboBoxSelectProfile.Size = new System.Drawing.Size(121, 33);
            this.comboBoxSelectProfile.TabIndex = 1;
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
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProfile.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteProfile.Location = new System.Drawing.Point(413, 203);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(190, 60);
            this.buttonDeleteProfile.TabIndex = 4;
            this.buttonDeleteProfile.Text = "Delete Profile";
            this.buttonDeleteProfile.UseVisualStyleBackColor = false;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDeleteProfile);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectProfile);
            this.Controls.Add(this.buttonCreateNewProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNewProfile;
        private System.Windows.Forms.ComboBox comboBoxSelectProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonDeleteProfile;
    }
}