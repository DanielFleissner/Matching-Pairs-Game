﻿using System;
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
                comboBoxSelectProfile.Items.Add(profile.Name);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Profiles.Profile profile;
            
            if (comboBoxSelectProfile.SelectedItem == null)
            {
                if (comboBoxSelectProfile.Text == "")
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
                string name = (string)comboBoxSelectProfile.SelectedItem;
                profile = profiles.Find(name);
                this.Hide();
                new LevelSelector(profiles, profile).ShowDialog();
                this.Close();
            }
        }

        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            Profiles.Profile profile;

            if (comboBoxSelectProfile.SelectedItem == null)
            {
                if (comboBoxSelectProfile.Text == "")
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
                DialogResult dialogResult = MessageBox.Show("Do you want to delete this profile?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    string name = (string)comboBoxSelectProfile.SelectedItem;
                    profile = profiles.Find(name);
                    profiles.Remove(profile);
                    JsonMethods.UpdateSaveFile(profiles);
                    comboBoxSelectProfile.Items.Remove(profile.Name);
                    comboBoxSelectProfile.Text = "";
                }
            }
        }

        private void buttonCreateNewProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CreateProfile(profiles).ShowDialog();
            this.Close();
        }
    }
}
