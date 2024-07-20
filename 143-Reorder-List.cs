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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) 
        {
            return;
        }

        // Find the middle of the list
        ListNode slow = head;
        ListNode fast = head;
        while (fast.next != null && fast.next.next != null) 
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        // Reverse the second half of the list
        ListNode secondHalf = ReverseList(slow.next);
        slow.next = null;

        // Merge the two halves of the list
        MergeLists(head, secondHalf);
    }

    private ListNode ReverseList(ListNode head) 
    {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) 
        {
            ListNode nextNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextNode;
        }
        return prev;
    }

    private void MergeLists(ListNode list1, ListNode list2) 
    {
        while (list2 != null) 
        {
            ListNode list1Next = list1.next;
            ListNode list2Next = list2.next;

            list1.next = list2;
            list2.next = list1Next;

            list1 = list1Next;
            list2 = list2Next;
        }
    }
}