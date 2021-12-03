using LearnMediator2.Classes;
using System;

namespace LearnMediator2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create chatroom
            Chatroom chatroom = new Chatroom();

            Console.WriteLine("How many participants do you want to register?");
            int numberParticpant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberParticpant; i=i+2)
            {
                Console.WriteLine($"--Participant {i+1}:");
                Console.WriteLine("What's your name?");
                string name1 = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine("What's your message?");
                string mess = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine($"--Participant {i+2}:");
                Console.WriteLine($"Who receive {name1}'s message?");
                string name2 = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine("Which message send to [Messenger || Zalo ]?");
                string messSendTo = Convert.ToString(Console.ReadLine());
                switch (messSendTo.ToLower())
                {
                    case "messenger":
                        Participant a1 = new Messenger(name1);
                        Participant a2 = new Messenger(name2);
                        Console.WriteLine ( chatroom.Register(a1));
                        Console.WriteLine ( chatroom.Register(a2));
                        Console.WriteLine( a1.Send(name2, mess));
                        break;
                    case "zalo":
                        Participant b1 = new Zalo(name1);
                        Participant b2 = new Zalo(name2);
                        Console.WriteLine ( chatroom.Register(b1));
                        Console.WriteLine ( chatroom.Register(b2));
                        Console.WriteLine( b1.Send(name2, mess));
                        break;
                    default:
                        throw new Exception("Can not found!!!");
                    
                }

               
            }
            
          
            

            
        }
    }
}
