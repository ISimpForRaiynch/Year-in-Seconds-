using System;

namespace Age_To_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISFR Age to Second Calculator(Now to be Honest it isn't 100 percent accurate but bear with me im 12 and I'm not that skilled)");
            Console.WriteLine("OK anyways What's your age?");
            int myAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Now How Many Leap Years have there been");
            int myLeap = int.Parse(Console.ReadLine());
            Console.WriteLine("Cool! Now how many days have you been alive? (In this you can check this by searching how many days has it been since january 1st in 'Google' after I become more expierenced ill Add something similaire in this program not now though )");
            int myDays = int.Parse(Console.ReadLine());
            int myYearSec = myAge * 365 * 24 * 60 * 60;
            int myDays1 = myDays * 24 * 60 * 60;
            int myLeap1 = myLeap * 24 * 60 * 60;
            int mySec = myYearSec + myDays1 + myLeap1;
            Console.WriteLine("Your age in seconds is: " + mySec);
        }
    }
}