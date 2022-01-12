using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnBuilder.Interfaces
{
    public interface IBarber
    {
        void HairCut();

        void ShaveBeard();

        void CleanEar();
        int Cost();
        int CostNor();
        int CostCustom(string service);
    }
}
