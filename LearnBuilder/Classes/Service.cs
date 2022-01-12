using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Classes
{
    public class Service
    {
        private List<object> _service = new List<object>();
       
        public void Add(string service)
        {
            this._service.Add(service);
           
        }
        public int CostFull() 
        {
           
            return ServiceConst.hairCutCost + ServiceConst.cleanEarCost + ServiceConst.shaveBeardCost;
                 
        }
       
        public string ListService()
        {
            string str = string.Empty;

            for (int i = 0; i < this._service.Count; i++)
            {        
                
                    str += this._service[i] + " \n ";
              
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Service: \n " + str + "\n";
        }
    }
}
