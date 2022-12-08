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
    public partial class FormGameEntry : Form
    {
        public FormGameEntry()
        {
            InitializeComponent();
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
    }
}
