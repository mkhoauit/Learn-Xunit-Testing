using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnFacade.Classes
{
    public class Player2
    {
        public string word1 = " ";
        public string word2 = " ";
        public Player2()
        {
        }

        public Player2(string words)
        {
            this.word1 = words;
        }


        public string Word1()
        {
            return this.word1;

        }
        

        public string WordZ()
        {
            return this.word2;
        }
    }
}
