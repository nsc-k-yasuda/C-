using System;

namespace prob4_8
{
    class Program31
    {
        static void Main(string[] args)
        {
            //int suuji = 0;
            while (true)
            {
                Console.Write("0以上の数値を入力してください:");
                int suuji = int.Parse(Console.ReadLine());
                if(suuji < 0)
                {
                Console.WriteLine("終了します");
                break;

                }
                else
                {
                    Console.WriteLine(""+suuji);

                }
            }
        }
    }
}
