using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Dahmer : ISerialKiller
    {
        double activity = 13;
        double production = 17;
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
            return "Jeffrey Dahmer";
        }

        public double GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "La cannibale de Milwaukee !";
        }

        public string GetVictimGenre()
        {
            return "Homosexuels";
        }
    }
}
