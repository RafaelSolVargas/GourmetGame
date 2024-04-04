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
public class QualityNode(string name, FoodNode caseYes, FoodNode caseNo, BaseTreeNode parent) : BaseTreeNode(name, false, caseYes, caseNo, parent) 
{
    private FoodNode? _FoodCaseYes = caseYes;
    private FoodNode? _FoodCaseNo = caseNo;

    /// <summary>
    /// To be called if was found a food that have the current quality but it's not the required one,
    /// so we change the connections to point to another quality that differs the last and the new food
    /// </summary>
    /// <param name="qualityNode">The Quality Node to replace the next node if yes</param>
    public void SpecializeCaseYes(string newQualityName, string newFoodName)
    {
        if (NodeCaseYes.IsFood is false || _FoodCaseYes is null)
        {
            throw new Exception("Wrong utilization of specialize yes when calling it for a already specialized case");
        }

        // This food is the one that has the newQualityName while the previous doesn't have
        var newFood = new FoodNode(newFoodName, this);

        // Creates a new quality that references to the previous pointed node and the new food
        var newQualityNode = new QualityNode(newQualityName, newFood, _FoodCaseYes, this);

        // Remove the direct reference to the food
        _FoodCaseYes = null;

        NodeCaseYes = newQualityNode;
    }

    /// <summary>
    /// To be called if was found a food that doesn't have the current quality but it's not the required one,
    /// so we change the connections to point to another quality that differs the last and the new food
    /// </summary>
    /// <param name="qualityNode">The Quality Node to replace the next node if no</param>
    public void SpecializeCaseNo(string newQualityName, string newFoodName)
    {
        if (NodeCaseNo.IsFood is false || _FoodCaseNo is null)
        {
            throw new Exception("Wrong utilization of specialize no when calling it for a already specialized case");
        }

        // This food is the one that has the newQualityName while the previous doesn't have
        var newFood = new FoodNode(newFoodName, this);

        // Creates a new quality that references to the previous pointed node and the new food
        var newQualityNode = new QualityNode(newQualityName, newFood, _FoodCaseNo, this);

        // Remove the direct reference to the food
        _FoodCaseNo = null;

        NodeCaseNo = newQualityNode;
    }
}

public class FoodNode(string foodName, BaseTreeNode parent) : BaseTreeNode(foodName, true, null, null, parent) { }
