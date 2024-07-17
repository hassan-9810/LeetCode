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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Create a dummy node to start the merged list
        ListNode dummy = new ListNode();
        ListNode curr = dummy;

        // Traverse both lists and merge them
        while (list1 != null && list2 != null) 
        {
            if (list1.val <= list2.val) 
            {
                curr.next = list1;
                list1 = list1.next;
            } 
            else 
            {
                curr.next = list2;
                list2 = list2.next;
            }
            curr = curr.next;
        }

        // Append the remaining nodes from the non-empty list
        if (list1 != null) 
        {
            curr.next = list1;
        } 
        else 
        {
            curr.next = list2;
        }

        return dummy.next;
    }
}