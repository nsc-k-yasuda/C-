﻿using System;

namespace Problemex7_1
{
    class Program
    {
        //  デリゲート
        delegate void Delfunc();
        static void Func1()
        {
            Console.WriteLine("Func1");
        }
        static void Func2()
        {
            Console.WriteLine("Func2");
        }
        static void Main(string[] args)
        {
            //Delfunc df = new Delfunc(Func1);
            Delfunc df = new Delfunc(Func2);
            df();
        }
    }
}
