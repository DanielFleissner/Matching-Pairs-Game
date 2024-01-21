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
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
            
            if (profiles.ProfileList.Count() == 0)
            {
                buttonReturnToLoginWindow.Visible = false;
            }
        }

        private void buttonCreateProfile_Click(object sender, EventArgs e)
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
                    profile = new Profiles.Profile(name);
                    profiles.Add(profile);
                    JsonMethods.UpdateSaveFile(profiles);
                    OpenForms.formToOpenNext = "LevelSelector";
                    this.Close();
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please Enter a profile name");
            }
        }

        private void buttonReturnToLoginWindow_Click(object sender, EventArgs e)
        {
            OpenForms.formToOpenNext = "Login";
            this.Close();
            this.Dispose();
        }
    }
}
