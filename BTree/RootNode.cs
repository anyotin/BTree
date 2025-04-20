namespace BTree;

public class RootNode : Node
{
    public List<ParentElement> ParentElements { get; set; } = new();

    public void Add(ParentElement element)
    {
        if (ParentElements.Count > 2) throw new Exception("容量オーバーです。");
        
        ParentElements.Add(element);
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}