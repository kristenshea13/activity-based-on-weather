using System;

namespace activity_based_on_weather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What should you do today?");

            //prompt user for temperature from two specified choices
            Console.Write("Is it hot or cold outside? ");
            
            //declare answer as string variable and convert to all caps so answer 
            //is not case-sensitive
            string outTemp = Console.ReadLine().ToUpper();
            
            //prompt user to choose whether it is wet or dry outside, declare answer 
            //as string variable and convert to all caps
            Console.Write("Is it wet or dry outisde? ");
            string outWeather = Console.ReadLine().ToUpper();

            Console.WriteLine("You should {0} today!", PickActivity(outTemp, outWeather));

            Console.ReadLine();
        }

        /// <summary>
        /// return what user should do today based on two variables about the weather
        /// </summary>
        /// <param name="outTemp"></param>
        /// <param name="outWeather"></param>
        /// <returns>specific activity</returns>
        private static string PickActivity(string outTemp, string outWeather)
        {
            //create specific answers based on different combinations of 
            //the two user-entered variables above, with a catch-all answer
            //if user enters something else than the two choices for each variable
            if (outTemp == "HOT" && outWeather == "WET")
                return "watch Netflix";
            else if (outTemp == "HOT" && outWeather == "DRY")
                return "go swimming";
            else if (outTemp == "COLD" && outWeather == "WET")
                return "paint";
            else if (outTemp == "COLD" && outWeather == "DRY")
                return "go to a cafe and read";
            else
                return "decide for yourself what to do";
        }

    }
}
