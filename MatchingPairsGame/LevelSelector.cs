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

        private void ButtonLevel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLevel1().ShowDialog();
            this.Show();
        }

        private void ButtonLevel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLevel2().ShowDialog();
            this.Show();
        }

        private void ButtonLevel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLevel3().ShowDialog();
            this.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login(profiles).ShowDialog();
            this.Close();
        }
    }
}
