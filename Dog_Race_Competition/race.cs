using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race_Competition
{
   public class race
    {
        Random rd = new Random();

        // run method to run the dog first using Random class
        public int run1(int y)
        {
            return rd.Next(1, y);
        }

        // run method to run the dog 2nd using Random class
        public int run2(int y)
        {
            return rd.Next(1, y);
        }

        // run method to run the dog 3rd using Random class
        public int run3(int y)
        {
            return rd.Next(1, y);
        }


    }
}
