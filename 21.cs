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
        List<int> first = new List<int>();
        List<int> second = new List<int>();

        while (list1 != null) {
            first.Add(list1.val);
            list1 = list1.next;
        }

        while (list2 != null) {
            second.Add(list2.val);
            list2 = list2.next;
        }
    
        List<int> merged = first.Concat(second).ToList();
        merged.Sort();
        ListNode dummy = new ListNode(); 
        ListNode current = dummy; 

        foreach (int num in merged) {
            current.next = new ListNode(num); 
            current = current.next; 
        }
        
        return dummy.next;
    }
}
