using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace addTwoNumbers
{
    public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        // dummy is the starting point of the list;
        ListNode pointer = dummy;
        // pointer points to the last node, in this case, dummy;
        int carry = 0;
        // Stores the carry value;
            while (l1 != null || l2 != null || carry != 0){
                int value1 =  l1 != null ? l1.val : 0;
                int value2 =  l2 != null ? l2.val : 0;
                // turns able to handle lists with different lengths;


                int sum = value1 + value2 + carry;
                int digit = sum % 10;
                carry = sum / 10;

                ListNode newNode = new ListNode(digit);
                pointer.next = newNode;
                pointer = newNode;

                if(l1 != null){
                    l1 = l1.next;
                };
                if(l2 != null){
                    l2 = l2.next;
                };
            }
            return dummy.next;
            // Discard dummy value from answer;
    }
}
}