using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Interface
{
    public interface ISerialKiller
    {
        string GetName();
        string GetSurname(); 
        double GetProduction();
        double GetAnnualActivity();
        double GetAnnualRate();
        string GetVictimGenre();
    }
}
