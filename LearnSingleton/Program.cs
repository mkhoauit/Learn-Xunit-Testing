using LearnSingleton.Classes;
using System;
using System.Security.Cryptography;

namespace LearnSingleton
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many LogMessage do you want?");
            int log = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < log; i++)
            {
                Console.WriteLine($"--Log Message {i+1}:");
                
                Console.WriteLine("What's your name?");
                string name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("What's your message?");
                string mess = Convert.ToString(Console.ReadLine());
                
                string message = Logger.GetLogger().WriteMessage(mess,name);
                Console.WriteLine(message);
                
            }
            
            Console.WriteLine("What message do you want to find?");
            string find = Convert.ToString(Console.ReadLine());
           

            Console.WriteLine(Logger.GetLogger().FindMessage(find));
            
            if(Logger.instanceCounter==1)
            {
                Console.WriteLine("Use 1 instance");
            }
            else
            {
                Console.WriteLine("Use more than 1");
                
            }
            
            
            
            
            
            
        }
    }
}
