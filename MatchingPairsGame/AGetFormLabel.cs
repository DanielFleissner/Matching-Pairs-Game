using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public abstract class AGetFormLabel : System.Windows.Forms.Form
{
    public Label[] clickedLabels = new Label[3];
    public int keypressCounterWin = 0;
    public int keypressCounterPeak = 0;
    public bool peakEnabled = false;
    public Random random = new Random();
    public int labelCount;
    public Color[] originalColorStates;
    public TimeSpan startTime = new TimeSpan(0, 0, 0);
    public TimeSpan timeIncrement = new TimeSpan(0, 0, 1);
    public TimeSpan gameTime;
    public int turnCount = 0;
    public int clickCounter = 0;
    public Timer timerGame;
    public TableLayoutPanel tableLayoutPanel1;
    public Label labelGameTime;
    public Label labelTurnCount;

    public List<string> icons;// = new List<string>();
    //{
    //    "!", "!","!", "N", "N","N",",", ",", ",", "k", "k","k",
    //    "b", "b", "b", "v", "v", "v", "w", "w", "w", "z", "z", "z", "a", "a", "a", "c", "c", "c", "d", "d", "d", "e", "e", "e"
    //};

    //public abstract Label GetLabel(int i);
    //public abstract TableLayoutPanel GetPanel();

}
