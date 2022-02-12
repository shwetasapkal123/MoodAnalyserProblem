using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserTest
    {
        public string message;
        //Creating constructor
        public MoodAnalyserTest(string message)
        {
            this.message = message;
        }
        //method for constructor
        public string AnalyseMood()
        {
            if (this.message.ToLower().Contains("happy"))
            {
                return "happy";
            }

            else
            {
                return "SAD";
            }
        }
        public string AnalyseMoodForSad()
        {
            if (this.message.ToLower().Contains("SAD"))
                return "Sad";
            else
                return "HAPPY";
        }

        //public string AnalyseMoodUsingEnum()
        //{
        //    try
        //    {
        //        if (this.message.ToLower().Contains("happy"))
        //            return "happy";

        //        else if(this.message.Equals(string.Empty))
        //        {

        //        }
        //        else
        //        {
        //            return "sad";
        //        }
                    
        //    }
        //    catch(NullReferenceException ecxpt)
        //    {
        //        Console.WriteLine(ecxpt);
        //        throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NULL_MOOD_EXCEPTION, "Message should not be null");
        //    }
        //}
    }
                   
}
