using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator2.Classes
{
    public class Messenger : Participant
    {
        // Constructor
        public Messenger(string name): base(name)
        {
            if (name == "" || name == " ")
            {
                throw new Exception("Please input your name correctly!");
            }
        }
        public override string Receive(string from, string message)
        {
            return $"To Messenger:{base.Receive(from, message)}";
          
        }
    }
}
