using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;




namespace UnitTesting.Tests
{
    [TestClass]
    class ProgramShould
    {
        [TestMethod]
        public void Reverse_Should()
        {
            //arrange
            string expected = "4321";
            string toRev = "1234";
            //act

            string sd = prog Reverser()

            //assert
            Assert.AreEqual(expected, toRev);
        }

        
    }
}
