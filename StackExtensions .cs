using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_OTUS
{
    public static class StackExtensions
    {

        public static void Merge(this Stack stack1, Stack stack2)
        {
            for (var i = stack2.size - 1; i >= 0; i--)
            {
                stack1.Add(stack2.Pop());
            }

            stack1.messageStorage();
        }
        
    }
}
