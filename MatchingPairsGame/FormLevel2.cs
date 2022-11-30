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
    public partial class FormLevel2 : System.Windows.Forms.Form
    {
        public FormLevel2()
        {
            InitializeComponent();
            List<string> icons = new List<string>()
            {
                "!", "!","!", "N", "N","N",",", ",", ",", "k", "k","k",
                "b", "b", "b", "v", "v", "v", "w", "w", "w", "z", "z", "z", "a", "a", "a", "c", "c", "c", "d", "d", "d", "e", "e", "e"
            };
            new GameEngine(this, components, icons, 3);
        }
    }
}