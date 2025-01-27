using StrategyDesignPattern.Interface;

namespace StrategyDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        // Confiture avec une nouvelle recette
        IConfitureRecette recetteNouvelle = new RecetteNouvelle();
        FabricationConfiture fabrication1 = new FabricationConfiture(recetteNouvelle);
        fabrication1.ProduireConfiture("fraises", 1000);

        // Confiture sans gluten
        IConfitureRecette recetteSansGluten = new RecetteSansGluten();
        FabricationConfiture fabrication2 = new FabricationConfiture(recetteSansGluten);
        fabrication2.ProduireConfiture("abricots", 500);

        // Confiture Bonne Maman
        IConfitureRecette recetteBonneMaman = new RecetteBonneMaman();
        FabricationConfiture fabrication3 = new FabricationConfiture(recetteBonneMaman);
        fabrication3.ProduireConfiture("pêches", 750);
    }
}