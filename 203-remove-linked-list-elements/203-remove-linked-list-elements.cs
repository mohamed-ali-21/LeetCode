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
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null)
            return null;
        
        ListNode curr = head;
        
        while (curr != null)
        {
            if (curr.next == null)
            {
                if (curr.val == val)
                    curr = null;
                else
                    break;
            }
            else if (curr.next.val == val)
                curr.next = curr.next.next;
            else
                curr = curr.next;
        }
        
        if (head != null && head.val == val)
            head = head.next;
        
        return head;
    }
}