using LearnBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LearnBuilder.Classes.ServiceConst;

namespace LearnBuilder.Classes
{
    public class Barber : IBarber
    {
        private Service _service = new Service();
        

        
        public Barber()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._service = new Service();
        }
        
        public void CleanEar()
        {

            this._service.Add(ServiceConst.CleanEar);
            
        }

        

        public void HairCut()
        {
            this._service.Add(ServiceConst.HairCut);
            
        }

        public void ShaveBeard()
        {
            this._service.Add(ServiceConst.ShaveBeard);
        }
        public Service GetService()
        {
            Service result = this._service;

            this.Reset();

            return result;
        }

        public int CostNor()
        {
            
            return hairCutCost+ shaveBeardCost ;
        }
        public int Cost()
        {
            
            return hairCutCost+ shaveBeardCost +cleanEarCost ;
        }

        public int CostCustom(string service)
        {
            switch (service.ToLower())
            {
                case "haircut" or "hair cut":
                    return hairCutCost;
                    break;
                case "cleanear" or "clean ear":
                    return cleanEarCost;
                    break;
                case "shavebeard" or "shave beard":
                    return shaveBeardCost;
                    break;
                default:
                    return 0;
                    break;
                    
            }
        }

        

        
    }
}
