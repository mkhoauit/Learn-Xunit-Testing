using PracticeChainOfResp.Classes;
using System;

namespace PracticeChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            
            Console.WriteLine("How much do you have in your account?");
            uint input1 = Convert.ToUInt32( Console.ReadLine());
            atm.checkYourAmount(input1);
            
            Console.WriteLine("How much do you want to withdraw? BankNote: [50.000 || 100.000 || 200.000 || 500.000 ]");
            uint input2 = Convert.ToUInt32(Console.ReadLine());

            atm.withdraw(input2);
            Console.WriteLine($"Your current amount:{atm.currentAmount()}");

            Console.WriteLine("All done. Have a nice day ^^ ");

        }
    }
}
