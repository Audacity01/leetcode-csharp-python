public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null) return false;

        var slow = head;
        var fast = head;
        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) return true;
        }
        return false;
    }
}
