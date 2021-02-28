using System;

namespace prob3_18
{
    class Program23
    {
        static void Main(string[] args)
        {
            Console.Write("温度を入力してください(-10～35)：");
            int temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("摂氏{0}度", temperature);

            if (temperature <-10 || temperature > 35)
            {
                Console.Clear();
                Console.WriteLine("適切な値を入力してください。");
            }else if (temperature <0)
            {
                Console.WriteLine("真冬日です");
            }else if (temperature >=25 && temperature < 30)
            {
                Console.WriteLine("夏日です。");
            }else if(temperature >= 30)
            {
                Console.WriteLine("真夏日です。");
            }
        }
    }
}
