using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCommand.Classes
{
    public class Client
    {
        Calculator calculator = new Calculator();
        List<Command> commands = new List<Command>();
        public int current = 0;
        public string compute = " ";
        
        public string Redo(int levels)
        {
            string redo = $"Redo {levels} levels\n";
            
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count - 1)
                {
                    Command command = commands[current++];
                    redo += command.Execute();
                }
                else
                {
                    throw new Exception(message: "You need to Undo first!");
                }
            }

            return redo;
        }
        public string Undo(int levels)
        {
            string undo = $"Undo {levels} levels\n";
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current] as Command;
                    undo += command.UnExecute();
                }
                else
                {
                    throw new Exception(message: "You need to Compute first!");
                }
            }

            return undo;
        }
        public string Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(calculator, @operator, operand);
            this.compute = command.Execute();
            // Add command to undo list
            commands.Add(command);
            current++;
            return this.compute;
        }
    }
}

