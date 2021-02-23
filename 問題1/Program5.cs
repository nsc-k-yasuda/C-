using System;

namespace prob2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            Console.Write("文字列１を入力:");
            str1 = Console.ReadLine();  //  １つ目の文字列を入力
            Console.Write("文字列２を入力:");
            str2 = Console.ReadLine();  //  ２つ目の文字列を入力
            Console.WriteLine("文字列１ + 文字列２ = {0}", str1 + str2);
        } 
    }
}
