using System;
using System.Collections.Generic;
using System.Text;

namespace prob6_1
{
    class MinMax
    {
        public int Max(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            }else if(n2 > n3)
            {
                return n2;
            }else
            {
                return n3;
            }
        }

        public int Min(int n1, int n2, int n3)
        {
            if (n2 > n1 && n3 > n1)
            {
                return n1;
            }
            else if (n2 > n3)
            {
                return n3;
            }
            else
            {
                return n2;
            }
        }
    }
}
