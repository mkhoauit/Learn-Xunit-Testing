using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator2.Classes
{
    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
        public override string Register(Participant participant)
        {
            if (!participants.ContainsValue(participant))
            {
                participants[participant.Name] = participant;
            }
            
            
            participant.Chatroom = this;
            return $"Register for {participant.Name} successfully.";
        }
        public override string Send(string from, string to, string message)
        {
            Participant participant = participants[to];
            if (participant != null)
            {
                return participant.Receive(from, message);
            }
            else
            {
                throw new Exception("Participant is Null");
            }
            
        }
    }
}
