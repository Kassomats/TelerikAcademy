using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestingFirst;

namespace UnitTestProject1
{
    [TestClass]
    public class LogAnalyzerTests

    {
        LogAnalyzer logan = new LogAnalyzer();

        [TestMethod]
        public void Loganalyzer_Should_ReturnTrue_WhenStringIsCorrect()
        {
            //arrange

            string testString = "asdf.SLF";
            //LogAnalyzer logan = new LogAnalyzer();

            //act
            bool result = logan.IsValidLogFileName(testString);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Loganalyzer_Should_ReturnTrue_WhenStringIsCorrectLowerCase()
        {
            //arrange

            string testString = "asdf.slf";
            //LogAnalyzer logan = new LogAnalyzer();

            //act
            bool result = logan.IsValidLogFileName(testString);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Loganalyzer_Should_ReturnFalse_WhenStringIsIncorrect()
        {
            //arrange

            string testString = "asdf.SLK";
            //LogAnalyzer logan = new LogAnalyzer();

            //act
            bool result = logan.IsValidLogFileName(testString);
            //assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        
        public void Loganalyzer_Should_ThrowException_WhenStringIsEmpty()
        {
            //arrange

            //act
            
            Assert.ThrowsException<ArgumentNullException>( () => logan.IsValidLogFileName("") );
   
        
            //assert
        }
    }
}
