namespace CodingTests.Models;

public class Node
{
    public int Val { get; set; }
    public Node? Next { get; set; }

    public Node(int val, Node? next = null)
    {
        Val = val;
        Next = next;
    }
}