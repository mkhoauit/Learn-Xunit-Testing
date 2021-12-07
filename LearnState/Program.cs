using System;
using LearnState.Classes;

namespace LearnState
{
    class Program
    {
        static void Main(string[] args)
        {
            Tv tv = new Tv();
            Console.WriteLine($"Current TV State: {tv.tvState.GetType().Name}.");
            
            Console.WriteLine("Input power button to turn on TV:");
            string input = Convert.ToString(Console.ReadLine());
            Console.WriteLine(tv.PressThePowerButton(input));
            
            Console.WriteLine("Input your number channel to watch:");
            int numberChannel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(tv.SwitchChannel(numberChannel));
            
            Console.WriteLine("Do you want to turn off TV?");
            string answer = Convert.ToString(Console.ReadLine());
            if (answer.ToLower() == "y" || answer.ToLower()=="yes")
            {
                Console.WriteLine( tv.PressThePowerButton("power"));
            }
            Console.WriteLine($"Current TV State: {tv.tvState.GetType().Name}.");
            
        }
    }
}
