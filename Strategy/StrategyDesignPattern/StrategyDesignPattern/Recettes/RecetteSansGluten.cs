namespace StrategyDesignPattern.Interface;

public class RecetteSansGluten : IConfitureRecette
{
    public void RealiserRecette(string fruit, int quantite)
    {
        Console.WriteLine($"Préparation de confiture sans gluten avec {quantite}g de {fruit}, épaississant naturel utilisé (sans gluten).");
    }
}