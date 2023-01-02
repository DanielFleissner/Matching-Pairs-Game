using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Profiles profiles = JsonMethods.Profiles();

            if (profiles.ProfileList.Count() == 0)
            {
                new CreateProfile(profiles).ShowDialog();
            }
            else
            {
                new Login(profiles).ShowDialog();
            }
        }
    }
}
