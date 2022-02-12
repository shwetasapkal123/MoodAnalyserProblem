using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
     public class MoodAnalyserWithoutConstructor
    {

        public string MoodAnalyserMethod(string msg)
        {
            if(msg=="HAPPY" || msg=="happy")
            return "HAPPY";
            else
                return "SAD";
        }
        public string MoodAnalyserMethodSad(string msg)
        {
            if (msg == "SAD" || msg == "sad")
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
