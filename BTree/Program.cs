using BTree;

var treeField = new TreeField();
var fieldManager = new FieldManager(treeField);

var children = new ChildrenElement() { Key = 11, Value = "test" };
fieldManager.AddElement(children);

children = new ChildrenElement() { Key = 31, Value = "test31" };
fieldManager.AddElement(children);

children = new ChildrenElement() { Key = 21, Value = "test21" };
fieldManager.AddElement(children);