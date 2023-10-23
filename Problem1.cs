public class ReverseLinkedList
    {
        //Iterative
        // Time Complexity : O(n)
        // Space Complexity : O(1)
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No
        public ListNode ReverseListIterative(ListNode head)
        {
            //edge case
            if (head == null || head.next == null)
                return head;

            ListNode prev = null;
            ListNode curr = head;
            ListNode temp = head.next;

            //base case
            while (temp != null)
            {
                curr.next = prev;
                prev = curr;
                curr = temp;
                temp = temp.next;
            }

            curr.next = prev;
            return curr;

        }

        //Recursion
        // Time Complexity : O(n)
        // Space Complexity : O(n)
        // Did this code successfully run on Leetcode : Yes
        // Any problem you faced while coding this : No
        public ListNode ReverseListRecursion(ListNode head)
        {
            //base case
            if (head == null || head.next == null)
                return head;

            ListNode result = ReverseListRecursion(head.next);
            Console.WriteLine(result.val);

            head.next.next = head;
            head.next = null;
            return result;
        }
    }
