using System;
using System.Collections.Generic;
using System.Linq;
public class Program34
{
    public static void Main(string[] args)
    {

        int x;
        List<int> rndlist = new List<int>();
        Random rnd = new Random();
        for (int i = 1; i <= 5; i++)
        {
            x = rnd.Next(101);
            Console.WriteLine(x);
            rndlist.Add(x);
        }
        int min = rndlist.Min();
        int max = rndlist.Max();
        Console.WriteLine("最小値:" + min);
        Console.WriteLine("最大値:" + max);

    }
}

//using System;
//using System.Linq;

//namespace prob4_11
//{
//    class Program34
//    {
//        static void Main(string[] args)
//        {

//            Random rnd = new Random();
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.WriteLine("最大値：{0}", rnd.Max(rnd.Next(101)));
//            }            
//        }
//    }
//}
