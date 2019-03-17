using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dog_Race_Competition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_Race_Competition.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void total()
        {
            PlayerSet obj = new PlayerSet("Chirag",90,12,1,2);
            obj.totAmt();

            Assert.Fail();
        }


        [TestMethod()]
        public void race()
        {
            race obj = new race();
            obj.run1(2);

            Assert.Fail();
        }




    }
}