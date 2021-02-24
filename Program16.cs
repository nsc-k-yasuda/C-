using System;

namespace prob3_10
{
    class Program16
    {
        static void Main(string[] args)
        {
            Console.Write("1から100までの数値を入力してください:");
            int num = int.Parse(Console.ReadLine());
            if (num >=20 && num < 80)
            {
                Console.WriteLine("20以上80未満です。");    //  numが1だった場合の処理
            }
            else if (num < 20 || num >=80)
            {
                Console.WriteLine("20未満か、80以上です。");    //  numが2だった場合の処理
            }
            else if (num > 1 || num > 100)
            {
                Console.WriteLine("範囲外です。");  //  numが3だった場合の処理
            }
        }
    }
}
