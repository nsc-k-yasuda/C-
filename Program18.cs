using System;

namespace prob3_13
{
    class Program18
    {
        static void Main(string[] args)
        {
            Console.Write("1から3の値を入力（1:グー 2:パー 3:チョキ):");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("グー");    //  numが1だった場合の処理
                    break;
                case 2:
                    Console.WriteLine("パー");    //  numが2だった場合の処理
                    break;
                case 3:
                    Console.WriteLine("チョキ");  //  numが3だった場合の処理
                    break;
                default:
                    Console.WriteLine("正しい値ではありません"); //  それ以外の値が入力された場合の処理
                    break;
            }
        }
    }
}
