using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSingleton.Classes
{
    public sealed class Logger
    {
        private static Logger _logger;
        public static int instanceCounter = 0;
        public string Messages="Message:\n";
        
        private Logger()
        {
            instanceCounter++;  
            Console.WriteLine($"Instances created:{instanceCounter} time");
            
        }

        public static Logger GetLogger()
        {
            if (_logger == null)
            {
                _logger = new Logger();
            }

            return _logger;
        }
        public string WriteMessage(string message,string name)
        {
            if (message ==""||message ==" "||name ==""||name ==" ")
            {
                throw new Exception("Please input your message correctly!");
            }
            this.Messages += "Message from " +name +": " +message +"\n";
            return this.Messages;
        }

        public string FindMessage(string message)
        {
            if (Messages.Contains(message))
            {
                return ($"There is message: {message}");
            }
            else
            {
                throw new Exception("Not Found!");
            }
            
        }

    }
}
