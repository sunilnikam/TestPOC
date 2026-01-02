using System;
using System.Collections.Generic;
using System.Text;

//  Floyd’s Cycle-Finding Algorithm (Tortoise and Hare Algorithm)

namespace TestPOC.Approach
{
    internal class Q05_CyclinLinkedList
    {
        //  How do you detect a cycle in a linked list?
        // Floyd’s Cycle-Finding Algorithm (Tortoise and Hare Algorithm)

        /*
            This algorithm uses two pointers that traverse the linked list at different speeds: 
                The Tortoise (Slow Pointer): Moves one node at a time.
                The Hare (Fast Pointer): Moves two nodes at a time. 


         */
    }
}

// Definition for a singly-linked list node.
public class ListNode
{
    public int val;
    public ListNode? next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }

}

public class Solution
{
    /// <summary>
    /// Detects if a cycle exists in a linked list using the Tortoise and Hare algorithm.
    /// </summary>
    public bool HasCycle(ListNode head)
    {
        // If the list is empty or has only one node, a cycle is impossible.
        if (head == null || head.next == null)
        {
            return false;
        }
        
        // Initialize two pointers: slow (tortoise) and fast (hare)
        ListNode? slow = head;
        ListNode? fast = head;

        // Traverse the list
        // The loop continues as long as the fast pointer can move two steps forward.
        while (fast != null && fast.next != null)
        {
            slow = slow?.next;      // Move slow pointer by 1 step
            fast = fast.next.next; // Move fast pointer by 2 steps

            // Check if the pointers meet (collision)
            if (slow == fast)
            {
                return true; // Cycle detected
            }
        }

        // If the loop completes without a collision, the fast pointer reached the end of the list.
        return false; // No cycle
    }
}

