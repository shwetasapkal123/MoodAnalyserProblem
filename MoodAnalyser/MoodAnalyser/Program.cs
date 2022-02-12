using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "I am in Sad Mood";
            //Refactor : Using constructor Ability to analyse and respond
            MoodAnalyserTest moodAnalyser = new MoodAnalyserTest(msg);
            moodAnalyser.AnalyseMood();
            //TC1.1 Using constructor 
            Console.WriteLine("Output of mood analyser is: "+ moodAnalyser.AnalyseMood());
            //TC1.2 Using constructor
            string msg2 = "I am in Any Mood";
            MoodAnalyserTest moodAnalyser1 = new MoodAnalyserTest(msg2);
            Console.WriteLine("Output for test case 1.2 is: "+moodAnalyser1.AnalyseMoodForSad());

            //UC1 
            MoodAnalyserWithoutConstructor analyserWithoutConstructor = new MoodAnalyserWithoutConstructor();
            //TC1.1 
            Console.WriteLine("Output of Mood Analyser without Constructor is: "
                +analyserWithoutConstructor.MoodAnalyserMethod(msg));
            //TC1.2
            Console.WriteLine("Output of Mood Analyser without Constructor is: "
                + analyserWithoutConstructor.MoodAnalyserMethod(msg2));

            //UC2 Handle exception
            string message = null;
            testException excpt = new testException(message);
            Console.WriteLine(excpt.AnalyseMoodNullExcp());


            Console.ReadLine();
        }
        
    }
}
