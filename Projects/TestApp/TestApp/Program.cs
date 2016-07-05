using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public int GetSum(int a, int b)
        {
            int value = a ^ b;
            int carry = 0;
            List<int> c = new List<int> { 0 };
            while (c.Count != 32)
            {
                int tmp = (c.Last() == 1 && (((a & 1) == 1) || ((b & 1) == 1))) || (((a & 1) == 1) && ((b & 1) == 1))
                    ? 1
                    : 0;
                c.Add(tmp);
                a >>= 1;
                b >>= 1;
            }
            while (c.Count != 0)
            {
                var tempValue = c.Last();
                carry = (carry << 1) | tempValue;
                c.RemoveAt(c.Count - 1);
            }
            return value ^ carry;
        }
    }
}
