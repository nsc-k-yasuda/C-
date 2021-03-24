using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob5_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 乱数クラスはループの外で生成しましょう。
            // デフォルトコンストラクタで生成すると
            // 時間をシードとして初期化してくれます。
            Random rnd = new Random();
            int[] date = new int[7];
            for (int i = 0; i < date.Length; i++)
            {
                // 乱数値は配列に格納します。
                // Next関数で取得できる乱数は minValue以上 maxValue未満なので、
                // 10までの数値がほしい場合11にする必要があります。
                date[i] = rnd.Next(1, 11);
                Console.Write(date[i] + " ");
            }
            // 改行を出力
            Console.WriteLine();

            for (int i = 0; i < date.Length; i++)
            {
                // 取得した乱数の数値分だけループ
                for (int j = 0; j < date[i]; j++)
                {
                    // *を出力
                    Console.Write("*");
                }
                // 改行を出力
                Console.WriteLine();
            }
        }
    }
}
