using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob2_3
{
    class Program
    {
        static int Square(int a, int b)
        {
            return a+b;
        } 
        static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(1, 11);  //  aに1から10の乱数を代入
            int b = r.Next(1, 11);  //  bに1から10の乱数を代入
            int result = Square(a, b);  
            Console.WriteLine("たて： " + a);
            Console.WriteLine("よこ： " + b);
            Console.WriteLine("■", result);
        }
    }
}
