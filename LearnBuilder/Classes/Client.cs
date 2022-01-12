using LearnBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Classes
{
    public class Client
    {
        private IBarber _barber;
        public IBarber Barber
        {
            set { _barber = value; }
        }
         
        public void NormalService()
        {
            this._barber.CleanEar();
            this._barber.HairCut();
            Console.WriteLine($"Total: {this._barber.CostNor()}"); 
            
        }

        public void FullService()
        {
            this._barber.HairCut();
            this._barber.CleanEar();
            this._barber.ShaveBeard();
            Console.WriteLine($"Total: {this._barber.Cost()}");
            
        }

        public void CustomService()
        {
            Console.WriteLine("--Choose your service--");
            Console.WriteLine("Hair Cut");
            Console.WriteLine("Clean Ear");
            Console.WriteLine("Shave Beard");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "haircut" or "hair cut":
                    var hair = this._barber.CostCustom(input);
                    Console.WriteLine($"Total: {hair} VND");
                    break;
                case "cleanear" or "clean ear":
                    var ear = this._barber.CostCustom(input);
                    Console.WriteLine($"Total: {ear} VND");
                    break;
                case "shavebeard" or "shave beard":
                    var beard = this._barber.CostCustom(input);
                    Console.WriteLine($"Total: {beard} VND");
                    break;
                default:
                    Console.WriteLine("Wrong Input!!");
                    break;
                
            }
        }
            
    }
}

