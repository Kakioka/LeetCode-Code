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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {

        ListNode current = new ListNode();
        ListNode nextNode = new ListNode();
        current = head;
        int sz = 1;

        //get size of list
        while (current.next != null){
            current = current.next;
            sz++;
        }

        //base case
        if (n == sz) return head.next;

        //reset current
        current = head;
        //iterate through list until current is the nth item
        for(int i=1; i<sz-n; i++){
            current = current.next;
        }

        //since already on n, next = null
        if (n == 1) current.next=null;
        else{
            //skip over the current node since it is the nth node
            nextNode = current.next;
            current.next = nextNode.next;
        };

        //since the end of head points to current and current was n which was then skipped. Thus returning head is the list without the nth element
        return head;

        
    }
}
