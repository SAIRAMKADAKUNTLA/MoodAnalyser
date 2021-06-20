using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    class MoodAnalysisException:Exception
    {
        public enum Errors { EMPTY }
        public MoodAnalysisException()
        {
            Console.WriteLine(Errors.EMPTY);
        }
    }
}
