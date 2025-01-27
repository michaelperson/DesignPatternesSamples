namespace StrategyDesignPattern.Interface;

public class FabricationConfiture
{
    private readonly IConfitureRecette _recette;

    public FabricationConfiture(IConfitureRecette recette)
    {
        _recette = recette;
    }

    public void ProduireConfiture(string fruit, int quantite)
    {
        _recette.RealiserRecette(fruit, quantite);
    }
}