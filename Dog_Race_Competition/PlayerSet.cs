using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race_Competition
{
    public class PlayerSet
    {
        //global variable 
        public String Player = "";
        public int Amount = 0;
        public int Bet = 0;
        public int winner = 0;
        public int dog = 0;
        // setter method of all the global variable which ae use to pass the local value to the global variable for better functionality
        public void setPlayer(String Player)
        {
            //this is default keyword that is used to pass the value from local to global
            this.Player = Player;
        }
        public void setAmount(int Amount)
        {
            //this is default keyword that is used to pass the value from local to global
            this.Amount = Amount;
        }
        public void setBet(int Bet)
        {
            //this is default keyword that is used to pass the value from local to global
            this.Bet = Bet;
        }
        public void setWinner(int Winner)
        {
            //this is default keyword that is used to pass the value from local to global
            this.winner = Winner;
        }
        public void setDog(int dog)
        {
            //this is default keyword that is used to pass the value from local to global
            this.dog = dog;
        }

        // constructor with argument that is used to sent the the value to other method that is used in the concept of the setter format
        public PlayerSet(string Player, int Amount, int Bet, int winner, int dog)
        {
            setPlayer(Player);
            setAmount(Amount);
            setBet(Bet);
            setWinner(winner);
            setDog(dog);

        }
        //calculate the total amount after finishing the game if the player is winner then his amount will increased otherwise it will dereased automatically from his account
        public int totAmt()
        {
            if (dog == winner)
            {
                Amount += Bet;
                return Amount;
            }
            else
            {
                Amount -= Bet;
                return Amount;
            }
        }
        public int resetPlayer()
        {
            return 416;
        }



    }
}
