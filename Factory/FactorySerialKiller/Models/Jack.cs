using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Jack : ISerialKiller
    {
        double activity = 3;
        double production = 5;
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
            return "Aaron Kosminski (supposé)";
        }

        public double GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "Jack l'éventreur!";
        }

        public string GetVictimGenre()
        {
            return "Prostituées";
        }
    }
}
