using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class testException
    {
        public string message;
        public testException(string msg)
        {
            message = msg;
        }
        public string AnalyseMoodNullExcp()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                    return "happy";
                else
                    return "sad";
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                return "happy";
            }
                
        }

        public string AnalyseMoodEnum()
        {
            try
            {
                if (this.message.ToLower().Contains("happy"))
                    return "happy";

                else
                    return "sad";
            }
            catch (NullReferenceException ex)
            {
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_MOOD_EXCEPTION, "Message should not be null");
                Console.WriteLine(ex);
                return "happy";
                //throw new NullReferenceException();
                //throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.EMPTY_MOOD_EXCEPTION, "Message should not be null");
            }
        }

        public string AnalyseMoodUsingEnum()
        {
            try
            {
                //if (this.message.ToLower().Contains("happy"))
                //    return "happy";

                 if (this.message.Equals(string.Empty))
                {
                    return " ";
                }
                else
                {
                    return "sad";
                }

            }
            catch (NullReferenceException ecxpt)
            {
                Console.WriteLine(ecxpt);
                return "happy";
                throw new CustomMoodAnalyserException(CustomMoodAnalyserException.ExceptionType.NULL_MOOD_EXCEPTION, "Message should not be null");
            }
        }
    }
}
