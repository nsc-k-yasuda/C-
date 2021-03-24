using System;
using System.Collections.Generic;
using System.Text;

namespace prob6_3
{
    class Circle
    {
        //  半径
        public double r;
        //  円周の長さを求める
        public double Circumference()
        {
            return 2 * 3.14 * r;
        }
        public double Area()
        {
            return r * r * 3.14 ;
        }
    }
}
