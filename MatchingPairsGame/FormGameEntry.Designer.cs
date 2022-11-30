
namespace MatchingPairsGame
{
    partial class FormGameEntry
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
            this.buttonLevel2.Location = new System.Drawing.Point(55, 207);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Size = new System.Drawing.Size(307, 76);
            this.buttonLevel2.TabIndex = 1;
            this.buttonLevel2.Text = "Level 2";
            this.buttonLevel2.UseVisualStyleBackColor = true;
            this.buttonLevel2.Click += new System.EventHandler(this.ButtonLevel2_Click);
            // 
            // buttonLevel3
            // 
            this.buttonLevel3.Location = new System.Drawing.Point(55, 311);
            this.buttonLevel3.Name = "buttonLevel3";
            this.buttonLevel3.Size = new System.Drawing.Size(307, 76);
            this.buttonLevel3.TabIndex = 2;
            this.buttonLevel3.Text = "Level 3";
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
            this.labelLevel1TopScore.Location = new System.Drawing.Point(459, 128);
            this.labelLevel1TopScore.Name = "labelLevel1TopScore";
            this.labelLevel1TopScore.Size = new System.Drawing.Size(177, 25);
            this.labelLevel1TopScore.TabIndex = 4;
            this.labelLevel1TopScore.Text = "Level 1 top score";
            // 
            // labelLevel2TopScore
            // 
            this.labelLevel2TopScore.AutoSize = true;
            this.labelLevel2TopScore.Location = new System.Drawing.Point(459, 233);
            this.labelLevel2TopScore.Name = "labelLevel2TopScore";
            this.labelLevel2TopScore.Size = new System.Drawing.Size(177, 25);
            this.labelLevel2TopScore.TabIndex = 5;
            this.labelLevel2TopScore.Text = "Level 2 top score";
            // 
            // labelLevel3TopScore
            // 
            this.labelLevel3TopScore.AutoSize = true;
            this.labelLevel3TopScore.Location = new System.Drawing.Point(459, 337);
            this.labelLevel3TopScore.Name = "labelLevel3TopScore";
            this.labelLevel3TopScore.Size = new System.Drawing.Size(177, 25);
            this.labelLevel3TopScore.TabIndex = 6;
            this.labelLevel3TopScore.Text = "Level 2 top score";
            // 
            // FormGameEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.labelLevel3TopScore);
            this.Controls.Add(this.labelLevel2TopScore);
            this.Controls.Add(this.labelLevel1TopScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLevel3);
            this.Controls.Add(this.buttonLevel2);
            this.Controls.Add(this.buttonLevel1);
            this.Name = "FormGameEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matching Pairs Game Level Selector";
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
    }
}