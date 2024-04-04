using GourmetGame.Controllers.DTOs;
using GourmetGame.Domain;
using GourmetGame.Domain.Enums;
using GourmetGame.Domain.Navigations;

namespace GourmetGame.Controllers;

public class GourmetGameController
{
    private static GourmetGameHandler? _Handler;

    public static GourmetGameHandler Handler
    {
        get
        {
            _Handler ??= new GourmetGameHandler();

            return _Handler;
        }
    }
}

public class GourmetGameHandler
{
    private readonly FoodTreeIA FoodTree;
    private Navigation CurrentNavigation;

    public GourmetGameHandler()
    {
        FoodTree = new FoodTreeIA();
        CurrentNavigation = FoodTree.StartNavigation();
    }

    public void RestartNavigation()
    {
        CurrentNavigation = FoodTree.StartNavigation();
    }

    public TreeNodeDTO GetCurrentNode()
    {
        return CurrentNavigation.CurrentNode;
    }

    public NavigationResult HandleNavigation(NavigationCase navCase)
    {
        return CurrentNavigation.Navigate(navCase);
    }

    public void InsertNewFood(string qualityName, string foodName)
    {
        CurrentNavigation.SpecializeCurrentFoodToQuality(qualityName, foodName);
    }
}

