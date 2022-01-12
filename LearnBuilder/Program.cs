using LearnBuilder.Classes;
using System;

namespace LearnBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            var barber = new Barber();
            client.Barber = barber;


            Console.WriteLine("---Choose your service [Input a number]---");
            Console.WriteLine("1: Standard service");
            Console.WriteLine("2: Full service");
            Console.WriteLine("3: Custom service");
            uint input = Convert.ToUInt32(Console.ReadLine());

            switch (input) 
            {
                case 1:
                    Console.WriteLine("Standard basic service:");
                    client.NormalService();
                    Console.WriteLine(barber.GetService().ListService()) ;
                    
                    break;
                case 2:
                    Console.WriteLine("Standard full service:");
                    client.FullService();
                    Console.WriteLine(barber.GetService().ListService());
                    
                    break;
                case 3:
                   client.CustomService();
                   break;

            }


            Console.WriteLine();
            Console.WriteLine("Thank you for using Barber Service.");
            Console.WriteLine("Have a nice day ^^");


        }
    }
    
}
