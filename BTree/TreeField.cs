namespace BTree;

public class TreeField
{
    public RootNode? RootNode { get; set; } = null;
    
    public List<ParentNode> ParentNodes { get; set; } = new ();
    
    public List<ChildrenNode> ChildrenNodes { get; set; } = new();
}