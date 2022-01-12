using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMediator2.Classes
{
    public class Participant
    {
        Chatroom chatroom;
        string name="Name";
        // Constructor
        public Participant(string name)
        {

            this.name = name;
        }
        // Gets participant name
        public string Name
        {
            get { return name; }
        }
        // Gets chatroom
        public Chatroom Chatroom
        {
            set { chatroom = value; }
            get { return chatroom; }
        }
        // Sends message to given participant
        public string Send(string to, string message)
        {
           return chatroom.Send(name,to, message);
        }
        // Receives message from given participant
        public virtual string Receive( string from, string message)
        {
            return ($"{from} to {Name}: {message}\n");
        }
    }
}
