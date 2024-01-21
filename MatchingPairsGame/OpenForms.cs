using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static MatchingPairsGame.Profiles;

namespace MatchingPairsGame
{
    internal static class OpenForms
    {
        static public string formToOpenNext;
                
        static public void OpenForm(){

            switch (formToOpenNext) 
            { 
                case "CreateProfile":
                    formToOpenNext = null;
                    new CreateProfile().ShowDialog();
                    break;
                case "Login":
                    formToOpenNext = null;
                    new Login().ShowDialog();
                    break;
                case "LevelSelector":
                    formToOpenNext = null;
                    new LevelSelector().ShowDialog();
                    break;   
                case "FormLevel1":
                    formToOpenNext = null;
                    new FormLevel1().ShowDialog();
                    break;
                case "FormLevel2":
                    formToOpenNext = null;
                    new FormLevel2().ShowDialog();
                    break;
                case "FormLevel3":
                    formToOpenNext = null;
                    new FormLevel3().ShowDialog();
                    break;
            }

        }

    }
}
