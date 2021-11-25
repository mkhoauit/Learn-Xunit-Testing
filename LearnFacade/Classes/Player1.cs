using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFacade.Classes
{
    public class Player1
    {
        public string word1 = " ";
        public string word2 = " ";
        public Player1()
        {
        }

        public Player1(string words)
        {
            this.word1 = words;
        }

        
        public string  Word1 ()
        {
            return this.word1;
            
        }
        public string WordN()
        {
            return this.word2;

        }
    }
}
