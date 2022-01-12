using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCommand.Classes
{
    public class CalculatorCommand : Command
    {
        public char @operator;
        public int operand;
        Calculator calculator;
      
        public CalculatorCommand(Calculator calculator,char @operator, int operand)
        {
            this.calculator = calculator;
            this.@operator = @operator;
            this.operand = operand;
        }
        // Gets operator
        public char Operator
        {
            set { @operator = value; }
        }
        // Get operand
        public int Operand
        {
            set { operand = value; }
        }
        // Execute new command
        public override string Execute()
        {
             
             string exec = calculator.Operation(@operator, operand);
            return exec;
            //return $"{calculator.Operation(@operator, operand)}"; 
        }
        // UnExecute last command
        public override string UnExecute()
        {
            string unExe =calculator.Operation(Undo(@operator), operand);
            return unExe;
            //return $"{calculator.Operation(Undo(@operator), operand)}";
        }
        // Returns opposite operator for given operator
        public char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';

                default:
                    throw new Exception("CannotUndo");
            }
        }
    }
}
