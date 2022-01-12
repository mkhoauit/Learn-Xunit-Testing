using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTemplateMethod.Classes
{
    public abstract class MilkteaTemplate
    {
        public void PrepareMilktea()
        {
            BoilWater();
            Console.WriteLine($"{AddTea()} Added");
            AddMilk();
            AddSugar();
            Console.WriteLine();
            
            Console.WriteLine($"Your order <<{this.GetType().Name} with {this.AddFlavor()}>> is Ready.");
            Console.WriteLine($"Total: {this.Total()} VND.");

        }
        public abstract void BoilWater();
        public abstract string AddTea();
        public abstract void AddMilk();
        public abstract void AddSugar();
        public abstract string AddFlavor();
       
        public abstract int Total();
       
    }
}
