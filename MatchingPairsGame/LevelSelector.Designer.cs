
namespace MatchingPairsGame
{
    partial class LevelSelector
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
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonLevel3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLevel1TopScore = new System.Windows.Forms.Label();
            this.labelLevel2TopScore = new System.Windows.Forms.Label();
            this.labelLevel3TopScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LableUserName = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelLevel1TopScoreValue = new System.Windows.Forms.Label();
            this.labelLevel2TopScoreValue = new System.Windows.Forms.Label();
            this.labelLevel3TopScoreValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.Location = new System.Drawing.Point(55, 102);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Size = new System.Drawing.Size(307, 76);
            this.buttonLevel1.TabIndex = 0;
            this.buttonLevel1.Text = "Level 1";
            this.buttonLevel1.UseVisualStyleBackColor = true;
            this.buttonLevel1.Click += new System.EventHandler(this.ButtonLevel1_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.Enabled = false;
            this.buttonLevel2.Location = new System.Drawing.Point(55, 207);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(307, 76);
            this.buttonLevel2.TabIndex = 1;
            this.buttonLevel2.Text = "Level 2 (Locked)";
            this.buttonLevel2.UseVisualStyleBackColor = true;
            this.buttonLevel2.Click += new System.EventHandler(this.ButtonLevel2_Click);
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.Enabled = false;
            this.buttonLevel3.Location = new System.Drawing.Point(55, 311);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(307, 76);
            this.buttonLevel3.TabIndex = 2;
            this.buttonLevel3.Text = "Level 3 (Locked)";
            this.buttonLevel3.UseVisualStyleBackColor = true;
            this.buttonLevel3.Click += new System.EventHandler(this.ButtonLevel3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Level:";
            // 
            // labelLevel1TopScore
            // 
            this.labelLevel1TopScore.AutoSize = true;
            this.labelLevel1TopScore.Location = new System.Drawing.Point(435, 113);
            this.labelLevel1TopScore.Name = "labelLevel1TopScore";
            this.labelLevel1TopScore.Size = new System.Drawing.Size(177, 25);
            this.labelLevel1TopScore.TabIndex = 4;
            this.labelLevel1TopScore.Text = "Level 1 top score";
            // 
            // labelLevel2TopScore
            // 
            this.labelLevel2TopScore.AutoSize = true;
            this.labelLevel2TopScore.Location = new System.Drawing.Point(435, 218);
            this.labelLevel2TopScore.Name = "labelLevel2TopScore";
            this.labelLevel2TopScore.Size = new System.Drawing.Size(177, 25);
            this.labelLevel2TopScore.TabIndex = 5;
            this.labelLevel2TopScore.Text = "Level 2 top score";
            // 
            // labelLevel3TopScore
            // 
            this.labelLevel3TopScore.AutoSize = true;
            this.labelLevel3TopScore.Location = new System.Drawing.Point(435, 322);
            this.labelLevel3TopScore.Name = "labelLevel3TopScore";
            this.labelLevel3TopScore.Size = new System.Drawing.Size(177, 25);
            this.labelLevel3TopScore.TabIndex = 6;
            this.labelLevel3TopScore.Text = "Level 3 top score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Logged in as: ";
            // 
            // LableUserName
            // 
            this.LableUserName.AutoSize = true;
            this.LableUserName.Location = new System.Drawing.Point(214, 9);
            this.LableUserName.Name = "LableUserName";
            this.LableUserName.Size = new System.Drawing.Size(57, 25);
            this.LableUserName.TabIndex = 8;
            this.LableUserName.Text = "User";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(640, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(111, 46);
            this.buttonLogOut.TabIndex = 9;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelLevel1TopScoreValue
            // 
            this.labelLevel1TopScoreValue.AutoSize = true;
            this.labelLevel1TopScoreValue.Location = new System.Drawing.Point(435, 141);
            this.labelLevel1TopScoreValue.Name = "labelLevel1TopScoreValue";
            this.labelLevel1TopScoreValue.Size = new System.Drawing.Size(133, 25);
            this.labelLevel1TopScoreValue.TabIndex = 10;
            this.labelLevel1TopScoreValue.Text = "No score yet";
            // 
            // labelLevel2TopScoreValue
            // 
            this.labelLevel2TopScoreValue.AutoSize = true;
            this.labelLevel2TopScoreValue.Location = new System.Drawing.Point(435, 246);
            this.labelLevel2TopScoreValue.Name = "labelLevel2TopScoreValue";
            this.labelLevel2TopScoreValue.Size = new System.Drawing.Size(133, 25);
            this.labelLevel2TopScoreValue.TabIndex = 11;
            this.labelLevel2TopScoreValue.Text = "No score yet";
            // 
            // labelLevel3TopScoreValue
            // 
            this.labelLevel3TopScoreValue.AutoSize = true;
            this.labelLevel3TopScoreValue.Location = new System.Drawing.Point(435, 350);
            this.labelLevel3TopScoreValue.Name = "labelLevel3TopScoreValue";
            this.labelLevel3TopScoreValue.Size = new System.Drawing.Size(133, 25);
            this.labelLevel3TopScoreValue.TabIndex = 12;
            this.labelLevel3TopScoreValue.Text = "No score yet";
            // 
            // LevelSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.labelLevel3TopScoreValue);
            this.Controls.Add(this.labelLevel2TopScoreValue);
            this.Controls.Add(this.labelLevel1TopScoreValue);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.LableUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLevel3TopScore);
            this.Controls.Add(this.labelLevel2TopScore);
            this.Controls.Add(this.labelLevel1TopScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLevel3);
            this.Controls.Add(this.buttonLevel2);
            this.Controls.Add(this.buttonLevel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LevelSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Pairs Game Level Selector";
            this.VisibleChanged += new System.EventHandler(this.LevelSelector_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonLevel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLevel1TopScore;
        private System.Windows.Forms.Label labelLevel2TopScore;
        private System.Windows.Forms.Label labelLevel3TopScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LableUserName;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelLevel1TopScoreValue;
        private System.Windows.Forms.Label labelLevel2TopScoreValue;
        private System.Windows.Forms.Label labelLevel3TopScoreValue;
    }
}