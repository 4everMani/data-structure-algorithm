using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LLTraversing
    {
        public static void Traverse(int[] arr)
        {
            var head = ConvertArrayToLL.Convert2LL(arr);
            var mover = head; // to prevent tempering head

            while (mover.Next != null)
            {
                Console.Write(mover.Value + " ");
                mover = mover.Next;
            }
        }
    }
}
