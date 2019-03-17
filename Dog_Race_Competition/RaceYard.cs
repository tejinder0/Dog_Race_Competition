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
    //user define Interface that is used to get the No of the Winning Dog
    public interface winningDog
    {
        int win(int args);
    }

    public partial class RaceYard : Form,winningDog
    {
        //global variable to keep the Record of the player to access in the whole block
        private int Amt1 = 90, Amt2 = 110, Amt3 = 100;
        private int player1 = 0, player2 = 0, player3 = 0;
        private int dog1 = 0, dog2 = 0, dog3 = 0;
        private int bet1 = 0, bet2 = 0, bet3 = 0;
        private int winngdog = 0;
        //creating the object of the class that is used for ruuning the dog in the game
        race obj = new race();

        public RaceYard()
        {
            InitializeComponent();
        }


        //2nd player set the bet 
        private void Jaspreet_Click(object sender, EventArgs e)
        {
            if (!cbDog.Text.Equals("") && nmBetAmount.Value > 10 && nmBetAmount.Value <= 110)
            {
                ScndPlayer.Text = "Jaspreet set the Bet of " + nmBetAmount.Value + " Dollar at Dog " + cbDog.SelectedItem.ToString();
                player2 = 1;
                bet2 = Convert.ToInt32(nmBetAmount.Value);
                dog2 = Convert.ToInt32(cbDog.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("First select the Dog and set the Bet Amount and then set the Bet Amount");
            }

        }
        //3rd player set the bet after clicking on the label
        private void Ankush_Click(object sender, EventArgs e)
        {
            if (!cbDog.Text.Equals("") && nmBetAmount.Value > 10 && nmBetAmount.Value <= 100)
            {
                ThrdPlayer.Text = "Ankush set the Bet of " + nmBetAmount.Value + " Dollar at Dog " + cbDog.SelectedItem.ToString();
                player3 = 1;
                bet3 = Convert.ToInt32(nmBetAmount.Value);
                dog3 = Convert.ToInt32(cbDog.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("First select the Dog and set the Bet Amount and then set the Bet Amount");
            }

        }


        //timer used to move the position of the dog in the game with the help of other class method
        private void timer1_Tick(object sender, EventArgs e)
        {
            // till then the dog reach the finishing line the dog will move forward when one is reach at the top then other will stop and game is over and all the dog move to there starting position
            if (Dog1.Top >= 10)
            {
                Dog1.Top -= obj.run1(50);
            }
            else
            {
                timer1.Enabled = false;
                winngdog = 1;
                MessageBox.Show(" Dog " + win(1) + " is Winner ");
                resetAmount();

            }

            if (Dog2.Top >= 10)
            {
                Dog2.Top -= obj.run1(50);
            }
            else
            {
                timer1.Enabled = false;
                winngdog = 2;
                MessageBox.Show(" Dog " + win(2) + " is Winner ");
                resetAmount();
            }


            if (Dog3.Top >= 10)
            {
                Dog3.Top -= obj.run1(50);
            }
            else
            {
                timer1.Enabled = false;
                winngdog = 3;
                MessageBox.Show(" Dog " + win(3) + " is Winner ");
                resetAmount();
            }


        }



        //after setting the bet click on the race button to start the race
        private void Race_Click(object sender, EventArgs e)
        {
            //if any one of the player set the bet then the rece will start otherwise race will not start
            if (player1 == 1 || player2 == 1 || player3 == 1)
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("First Select the Bet");
            }
        }


        // after finishing the game all the Dog must have to go there starting position that is used to the Reset the Amount of hte player and position of the dog
        public void resetAmount()
        {
            if (player1 == 1)
            {
                // if first player set the bet then his values pass to the constructor of the Playerset which is used to find the Winner of the game and give to amount to the account of the player
                PlayerSet obj = new PlayerSet("Chirag", Amt1, bet1, winngdog, dog1);
                //get the value after winning or loosing the game
                Amt1 = obj.totAmt();

                //reset the label after finishing the game 
                Chirag.Text = "Chirag has " + Amt1 + " Dollar to Play";
                FrstPlayer.Text = Chirag.Text;
                //reset the position of the dog 
                Dog1.Top = 416;
                Dog2.Top = 416;
                Dog3.Top = 416;
                nmBetAmount.Value = 0;
                cbDog.Text = "";

            }
            if (player2 == 1)
            {
                // if 2nd player set the bet then his values pass to the constructor of the Playerset which is used to find the Winner of the game and give to amount to the account of the player

                PlayerSet obj = new PlayerSet("Jaspreet", Amt2, bet2, winngdog, dog2);
                //get the value after winning or loosing the game
                Amt2 = obj.totAmt();
                //reset the label after finishing the game 
                Jaspreet.Text = "Jaspreet has " + Amt2 + " Dollar to Play";

                ScndPlayer.Text = Jaspreet.Text;
                //reset the position of the dog 
                Dog1.Top = 416;
                Dog2.Top = 416;
                Dog3.Top = 416;
                nmBetAmount.Value = 0;
                cbDog.Text = "";

            }

            if (player3 == 1)
            {
                // if 3rd player set the bet then his values pass to the constructor of the Playerset which is used to find the Winner of the game and give to amount to the account of the player

                PlayerSet obj = new PlayerSet("Ankush", Amt3, bet3, winngdog, dog3);
                //get the value after winning or loosing the game
                Amt3 = obj.totAmt();
                //reset the label after finishing the game 
                Ankush.Text = "Ankush has " + Amt3 + " Dollar to Play";

                ThrdPlayer.Text = Ankush.Text;

                //reset the position of the dog 
                Dog1.Top = 416;
                Dog2.Top = 416;
                Dog3.Top = 416;
                nmBetAmount.Value = 0;
                cbDog.Text = "";

            }


        }

        //initlizing the interface method to do the work
        public int win(int args)
        {
            return args;
        }
        //click event of the First Player 

        private void Chirag_Click(object sender, EventArgs e)
        {
            //verfy the  Dog No andBet amount before applying the Bet and pass the bet amount and dog no to the GLobal Variable to access
            if (!cbDog.Text.Equals("") && nmBetAmount.Value > 10 && nmBetAmount.Value <= 90)
            {

                FrstPlayer.Text = "Chirag Set the Bet of " + nmBetAmount.Value + " Dollar at Dog " + cbDog.SelectedItem.ToString();
                player1 = 1;
                bet1 = Convert.ToInt32(nmBetAmount.Value);
                dog1 = Convert.ToInt32(cbDog.SelectedItem.ToString());
            }
            else
            {
                //display the error Message
                MessageBox.Show("First select the Dog and set the Bet Amount and then set the Bet Amount");
            }

        }



    }
}
