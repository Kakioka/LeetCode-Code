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

/*
Apprently it's better to iterate through and add on to a pointer attached to a dummyhead or like an unused starting point then return the next of that starting point being the rest of the list that you added on to
But I like recursion better here, feels like the perfect time for it. 
*/
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        //base cases
        if(list1 == null) return list2;
        if(list2 == null) return list1;
        if(list1.val <= list2.val){
            lis t1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }else{
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }
}
