namespace BTree;

public class FieldManager
{
    public TreeField TreeField { get; }

    public FieldManager(TreeField treeField)
    {
        TreeField = treeField;
    }

    public void AddElement(ChildrenElement childrenElement)
    {
        var currentNode = GetTargetNode(childrenElement.Key);

        if (currentNode.ChildrenElements.Count == 2)
        {
            // ノードの整理
            OrganizeChildrenNode(childrenElement);


        }
        else if(currentNode.ChildrenElements.Count == 1)
        {
            currentNode.Add(childrenElement);
        }
        else
        {
            currentNode.Add(childrenElement);
            TreeField.ChildrenNodes.Add(currentNode);
        }
    }
    
    private ChildrenNode GetTargetNode(int key)
    {
        if (TreeField.RootNode is null)
        {
            return TreeField.ChildrenNodes.FirstOrDefault() ?? new ChildrenNode();
        }

        return new ChildrenNode();
    }

    private void OrganizeChildrenNode(ChildrenElement childrenElement)
    {
        var targetNode = GetTargetNode(childrenElement.Key);
        
        var compareCategory = childrenElement.Key < targetNode.ChildrenElements[0].Key ? CompareEnum.Smaller :
            childrenElement.Key <= targetNode.ChildrenElements[1].Key ? CompareEnum.Between : CompareEnum.Larger;

        var newChildrenNode = new ChildrenNode();
        
        switch (compareCategory)
        {
            case CompareEnum.Smaller:
                newChildrenNode.Add(childrenElement);
                TreeField.ChildrenNodes.Add(newChildrenNode);
                break;
            case CompareEnum.Between:
                var smallElement = targetNode.ChildrenElements.OrderBy(p => p.Key).First();
                var largeElement = targetNode.ChildrenElements.OrderByDescending(p => p.Key).First();

                targetNode.ChildrenElements.Remove(largeElement);
                
                newChildrenNode.Add(childrenElement);
                newChildrenNode.Add(largeElement);
                TreeField.ChildrenNodes.Add(newChildrenNode);
                break;
            case CompareEnum.Larger:
                newChildrenNode.Add(childrenElement);
                TreeField.ChildrenNodes.Add(newChildrenNode);
                break;
        }
    }
}