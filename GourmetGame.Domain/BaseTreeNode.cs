namespace GourmetGame.Domain;

public abstract class BaseTreeNode
{
    protected BaseTreeNode(string name, bool isFood, BaseTreeNode? caseYes, BaseTreeNode? caseNo, BaseTreeNode parent)
    {
        Name = name;
        IsFood = isFood;
        NodeCaseYes = caseYes ?? this;
        NodeCaseNo = caseNo ?? this;
        Parent = parent ?? this;
    }
    public string Name { get; private set; }
    public bool IsFood { get; private set; }

    public BaseTreeNode Parent { get; set; }
    public BaseTreeNode NodeCaseYes { get; set; }
    public BaseTreeNode NodeCaseNo { get; set; }
}

/// <summary>
/// The Quality Node is always created as the result of a failed attempt, that finished in the creation of a divergent quality
/// thus the ctor will require a FoodNode instead of the abstract class
/// </summary>
/// <param name="quality">The name of the quality</param>
/// <param name="caseYes">The node to be connected if the food has this quality</param>
/// <param name="caseNo">The node to be connected if the food dosn't have this quality</param>
public class QualityNode(string name, FoodNode caseYes, FoodNode caseNo, BaseTreeNode parent) : BaseTreeNode(name, false, caseYes, caseNo, parent) { }

public class FoodNode(string foodName, BaseTreeNode parent) : BaseTreeNode(foodName, true, null, null, parent) { }
