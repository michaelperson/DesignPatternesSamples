using CarteDeCreditFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarteDeCreditFactory.Models
{
    public class Garavito : ISerialKiller
    {
        double activity = 10;
        double production = 138;
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
            return "Luis Garavito";
        }

        public double GetProduction()
        {
            return production;
        }

        public string GetSurname()
        {
            return "La bête !";
        }

        public string GetVictimGenre()
        {
            return "Enfants";
        }
    }
}
