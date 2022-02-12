using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenNullReturnHappy()      //UC2 Given null mood return happy
        {
            //Arrange
            string msg = null;
            string expected = "happy";
            testException mood = new testException(msg);
            string actual = null;
            try
            {

                //Act
                 actual = mood.AnalyseMoodNullExcp();
            }
            catch (NullReferenceException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
            Assert.AreEqual(expected, actual);

        }
        [TestCategory("Exception")]
        [TestMethod]
        public void GivenNullMsgReturnException()
        {
            //Arrange
            string message = null;
            string expected = "Object reference not set to an instance of an object.";
            testException mood =new testException(message);
            string actual = null;
            try
            {
                //Act
                 actual = mood.AnalyseMoodNullExcp();
            }
            catch (NullReferenceException excpt)
            {
                //Assert
                Assert.AreEqual(expected, excpt.Message);

            }

        }
        [TestCategory("Exception Using Enum")]
        [TestMethod]
        public void GivenNullMsgReturnCustomExcpt()
        {
            //Arrange
            string msg = null;
            string expected = "Message should not be null";
            testException mood = new testException(msg);
            try
            {
                //Act
                string actual = mood.AnalyseMoodUsingEnum();
            }
            //catch(NullReferenceException excpt)
            //{
            //    //Assert
            //    Assert.AreEqual(expected, excpt.Message);
            //}
            catch(CustomMoodAnalyserException expt)
            {
                Assert.AreEqual(expected, expt.Message);
            }
        }
    }
}
