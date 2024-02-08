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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0) {
        //null check
        if(l1 == null && l2 == null && carry == 0) return null;

        //adding
        //add only if l1/l2 are not null/exist otherwise add 0
        //l1? checks if l1 is null, then accesses val if not. It then checks if the whole thing is null and returns 0 if so
        //the main thing with the intial "?" is to maintain safety with nullable variables
        int current = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;

       //calculating the carry
        carry = current/10;

        //returning
        //this is recursive, stops when everything is null and carry is 0
        return new ListNode(current%10, AddTwoNumbers(l1?.next, l2?.next, carry));
    }
}
