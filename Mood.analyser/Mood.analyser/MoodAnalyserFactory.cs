using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateObjectAtRuntime()
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type moodAnalyserType = assembly.GetType("MoodAnalyser.MoodAnalyserr");
                Console.WriteLine($"Name of the class at Runtime: {moodAnalyserType.Name}");
                object moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
                return moodAnalyserObject;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done Reflections");
            }
            return null;
        }
    }
}
