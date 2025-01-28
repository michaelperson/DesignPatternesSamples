using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySerialKiller.Models
{
    public class Trump : ISerialKiller
    {
        private readonly int anneeInvestiture;

        public Trump(int anneeInvestiture)
        {
            this.anneeInvestiture = anneeInvestiture;
        }
        public double GetAnnualActivity()
        {
            return 10.3;
        }

        public double GetAnnualRate()
        {
            return 200;
        }

        public string GetName()
        {
            return "Best President Ever";
        }

        public double GetProduction()
        {
            return 100000;
        }

        public string GetSurname()
        {
            return "KarotMan";
        }

        public string GetVictimGenre()
        {
            return "Juste X ou Y";
        }
    }
}
