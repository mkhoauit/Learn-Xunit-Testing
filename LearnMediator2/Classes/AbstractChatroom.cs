using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator2.Classes
{
    public abstract class AbstractChatroom
    {
        public abstract string Register(Participant participant);
        public abstract string Send(string from, string to, string message);
    }
}
