using System;

namespace prob3_13
{
    class Program19
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a,bに1から10までの数値を入力してください。");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if(a < 1 || a>10 || b < 1 || b>10)
            {
                Console.WriteLine("範囲外です。");
            }
            else if (a > b)
            {
                Console.WriteLine("aのほうが大きいです。");  //  正の数だった場合に実行
            }
            else if(a < b)
            {
                Console.WriteLine("bのほうが大きいです。");
            }
            else
            {
                Console.WriteLine("等しいです。");
            }
        }
    }
}
