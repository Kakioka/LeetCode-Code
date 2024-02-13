/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    // Iterative approach
    // Time: O(n)
    // Space: O(1)
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        // Dummy first node, so not to handle a special case for the first group.
        var dummy = new ListNode(0, head);
        var beforeReversing = dummy;
        var endOfCurrentReversing = dummy;

        while (beforeReversing.next is not null)
        {
            // Move the pointer to the end of the reversing sublist.
            for (var i = 0; i < k && endOfCurrentReversing is not null; i++)
            {
                endOfCurrentReversing = endOfCurrentReversing.next;
            }

            // If the pointer points to null, that means that this is the last sublist
            // and its length is less than the group size. We shouldn't reverse incomplete
            // sublists, and should just stop.
            if (endOfCurrentReversing is null)
            {
                break;
            }

            // Reverse sublist iteratively
            ListNode prev = null, current = beforeReversing.next;
            for (var i = 0; i < k; i++)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            // Re-assign pointers accordingly to prepare reversing the next sublist.
            var nextBeforeReversing = beforeReversing.next;
            beforeReversing.next.next = current;
            beforeReversing.next = prev;
            beforeReversing = endOfCurrentReversing = nextBeforeReversing;
        }

        return dummy.next;
    }
    
    // // Recursive approach: Time: O(n), Space: O(k)
    // public ListNode ReverseKGroup(ListNode head, int k)
    // {
    //     // Dummy first node, so not to handle a special case for the first group.
    //     var dummy = new ListNode(0, head);
    //     var beforeReversing = dummy;
    //     var endOfCurrentReversing = dummy;

    //     while (beforeReversing.next is not null)
    //     {
    //         // Move the pointer to the end of the reversing sublist.
    //         for (var i = 0; i < k && endOfCurrentReversing is not null; i++)
    //         {
    //             endOfCurrentReversing = endOfCurrentReversing.next;
    //         }

    //         // If the pointer points to null, that means that this is the last sublist
    //         // and its length is less than the group size. We shouldn't reverse incomplete
    //         // sublists, and should just stop.
    //         if (endOfCurrentReversing is null)
    //         {
    //             break;
    //         }

    //         // Re-assign pointers accordingly to prepare reversing the next sublist.
    //         endOfCurrentReversing = beforeReversing.next;
    //         beforeReversing.next = Reverse(beforeReversing.next, 1);
    //         beforeReversing = endOfCurrentReversing;
    //     }

    //     return dummy.next;

    //     ListNode Reverse(ListNode node, int nodeNum)
    //     {
    //         // If the node num has reached the group size, then it's the end
    //         // of the group to reverse, and we should return the node itself.
    //         if (nodeNum == k)
    //         {
    //             return node;
    //         }

    //         // Reverse sub linked list starting from the next node.
    //         var reversed = Reverse(node.next, nodeNum + 1);

    //         // Re-assign pointers of the current node to align them with
    //         // the reversed list above and keep reversing in the right direction.
    //         var nodeAfterReversed = node.next.next;
    //         node.next.next = node;
    //         node.next = nodeAfterReversed;

    //         return reversed;
    //     }
    // }
}
