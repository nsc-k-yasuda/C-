using System;

namespace prob7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            c.Number1 = 8;    //  一つ目の数をセット
            c.Number2 = 9;    //  二つ目の数をセット
            //  二つの数の和を表示
            Console.WriteLine("{0} + {1} = {2}", c.Number1, c.Number2, c.Add());
            //  二つの数の差を表示
            Console.WriteLine("{0} - {1} = {2}", c.Number1, c.Number2, c.Sub());
        }
    }
}
