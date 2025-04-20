namespace BTree;

public class ChildrenNode : Node
{
    public List<ChildrenElement> ChildrenElements { get; set; } = new ();

    public void Add(ChildrenElement element)
    {
        if (ChildrenElements.Count == 2) throw new Exception("容量オーバーです。");

        if (ChildrenElements.Count == 1)
        {
            var tmpElement = ChildrenElements.First();

            if (element.Key > tmpElement.Key)
            {
                ChildrenElements.Add(element);
            }
            else
            {
                ChildrenElements.Remove(tmpElement);
                
                ChildrenElements.Add(element);
                ChildrenElements.Add(tmpElement);
            }
        }

        if (ChildrenElements.Count == 0)
        {
            ChildrenElements.Add(element);
        } 
    }

    public void Delete()
    {
        throw new NotImplementedException();
    }
}