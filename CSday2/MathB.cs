using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSday2
{
    class MathB:MathA
    {
        public void sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("MathB - Subtraction result = " + result);
        }

        new public void add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("MathB Override - Addition result = " + result);
        }
    }
}
