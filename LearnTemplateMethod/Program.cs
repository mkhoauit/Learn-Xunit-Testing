using LearnTemplateMethod.Classes;
using System;

namespace LearnTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==> Welcome to Khoa's MilkTea <== ");
            Console.WriteLine(" --- Menu Drinks --- ");
            Console.WriteLine("-- Bubble Tea --");
            Console.WriteLine("-- Black  Tea --");
            Console.WriteLine("-- Green  Tea --");
            Console.WriteLine("-- Peach  Tea --");
            Console.WriteLine("-->Choose your drink:");
            string drink = Console.ReadLine().CheckDrink();
            Console.WriteLine($"-->You choose: {drink} ");
            Console.WriteLine();
            Console.WriteLine(" --- Menu Topping --- ");
            Console.WriteLine("-- Flan   --");
            Console.WriteLine("-- Jelly  --");
            Console.WriteLine("-- Pearl  --");
            Console.WriteLine("-- Cheese --");
            Console.WriteLine("-- Peach  --");
            Console.WriteLine("-- Orange --");
            Console.WriteLine("-->Choose your topping:");
            string topping = Console.ReadLine().CheckTopping();

            switch (drink) 
            {
                case "Bubble Tea":
                    Console.WriteLine("Bubble Tea Preparation:");
                    BubbleTea tea = new BubbleTea();
                    tea.checkFlavor = topping;
                    tea.AddFlavor();
                    tea.Total();
                    MilkteaTemplate bubbletea = tea;
                    bubbletea.PrepareMilktea();
                    break;
                case "Black Tea":
                    Console.WriteLine("Black Tea Preparation:");
                    BlackTea tea2 = new BlackTea();
                    tea2.checkFlavor = topping;
                    tea2.AddFlavor();
                    tea2.Total();
                    MilkteaTemplate blacktea = tea2;
                    blacktea.PrepareMilktea();
                    break;
                case "Green Tea":
                    Console.WriteLine("Green Tea Preparation:");
                    GreenTea tea3 = new GreenTea();
                    tea3.checkFlavor = topping;
                    tea3.AddFlavor();
                    tea3.Total();
                    MilkteaTemplate greentea = tea3;
                    greentea.PrepareMilktea();
                    break;
                case "Peach Tea":
                    Console.WriteLine("Peach Tea Preparation:");
                    PeachTea tea4 = new PeachTea();
                    tea4.checkFlavor = topping;
                    tea4.AddFlavor();
                    tea4.Total();
                    MilkteaTemplate peachtea = tea4;
                    peachtea.PrepareMilktea();
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Thank you. See you next time (^.^) Have a nice day.");
        }
    }
    public static class Extensions
    {

        public static string CheckDrink(this string strType)
        {

            if (strType.ToLower() == "bubbletea"|| strType.ToLower() == "bubble tea")
            {

                return "Bubble Tea";
            }
            else if (strType.ToLower() == "blacktea" || strType.ToLower() == "black tea")
            {

                return "Black Tea";
            }
            else if (strType.ToLower() == "greentea" || strType.ToLower() == "green tea")
            {

                return "Green Tea";
            }
            else if (strType.ToLower() == "peachtea" || strType.ToLower() == "peach tea")
            {

                return "Peach Tea";
            }
            
            else
            {
                Console.WriteLine("Please input type of drink correctly!");
                return null;
            }

        }

        public static string CheckTopping(this string strTop)
        {
            if (strTop.ToLower()== "orange"||strTop.ToLower()== "flan"||strTop.ToLower()== "jelly"||strTop.ToLower()== "peach"||strTop.ToLower()== "cheese"||strTop.ToLower()=="pearl")
            {
                return strTop;
            }
            else
            {
                strTop = "No topping";
                return strTop;
            }
        }
    }
}
