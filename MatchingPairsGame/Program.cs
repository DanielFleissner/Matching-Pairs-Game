using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MatchingPairsGame.GlobalProfiles;

namespace MatchingPairsGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (profiles.ProfileList.Count() == 0)
            {
                new CreateProfile().ShowDialog();
            }
            else
            {
                new Login().ShowDialog();
            }
            while (OpenForms.formToOpenNext!=null)
            {
                OpenForms.OpenForm();
            }
        }
    }
}
