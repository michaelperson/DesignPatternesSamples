using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Bundy : ISerialKiller
    {
        double activity = 8;
        double production = 30;
        public double GetAnnualActivity()
        {
            return activity;
        }

        public double GetAnnualRate()
        {
            return Math.Round((production / activity), 2);
        }

        public string GetName()
        {
            return "Ted Bundy";
        }

        public double GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "Le Prince des ténèbres!";
        }

        public string GetVictimGenre()
        {
            return "jeunes femmes";
        }
    }
}
