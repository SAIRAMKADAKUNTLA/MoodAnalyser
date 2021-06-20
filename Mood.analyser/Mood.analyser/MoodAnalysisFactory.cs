using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysisFactory
    {
        public static object ObjectAtRuntime()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalyserType = assembly.GetType("MoodAnalyser.MoodAnalyserr");
            Console.WriteLine($"Name of the class at Runtime:"+ (moodAnalyserType.Name));
            object moodAnalyserObject = Activator.CreateInstance(moodAnalyserType);
            return moodAnalyserObject;
        }

    }
}
