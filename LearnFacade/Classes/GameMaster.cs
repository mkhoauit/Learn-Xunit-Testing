using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFacade.Classes
{
    public class GameMaster
    {
        public static void GMCode(GameNextWord gameNextWord)
        {
            Console.Write(gameNextWord.Operation());
        }
    }
}
