using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static MatchingPairsGame.GlobalProfiles;

namespace MatchingPairsGame
{
    class GameEngine
    {
        Label[] clickedLabels;
        int keypressCounterWin = 0;
        int keypressCounterPeek = 0;
        Random random = new Random();
        int labelCount;
        Color[] originalColorStates;
        TimeSpan startTime = new TimeSpan(0, 0, 0);
        TimeSpan timeIncrement = new TimeSpan(0, 0, 1);
        TimeSpan gameTime;
        int turnCount = 0;
        int clickCounter = 0;
        int clickCounterAtTime = 0;
        Form gameForm;
        TableLayoutPanel tableLayoutPanel1;
        Timer timer1;
        Timer timerGame;
        Label labelTurnCount;
        Label labelGameTime;
        List<string> icons;
        int numberOfLabelsToMatch;
        Timer timerPeek = new Timer();
        Label labelPeek;
        
        LevelPeformanceSpecs level;

        public GameEngine(Form gameForm, System.ComponentModel.IContainer components, List<string> icons, int numberOfLabelsToMatch, LevelPeformanceSpecs level)
        {
            this.level = level;
            this.gameForm = gameForm;
            this.icons = icons;
            Control.ControlCollection controls = gameForm.Controls;
            tableLayoutPanel1 = (TableLayoutPanel)controls["tableLayoutPanel1"];
            labelTurnCount = (Label)controls["labelTurnCount"];
            labelGameTime = (Label)controls["labelGameTime"];
            timer1 = (Timer)components.Components[0];
            timerGame = (Timer)components.Components[1];
            timerPeek.Interval = 3000;
            timerPeek.Tick += new System.EventHandler(TimerPeek_Tick);

            labelCount = tableLayoutPanel1.Controls.Count;
            originalColorStates = new Color[labelCount];

            labelGameTime.Text = startTime.ToString();
            labelTurnCount.Text = turnCount.ToString();
            this.numberOfLabelsToMatch = numberOfLabelsToMatch;
            clickedLabels = new Label[numberOfLabelsToMatch];

            timer1.Tick += new System.EventHandler(Timer1_Tick);
            timerGame.Tick += new System.EventHandler(TimerGame_Tick);
            labelPeek = (Label)controls["labelPeek"];
            labelPeek.Click += new System.EventHandler(ButtonPeek_Click);
            gameForm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(Form_KeyPress);
            gameForm.FormClosing += new FormClosingEventHandler(FormClosing_Event);
            gameForm.FormClosed += new FormClosedEventHandler(FormClosed_Event);

            foreach (Label iconLabel in tableLayoutPanel1.Controls)
            {
                iconLabel.Click += new System.EventHandler(Label_click);
            }
            AssignIconsToSquares();
        }

        private void FormClosing_Event(object sender, FormClosingEventArgs e)
        {
            OpenForms.formToOpenNext = "LevelSelector";     
        }
        private void FormClosed_Event(object sender, FormClosedEventArgs e)
        {
            gameForm.Dispose();
        }
        
        public void AssignIconsToSquares()
        {
            foreach (Label iconLabel in tableLayoutPanel1.Controls)
            {   
                int randomNumber = random.Next(icons.Count);
                iconLabel.Text = icons[randomNumber];
                iconLabel.ForeColor = iconLabel.BackColor;
                icons.RemoveAt(randomNumber);
            }
        }

        void ButtonPeek_Click(object sender, EventArgs e)
        {
            
            Peek(); 
   
        }

        void Label_click(object sender, EventArgs e)
        {
            if (!timerGame.Enabled)
            {
                timerGame.Start();
            }

            if (timerPeek.Enabled)
            {
                ReapplyColors();
            }

            Label clickedLabel = (Label)sender;

            if (clickedLabel.ForeColor != Color.Black)
            {
                if (timer1.Enabled)
                {
                    Timer1_Tick(sender, e);
                }

                clickedLabel.ForeColor = Color.Black;
                clickedLabels[clickCounter] = clickedLabel;

                clickCounter++;

                if (clickCounter > 1)
                {
                    bool clickedIconsMatch = ClickedIconsMatch();

                    if (!clickedIconsMatch)
                    {
                        turnCount++;
                        labelTurnCount.Text = turnCount.ToString();
                        clickCounterAtTime = clickCounter;
                        clickCounter = 0;
                        timer1.Start();
                    }

                    if (clickCounter == numberOfLabelsToMatch) 
                    {
                        clickCounter = 0;
                        turnCount++;
                        labelTurnCount.Text = turnCount.ToString();

                        if (clickedIconsMatch)
                        {
                            CheckForWinner();
                        }
                    }
                }
            }
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            for (int i = 0; i < clickCounterAtTime; ++i)
            {
                Label clickedLabel = clickedLabels[i];
                clickedLabel.ForeColor = clickedLabel.BackColor;
            }
        }

        bool ClickedIconsMatch()
        {
            for (int i = 1; i < clickCounter; ++i)
            {
                if (clickedLabels[i].Text != clickedLabels[0].Text)
                {
                    return false;
                }
            }
            return true;
        }

        public void CheckForWinner()
        {
            foreach (Label iconLabel in tableLayoutPanel1.Controls)
            {
                if (iconLabel.ForeColor == iconLabel.BackColor)
                    return;
            }
            timerGame.Stop();
            MessageBox.Show("You matched all the icons!", "Congratulations!");
            //only update turn count if it is less than the previous highscore.
            if (level.Turns == 0 || level.Turns > turnCount || level.Turns == turnCount && level.Time > gameTime)
            {
                profile.highScores.Update(level, turnCount, gameTime);
            }
            JsonMethods.UpdateSaveFile(profiles);
            OpenForms.formToOpenNext = "LevelSelector";
            gameForm.Close();
        }

        public void SetAllIconsToBlack()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                Control control = tableLayoutPanel1.Controls[i];
                Label iconLabel = (Label)control;
                iconLabel.ForeColor = Color.Black;
            }
        }

        public void SetIconPeekColors()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (originalColorStates[i] != Color.Black)
                {
                    Control control = tableLayoutPanel1.Controls[i];
                    Label iconLabel = (Label)control;
                    iconLabel.ForeColor = Color.Gray;
                }
            }
            if (!timerGame.Enabled)
            {
                timerGame.Start();
            }
        }

        void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (timerPeek.Enabled)
            {
                ReapplyColors();
            }
            char pressedKey = e.KeyChar;
            CheatPhraseTest(pressedKey, "win", ref keypressCounterWin);
            CheatPhraseTest(pressedKey, "peek", ref keypressCounterPeek);
        }

        public void CheatPhraseTest(char pressedkey, string testPhrase, ref int keypressCounter)
        {
            if (testPhrase[keypressCounter] == pressedkey)
            {
                keypressCounter++;
                if (keypressCounter == testPhrase.Length)
                {
                    CheatAction(testPhrase);
                    keypressCounter = 0;
                }
            }
            else
            {
                keypressCounter = 0;
            }
        }

        public void CheatAction(string testPhrase)
        {
            switch (testPhrase)
            {
                case "win":
                    SetAllIconsToBlack();
                    CheckForWinner();
                    break;
                case "peek":
                    Peek();
                    break;
            }
        }

        void Peek()
        {
            if (!timerPeek.Enabled)
            {
                RecordPanelStateBeforePeek();
                SetIconPeekColors();
                timerPeek.Start();
                //plus 5 to turn count as peek penalty
                turnCount += 5;
                labelTurnCount.Text = turnCount.ToString();
            }
        }

        public void RecordPanelStateBeforePeek()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                Control control = tableLayoutPanel1.Controls[i];
                Label iconLabel = (Label)control;
                originalColorStates[i] = iconLabel.ForeColor;
            }
        }

        public void ReapplyColors()
        {
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                Control control = tableLayoutPanel1.Controls[i];
                Label iconLabel = (Label)control;
                iconLabel.ForeColor = originalColorStates[i];
            }
            timerPeek.Stop();
        }

        public void TimerGame_Tick(object sender, EventArgs e)
        {
            gameTime += timeIncrement;
            labelGameTime.Text = gameTime.ToString();
        }

        void TimerPeek_Tick(object sender, EventArgs e)
        {
            timerPeek.Stop();
            ReapplyColors();
        }
    }
}
