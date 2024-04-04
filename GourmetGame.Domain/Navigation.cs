using GourmetGame.Domain.Enums;

namespace GourmetGame.Domain.Navigations;


/// <summary>
/// Controller to all the navigation that will be done in the FoodTree
/// </summary>
public class Navigation(BaseTreeNode firstNode)
{
    private BaseTreeNode _CurrentNode = firstNode;
    public BaseTreeNode CurrentNode { get { return _CurrentNode; } }

    public NavigationResult Navigate(NavigationCase navigationCase)
    {
        var nextNode = navigationCase == NavigationCase.Yes ? _CurrentNode.NodeCaseYes
                                                            : _CurrentNode.NodeCaseNo;

        _CurrentNode = nextNode;

        var resultType = nextNode.IsFood ? NavResultTypes.FoodFound : NavResultTypes.QualityFound;

        return new NavigationResult(resultType, nextNode.Name);
    }

    public void SpecializeCurrentFoodToQuality(string newQualityName, string newFood)
    {
        if (!_CurrentNode.IsFood)
        {
            throw new Exception("Wrong utilization of specialization because the current node is not a food");
        }

        // Get the previous node that was a quality
        var previousNode = _CurrentNode.Parent;

        // Create a new food who will be the one that has the new quality
        var foodYes = new FoodNode(newFood, null!);
        // The current node will be the food that failed to attends this
        var foodNo = (_CurrentNode as FoodNode)!;

        // Create the quality to replace the foodNo in the tree
        var newQuality = new QualityNode(newQualityName, foodYes, foodNo, previousNode);

        // Changes references
        foodYes.Parent = newQuality;
        foodNo.Parent = newQuality;


        if (previousNode.NodeCaseNo == _CurrentNode)
        {
            previousNode.NodeCaseNo = newQuality;
        }
        else
        {
            previousNode.NodeCaseYes = newQuality;
        }
    }
}

public class NavigationResult(NavResultTypes resultType, string qualityOrFoodName)
{
    public NavResultTypes ResultType { get; private set; } = resultType;
    public string QualityOrFoodName { get; private set; } = qualityOrFoodName;
}
