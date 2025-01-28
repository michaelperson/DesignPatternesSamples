using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySerialKiller.Models
{
    public class Xinhai : ISerialKiller
    {
        double activity = 14;
        double production = 67;
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
            return "Yang Xinhai";
        }

        public double GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "Le tueur à la hache!";
        }

        public string GetVictimGenre()
        {
            return "Des petits chinois";
        }
    }
}
