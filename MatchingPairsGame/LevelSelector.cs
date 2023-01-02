using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingPairsGame
{
    public partial class LevelSelector : Form
    {
        Profiles profiles;
        Profiles.Profile profile; 
        public LevelSelector(Profiles profiles, Profiles.Profile profile)
        {
            InitializeComponent();
            this.profiles = profiles;
            this.profile = profile;
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
            this.Hide();
            new FormLevel1(profiles, profile).ShowDialog();
            this.Show();
        }

        private void ButtonLevel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLevel2(profiles, profile).ShowDialog();
            this.Show();
        }

        private void ButtonLevel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLevel3(profiles, profile).ShowDialog();
            this.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            new Login(profiles).ShowDialog();
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
