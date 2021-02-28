using System;

namespace prob3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字１を入力：");
            string str1 = Console.ReadLine();
            Console.Write("文字２を入力：");
            string str2 = Console.ReadLine();
            if(str1 == str2)
            {
                Console.WriteLine("２つの文字列は等しい");
            }
            else
            {
                Console.WriteLine("２つの文字列は等しくない");
            }
        }
    }
}
