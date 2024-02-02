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

//reorder order: let k be an integer where 0 <= k < n
//k, n-k, k+1, n-k+1, etc.
//first find n where n = length of linked list

public class Solution {
    public void ReorderList(ListNode head) {
        ListNode straight = head, reverse = head.next;
        //split
        while(reverse != null && reverse.next != null){
            reverse = reverse.next.next;
            straight = straight.next;
        }

        //left is first half, right is second
        ListNode right = straight.next, left = head;

        //break link between first and second half
        straight.next = null;

        //reverse right
        ListNode prev = null, curr = right;
        while(curr != null){
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        //prev is head of reversed list, so set right to prev
        right = prev;

        //merge
        while(right != null){
            //maintain reference of next nodes of left and right
            ListNode leftTemp = left.next, rightTemp = right.next;
            //set right pointer to left.next
            left.next = right;
            //merge maintained reference of left.next in front of right
            right.next = leftTemp;

            //move ahead
            left = leftTemp;
            right = rightTemp;
        }
    }
}
