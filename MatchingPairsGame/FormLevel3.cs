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
    public partial class FormLevel3 : System.Windows.Forms.Form
    {
        public FormLevel3(Profiles profiles, Profiles.Profile profile)
        {
            InitializeComponent();
            List<string> icons = new List<string>()
            {
                "!", "!","!", "!", "N", "N", "N","N", ",", ",", ",", ",", "k", "k","k", "k",
                "b", "b", "b", "b", "v", "v", "v", "v", "w", "w", "w", "w", "z", "z", "z", "z", "a", "a", "a", "a"
            };
            new GameEngine(this, components, icons, 4, profiles, profile, profile.highScores.level3);
        }
    }
}