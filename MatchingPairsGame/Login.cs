using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace MatchingPairsGame
{
    public partial class Login : Form
    {
        Profiles profiles;
        public Login(Profiles profiles)
        {
            InitializeComponent();
            this.profiles = profiles;
            foreach (Profiles.Profile profile in profiles.ProfileList)
            {
                comboBoxSelectAccount.Items.Add(profile.Name);
            }
        }

        private void buttonNewCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateAccount(profiles).ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Profiles.Profile profile;
            
            if (comboBoxSelectAccount.SelectedItem == null)
            {
                if (comboBoxSelectAccount.Text == "")
                { 
                    MessageBox.Show("Please select a profile."); 
                }
                else
                {
                    MessageBox.Show("That profile does not exit.");
                }
            }
            else
            {   
                string name = (string)comboBoxSelectAccount.SelectedItem;
                if (profiles.Exists(name))
                {
                    profile = profiles.Find(name);
                    this.Hide();
                    new LevelSelector(profiles, profile).ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("That profile does not exist. Please try enter the name again.");
                }

            }

        }
    }
}
