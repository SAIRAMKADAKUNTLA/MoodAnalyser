using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserr
    {
        public const string sadMood = "Im in a Sad mood";
        public const string happyMood = "Im in a Happy mood";
        public string message;
        public MoodAnalyserr(string message)
        {
            this.message = message;
        }
        public string MoodCheck()
        {
            try
            {
                if (message == null || message == string.Empty)
                    throw new MoodAnalysisException();
                if(message == sadMood)
                    return "SAD";
                if(message == happyMood)
                    return "HAPPY";
            }
            catch (MoodAnalysisException)
            {
                return "HAPPY";
            }
            return null;
        }
    }
}

