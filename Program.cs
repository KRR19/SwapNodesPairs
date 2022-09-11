internal class Program
{
      public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }

     public ListNode Add(int v){
        next = new ListNode(v);
        return this.next;
     }
    }
    private static void Main(string[] args)
    {
        ListNode l1 = Adds(new int[] {1,2, 3, 4});
        ListNode r = SwapPairs(l1);
        while (r?.val != null)
        {
            Console.WriteLine(r.val);
            r = r.next;
        }
    }

private static ListNode Adds(int[] vals)
 {
    ListNode root = new ListNode(vals[0]);
    ListNode s = root;
    for (int i = 1; i < vals.Length; i++)
    {
        s = s.Add(vals[i]);
    }
    return root;
 }

     public static ListNode SwapPairs(ListNode head) {
        if(head?.val == null || head?.next == null) return head;

        ListNode rootResult = new ListNode(head.next.val, new ListNode(head.val));
        ListNode current = rootResult;
        head = head?.next?.next;
        current = current.next;
        
        while(head != null) {
            current.next = head.next != null ? new ListNode(head.next.val, new ListNode(head.val)) : new ListNode(head.val);
            current = current?.next?.next;
            head = head?.next?.next;
        }
        return rootResult;
    }
}