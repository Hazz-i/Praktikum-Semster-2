using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload
{
    internal class overload
    {
        // fungsi non void (membalikan nilai)

        // mencari nilai min 

        public int nilaiMin(int a, float b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return (int)b;
            }
        }
        public int nilaiMin(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }

        // mencari nilai max
        public int nilaiMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
}

