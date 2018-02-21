using Cosmetics.Products;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmetics.Tests
{
    [TestClass]
    public class Product_Should
    {
        [TestMethod]
        public void ThrowException_When_NameUnderExpectedLength()
        {
            //arrange //act
           

            //assert
           
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Product("te", "test", 50, Common.GenderType.Men));
        }
        [TestMethod]
        public void ThrowException_When_NameOverExpectedLength()
        {
            //arrange //act
            

            //assert

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Product("12345678901", "test", 50, Common.GenderType.Men));
        }

    }
}
