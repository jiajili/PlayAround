﻿using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_143
    {
        public void ReorderList(ListNode head)
        {
            if (head != null && head.next != null)
            {

                ListNode slow = head;
                ListNode fast = head;

                //use a fast and slow pointer to break the link to two parts.
                while (fast != null && fast.next != null && fast.next.next != null)
                {
                    //why need third/second condition?
                    slow = slow.next;
                    fast = fast.next.next;
                }

                ListNode second = slow.next;
                slow.next = null;// need to close first part

                // now should have two lists: head and fast

                // reverse order for second part
                second = Reverse(second);

                ListNode p1 = head;
                ListNode p2 = second;

                //merge two lists here
                while (p2 != null)
                {
                    ListNode temp1 = p1.next;
                    ListNode temp2 = p2.next;

                    p1.next = p2;
                    p2.next = temp1;

                    p1 = temp1;
                    p2 = temp2;
                }
            }
        }

        private ListNode Reverse(ListNode head)
        {
            if (head == null || head.next == null) return head;
         
            ListNode pre = head;
            ListNode curr = head.next;

            while (curr != null)
            {
                ListNode temp = curr.next;
                curr.next = pre;
                pre = curr;
                curr = temp;
            }

            // set head node's next
            head.next = null;

            return pre;
        }
    }
}
