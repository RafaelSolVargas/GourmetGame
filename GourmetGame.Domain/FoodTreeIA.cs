using GourmetGame.Domain.Navigations;

namespace GourmetGame.Domain;

public class FoodTreeIA
{
    public FoodTreeIA()
    {
        var foodCaseYes = new FoodNode("Lasanha", null!);
        var foodCaseNo = new FoodNode("Bolo de chocolate", null!);
        
        // The rootNode will not have a parent
        _RootNode = new QualityNode("massa", foodCaseYes, foodCaseNo, null!);
        
        foodCaseNo.Parent = _RootNode;
        foodCaseYes.Parent = _RootNode; 
    }

    private readonly QualityNode _RootNode;

    public Navigation StartNavigation()
    {
        return new Navigation(_RootNode);
    }
}
