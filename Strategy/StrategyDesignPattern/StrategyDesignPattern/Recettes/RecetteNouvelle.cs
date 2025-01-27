namespace StrategyDesignPattern.Interface;

public class RecetteNouvelle : IConfitureRecette
{
    public void RealiserRecette(string fruit, int quantite)
    {
        Console.WriteLine($"Préparation de confiture moderne avec {quantite}g de {fruit} et seulement 20% de sucre ajouté.");
    }
}