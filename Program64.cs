using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probex6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            int c = 0;
            while (true)
            {
                Console.Write("文字列を入力:");
                a.Add(Console.ReadLine());
                if (a[c] == "")
                {
                    break;
                }c++;
            }
            Console.WriteLine();
            foreach (string i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
