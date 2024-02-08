/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */

/*
Kinda stupid solution utilizing a stack, took about 3 minutes; extremely innefficient
*/

public class MySolution {
    public bool HasCycle(ListNode head) {
        Stack<ListNode> stack = new Stack<ListNode>();

        while(head != null){
            if(stack.Contains(head.next)) return true;

            stack.Push(head);

            head = head.next;
        }
        return false;
    }
}

/*
  This is apparently Floyd's Cycle Finding Algorithm
*/
public class FastestSolution {
    public bool HasCycle(ListNode head) {
        ListNode fast = head, slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow) return true;
        }
        return false;
    }
}
