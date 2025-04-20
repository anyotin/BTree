using System.Net.Sockets;

namespace BTree;

public abstract class Node
{
    public int No = new Random().Next(Int32.MaxValue);
}