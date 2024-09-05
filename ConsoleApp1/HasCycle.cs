using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class HasCycle
    {
        //Floyd's Cycle Detection (Hare and Tortoise)

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; next = null; }
        }

        public static bool HasCycleMethod(ListNode head)
        {
            if (head == null || head.next == null)
                return false; // Liste boş veya tek düğümlü, döngü olamaz.

            ListNode slow = head; // Kaplumbağa (yavaş ilerler)
            ListNode fast = head.next; // Tavşan (hızlı ilerler)

            while (slow != fast) // Kaplumbağa ve tavşan buluşana kadar
            {
                if (fast == null || fast.next == null)
                    return false; // Tavşan son düğüme ulaştı, döngü yok.

                slow = slow.next; // Kaplumbağa bir düğüm ilerler
                fast = fast.next.next; // Tavşan iki düğüm ilerler
            }

            return true; // Kaplumbağa ve tavşan buluştu, döngü var.
        }
    }
}
