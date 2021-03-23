using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] data = new int[5];
            for (int i = 0; i <= 5; i++)
            {
                data[i] = rnd.Next(-10,10)+1;
                Console.Write("{0} ", data[i]);

            }
            Console.Write("\r\n\r\n0より大きい数：");
            for (int i = 0; i < 5; i++)
                if (data[i] > 0) Console.Write("{0} ", data[i]);
            Console.Write("\r\n0より小さい数：");
            for (int i = 0; i < 5; i++)
                if (data[i] < 0) Console.Write("{0} ", data[i]);
            Console.Write("\r\n0の数：");
            for (int i = 0; i < 5; i++)
                if (data[i] == 0) Console.Write("{0} ", data[i]);
        }
    }
}
