namespace BTree;

public abstract class Element{}
public class ChildrenElement : Element
{
    public int Key { get; set; }
    
    public string? Value { get; set; }
}

public class ParentElement : Element
{
    public int Key { get; set; }
    
    public int PointNo { get; set; }
}