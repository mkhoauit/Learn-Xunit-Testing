using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCommand.Classes
{
    public class Calculator
    {
        public int cur = 0;
        public string operation = " ";
        public string Operation(char @operator, int operand)
        {   
            switch (@operator)
            {
                case '+': 
                    this.cur += operand; 
                    
                    break;
                case '-': 
                    this.cur -= operand;
                    
                    break;
                case '*': 
                    this.cur *= operand; 
                   
                    break;
                case '/': 
                    this.cur /= operand;
                    
                    break;
                default:
                    throw new Exception(message: "Do not have that calculation!");
            } 
            this.operation = ($"Current value = {this.cur} (following {@operator} {operand})\n");
            return this.operation;

        }
    }
}
