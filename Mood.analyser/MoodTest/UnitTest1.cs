using NUnit.Framework;
using MoodAnalyser;

namespace MoodTest
{
    public class Tests
    {
        [Test]
        public void WhenGivenClassName_ReturnsObject()
        {
            //Arrange
            string expected = "MoodAnalyser.MoodAnalyserr";
            //Act
            object result = MoodAnalysisFactory.ObjectAtRuntime();
            //Assert
            Assert.AreEqual(expected, result.ToString());
        }




            //[Test]
            //public void When_SadMood_ReturnSadMood()
            //{
            //    ///Arrange
            //    string message = "Im in a Sad mood";
            //    string excepted = "SAD";
            //    ///Act
            //    MoodAnalyserr mood = new MoodAnalyserr(message);
            //    string result = mood.MoodCheck();
            //    ///Assert
            //    Assert.AreEqual(excepted, result);  
            //}
            //[Test]
            //public void When_HappyMood_ReturnHAPPYMood()
            //{
            //    ///Arrange
            //    string message = "Im in a Happy mood";
            //    string excepted = "HAPPY";
            //    ///Act
            //    MoodAnalyserr mood = new MoodAnalyserr(message);
            //    string result = mood.MoodCheck();
            //    ///Assert
            //    Assert.AreEqual(excepted, result);

            //}
            //[Test]
            //public void When_Invalid_ReturnHAPPYMood()
            //{
            //    ///Arrange
            //    string message = "";
            //    string excepted = "HAPPY";
            //    ///Act
            //    MoodAnalyserr mood = new MoodAnalyserr(message);
            //    string result = mood.MoodCheck();
            //    ///Assert
            //    Assert.AreEqual(excepted, result);
            // }
        }
    }