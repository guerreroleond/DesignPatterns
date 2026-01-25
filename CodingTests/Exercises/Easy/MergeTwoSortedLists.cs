using CodingTests.Models;

namespace CodingTests.Exercises.Easy;

public class MergeTwoSortedLists
{
    public static Node? RecursiveMerge(Node? list1, Node? list2)
    {
        if(list1 == null) return list2;
        if(list2 == null) return list1;

        if (list1.Val < list2.Val)
        {
              list1.Next =  RecursiveMerge(list1.Next, list2);
              return list1;
        }
        else
        {
            list2.Next =  RecursiveMerge(list2.Next, list1);
            return list2;
        }
    }
    
    // Input:   l1 = [1][2][3]
    //          l2 = [1][3][4]
    // Output -> [1][1][2][3][3][4]
    public static Node? IterativeMerge(Node? list1, Node? list2)
    {
        // Dummy node to simplify head handling.
        var dummy = new Node(-1);
        var tail = dummy;

        while (list1 is not null
            && list2 is not null)
        {
            if (list1.Val <= list2.Val)
            {
                tail.Next = list1;
                list1 = list1.Next;
            }
            else
            {
                tail.Next = list2;
                list2 = list2.Next;
            }
            
            tail = tail.Next;
        }
        
        // Append the remaining nodes (only one list will have leftovers).
        tail.Next = list1 ?? list2;
        
        return dummy.Next; //Skip dummy head.
    }
    
    
    //Input: l1 = [1,2,4],
    //      l2 = [1,3,4,5,6]
    //  → Output: [1,1,2,3,4,4,5,6]
    public static LinkedList<int> Solution(
        LinkedList<int> firstList, LinkedList<int> secondList)
    {
        var result = new LinkedList<int>(firstList);
        LinkedListNode<int> pointer = null;
        
        foreach (var number in secondList)
        {
            var node = secondList.Find(number);
            pointer = PlaceNode(node, firstList, pointer);
        }
        return firstList;
    }

    // Todo: Review when insert after the last node.
    private static LinkedListNode<int>? PlaceNode(
        LinkedListNode<int> node, LinkedList<int> list, LinkedListNode<int>? pointer)
    {
        //var tempList = new LinkedList<int>(list);
        LinkedListNode<int> currentNode = null;
        // First time -> no pointer.
        if (pointer is null)
        {
            currentNode = list.First;
        }
        else
        {
            currentNode = list.FindLast(pointer.Value);
        }
        
        while (currentNode is not null)
        {
            if (node.Value == currentNode.Value)
            {
                list.AddAfter(currentNode, node.Value);
                var pointerResult = list.FindLast(node.Value);
                return pointerResult;
            }

            if (currentNode.Next is not null)
            {
                if(node.Value > currentNode.Value
                && node.Value < currentNode.Next.Value)
                {
                    list.AddBefore(currentNode.Next, node.Value);
                    var pointerResult = list.FindLast(node.Value);
                    return pointerResult;
                }
            }
            else
            { // Last node.
                if (node.Value > currentNode.Value)
                {
                    list.AddAfter(currentNode, node.Value);
                    return list.FindLast(node.Value);
                }
            }
            currentNode = currentNode.Next;
        }
        return null;
    }
}