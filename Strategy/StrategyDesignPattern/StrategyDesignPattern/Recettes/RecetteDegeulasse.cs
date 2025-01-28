using StrategyDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern.Recettes
{

    public class RecetteDegeulasse : IConfitureRecette
    {
        public void RealiserRecette(string fruit, int quantite)
        {
            Console.WriteLine($"Mélanger de la graisse de babouin aux fruit et laisser trop cuire dans une four trop chaud");
        }
    }
}
