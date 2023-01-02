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
    public partial class FormLevel1 : System.Windows.Forms.Form
    {
        public FormLevel1(Profiles profiles, Profiles.Profile profile)
        {
            InitializeComponent();
            List<string> icons = new List<string>()
            {
                "!", "!", "N", "N", ",", ",", "k", "k",
                "b", "b", "v", "v", "w", "w", "z", "z"
            };
            new GameEngine(this, components, icons, 2, profiles, profile, profile.highScores.level1);
        }
    }
}