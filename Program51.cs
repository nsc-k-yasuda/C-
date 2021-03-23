using System;

namespace prob5_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int [ , ]  data = new int [ 3, 3 ];
            int a, b;


            for (a = 0; a < data.GetLength(0); a++)
            {

                for (b = 0; b < data.GetLength(1); b++)
                {
                    data[a, b] = rnd.Next(0, 10);
                }
            }

            for (a = 0; a < data.GetLength(0); a++)
            {
                for (b = 0; b < data.GetLength(1); b++)
                {
                    Console.Write( "data[ {0} ]  [ {1} ] = {2} ", a , b , data[ a, b ] );

                }
                Console.WriteLine();
            }
        }
    }
}
