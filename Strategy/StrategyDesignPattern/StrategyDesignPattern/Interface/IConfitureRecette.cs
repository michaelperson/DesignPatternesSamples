namespace StrategyDesignPattern.Interface;

/// <summary>
/// D�clare les m�thodes n�cessaires pour les stat�gies
/// </summary>
public interface IConfitureRecette
{
    void RealiserRecette(string fruit, int quantite);
}