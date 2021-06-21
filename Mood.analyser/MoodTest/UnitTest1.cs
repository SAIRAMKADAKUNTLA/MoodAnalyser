using NUnit.Framework;
using MoodAnalyser;
using System.Reflection;
using System;

namespace MoodTest
{
    public class Tests
    {
     

        [Test]
        public void When_SadMood_ReturnSadMood()
        {
            ///Arrange
            string message = "Im in a Sad mood";
            string excepted = "SAD";
            ///Act
            MoodAnalyserr mood = new MoodAnalyserr(message);
            string result = mood.MoodCheck();
            ///Assert
            Assert.AreEqual(excepted, result);  
        }
        [Test]
        public void When_HappyMood_ReturnHAPPYMood()
        {
            ///Arrange
            string message = "Im in a Happy mood";
            string excepted = "HAPPY";
            ///Act
            MoodAnalyserr mood = new MoodAnalyserr(message);
            string result = mood.MoodCheck();
            ///Assert
            Assert.AreEqual(excepted, result);

        }
        [Test]
        public void When_Invalid_ReturnHAPPYMood()
        {
            ///Arrange
            string message = "";
            string excepted = "HAPPY";
            ///Act
            MoodAnalyserr mood = new MoodAnalyserr(message);
            string result = mood.MoodCheck();
            ///Assert
            Assert.AreEqual(excepted, result);
        }
        [Test]
        public void WhenGivenClassName_ReturnsObject()
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType("MoodAnalyser.MoodAnalyserr");
                Console.WriteLine(moodAnalyserType.Name);
                object tempObject = Activator.CreateInstance(moodAnalyserType);
                //Arrange
                string expected = (string)tempObject;
                //Act
                string result = "MoodAnalyser.MoodAnalyserr";
                //Assert
                Assert.AreEqual(expected, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done all test cases");
            }

        }
    }
}