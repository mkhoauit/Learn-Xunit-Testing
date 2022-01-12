using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTemplateMethod.Classes
{
    public class PeachTea : MilkteaTemplate
    {
        public int peachTea = 25000;
        public int flavor = 0;
        public string checkFlavor = "No topping";
        public override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }
        public override string AddTea()
        {
            string tea = "Peach Tea";
            return tea;
        }
        public override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }
        public override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }

        public override string AddFlavor()
        {
            return this.checkFlavor;
        }

        public override int Total()
        {
            switch (this.checkFlavor.ToLower())
            {
                case "flan" or "pearl":
                    int flan = 5000;
                    this.flavor = this.flavor + flan;
                    return this.peachTea + this.flavor; 
                    break;
                case "jelly":
                    int jelly = 6000;
                    this.flavor = this.flavor + jelly;
                    return this.peachTea + this.flavor;
                    break;
                case "cheese" or "orange":
                    int cheese = 7000;
                    this.flavor = this.flavor + cheese;
                    return this.peachTea + this.flavor;
                    break;
                case "peach":
                    int peach = 8000;
                    this.flavor = this.flavor + peach;
                    return this.peachTea + this.flavor;
                    break;
                default:
                    this.flavor = 0;
                    this.checkFlavor = "No topping";
                    return this.peachTea + this.flavor;
                    break;

            }
        }
        
    }
   
}
