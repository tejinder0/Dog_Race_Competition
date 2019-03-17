using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dog_Race_Competition
{
    public partial class Form1 : Form
    {
        private int tmr = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr++;
            //generate the Sound at the Starting Point
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("Sound/Sound.wav");
            player.Play();

            //display the another form after few seconds
            if (tmr == 30)
            {

                timer1.Enabled = false;
                RaceYard obj = new RaceYard();
                obj.Visible = true;
                this.Hide();
                player.Stop();
            }
        }


    }
}

