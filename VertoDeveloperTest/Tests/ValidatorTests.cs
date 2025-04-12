using Microsoft.VisualStudio.TestTools.UnitTesting;
using VertoDeveloperTest.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace VertoDeveloperTest.Tests
{
    [TestClass]
    public class ValidatorTests
    {
        Validator validator = new Validator();
        String TestString = "";


        /*
         * bondary string
         */
        [TestMethod]
        public void testTitleMax()
        {
            TestString = "";
            TestString = TestString.PadRight(50, 'a');

            Assert.AreEqual("", validator.ValidateTitle(TestString));
        }
        [TestMethod]
        public void testTitleMaxPlusOne()
        {
            TestString = "";
            TestString = TestString.PadRight(51, 'a');
            Assert.AreEqual("Title is too long max length is 50 charcter", validator.ValidateTitle(TestString));
        }
        [TestMethod]
        public void testTitleMaxMinusOne()
        {
            TestString = "";
            TestString = TestString.PadRight(49, 'a');
            Assert.AreEqual("", validator.ValidateTitle(TestString));
        }
        [TestMethod]
        public void testTitleMinPlusOne()
        {
           
            
            Assert.AreEqual("", validator.ValidateTitle("aa"));
        }
        [TestMethod]
        public void testTitleMin()
        {
            
           
            Assert.AreEqual("", validator.ValidateTitle("a"));
        }
        [TestMethod]
        public void testTitleMinMinusOne()
        {
            
            
            Assert.AreEqual("title must be a string", validator.ValidateTitle(""));
        }


        /*
        * equilvent string
        */
        [TestMethod]
        public void testValidtitle()
        {
            // . and , used as the none A_Z options
            Assert.AreEqual("", validator.ValidateTitle("Mew.,?"));
        }
        [TestMethod]
        public void testInvalidTitleString()
        {
            Assert.AreEqual("only A-z 0-9 , . ? allowed", validator.ValidateTitle("100Charizards@242"));
        }
        [TestMethod]
        public void testTitleNullInput()
        {
            Assert.AreEqual("title must be a string", validator.ValidateTitle(null));
        }
        

    }
}
