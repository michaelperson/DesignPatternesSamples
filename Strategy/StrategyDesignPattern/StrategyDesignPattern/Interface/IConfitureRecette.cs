namespace StrategyDesignPattern.Interface;

/// <summary>
/// Déclare les méthodes nécessaires pour les statégies
/// </summary>
public interface IConfitureRecette
{
    void RealiserRecette(string fruit, int quantite);
}