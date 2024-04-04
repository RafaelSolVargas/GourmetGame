using GourmetGame.Domain;
using System.Diagnostics;

namespace GourmetGame.Controllers.DTOs;

[DebuggerDisplay("Name = {Name}, IsFood = {IsFood}")]
public class TreeNodeDTO
{
    public bool IsFood { get; set; }
    public required string Name { get; set; } = string.Empty;

    public static implicit operator TreeNodeDTO(BaseTreeNode treeNode)
    {
        return new TreeNodeDTO()
        {
            IsFood = treeNode.IsFood,
            Name = treeNode.Name,
        };
    }
}
