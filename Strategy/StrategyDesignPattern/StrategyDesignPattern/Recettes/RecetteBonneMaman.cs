namespace StrategyDesignPattern.Interface;

public class RecetteBonneMaman : IConfitureRecette
{
    public void RealiserRecette(string fruit, int quantite)
    {
        Console.WriteLine($"Préparation de confiture à l'ancienne avec {quantite}g de {fruit} et 50% de sucre ajouté pour une texture riche qui tient au corp.");
    }
}