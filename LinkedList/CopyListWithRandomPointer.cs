/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

/*
Imma be real, this one was low key beyond me, had to check the solution to understand what it wanted. 
After that though, I understood, it's not super complicated, just difficult to explain I think.
The output was also confusing me but I think I'm just dumb lol
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        //base case
        if (head == null) return null;

        //dictionary to keep track of each node and it's random node associated
        //the order of being added to the dictionary will dictate how we recreate the list
        Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
        
        Node curr = head;
        //add everything to dictionary
        while(curr != null){
            dict[curr] = new Node(curr.val);
            curr = curr.next;
        }

        //iterate through setting the nexts and randoms based on curr which is a copy of head
        curr = head;
        while(curr != null){
            //ternaries checking for null and setting if not
            dict[curr].next = curr.next != null ? dict[curr.next] : null;
            dict[curr].random = curr.random != null ? dict[curr.random] : null;
            curr = curr.next;
        }

        //this is the beginning of the List stored in dict
        return dict[head];

    }
}
