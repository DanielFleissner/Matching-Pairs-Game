using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MatchingPairsGame.GlobalProfiles;

namespace MatchingPairsGame
{
    public partial class LevelSelector : Form
    {

        public LevelSelector()
        {
            InitializeComponent();
            LableUserName.Text = profile.Name;        
        }
        
        private string HighScoreToString (int level)
        {
            LevelPeformanceSpecs Level;

            switch (level) 
            {
                case 1:
                    Level = profile.highScores.level1;
                    break;
                case 2:
                    Level = profile.highScores.level2;
                    break;
                case 3:
                    Level = profile.highScores.level3;
                    break;
                default:
                    Level = null;
                    break;
            }

            string turnCount = Level.Turns.ToString();
            string time = Level.Time.ToString();
            string score;

            if (Level.Turns == 0)
            {
                score = "No score yet";
            }
            else
            {
                score = "Turns: " + turnCount + " Duration: " + time;
            }
            return score;
        }

        private void ButtonLevel1_Click(object sender, EventArgs e)
        {
            OpenForms.formToOpenNext = "FormLevel1";  
            this.Close();
            this.Dispose();
        }

        private void ButtonLevel2_Click(object sender, EventArgs e)
        {
            OpenForms.formToOpenNext = "FormLevel2";
            this.Close();
            this.Dispose();
        }

        private void ButtonLevel3_Click(object sender, EventArgs e)
        {
            OpenForms.formToOpenNext = "FormLevel3";
            this.Close();
            this.Dispose();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            OpenForms.formToOpenNext = "Login";
            this.Close();
            this.Dispose();
        }

        private void LevelSelector_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible)
            {
                labelLevel1TopScoreValue.Text = HighScoreToString(1);
                labelLevel2TopScoreValue.Text = HighScoreToString(2);
                labelLevel3TopScoreValue.Text = HighScoreToString(3);

                if (profile.highScores.level1.Turns < 25 && profile.highScores.level1.Turns != 0)
                {
                    buttonLevel2.Enabled = true;
                    buttonLevel2.Text = "Level 2";
                }

                if (profile.highScores.level2.Turns < 50 && profile.highScores.level2.Turns != 0)
                {
                    buttonLevel3.Enabled = true;
                    buttonLevel3.Text = "Level 3";
                }
            }
        }
    }
}
