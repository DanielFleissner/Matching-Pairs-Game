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
    public partial class CreateAccount : Form
    {
        Profiles profiles;
        public CreateAccount(Profiles profiles)
        {
            InitializeComponent();
            this.profiles = profiles;
            if (profiles.ProfileList.Count == 0)
            {
                buttonReturnToLoginWindow.Visible = false;
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            string name = textBoxUserName.Text;
            if (name != "")
            {
                name.Trim();

                if(profiles.Exists(name))
                {
                    MessageBox.Show("This profile already exists. Please enter a different name or return to the login page.");
                }
                else
                {
                    Profiles.Profile profile = new Profiles.Profile(name);
                    profiles.Add(profile);
                    JsonMethods.UpdateSaveFile(profiles);
                    this.Hide();
                    new LevelSelector(profiles, profile).ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Enter a profile name");
            }
        }

        private void buttonReturnToLoginWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login(profiles).ShowDialog();
            this.Close();
        }
    }
}
