using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace probex6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英語で動物の名前を入力してください：");
            string a = Console.ReadLine();
            //  連想記憶クラスの生成
            Dictionary<String, String> animal = new Dictionary<String, String>();

            //  データの追加
            animal["cat"] = "猫";
            animal["dog"] = "犬";
            animal["bird"] = "鳥";
            animal["tiger"] = "トラ";

            if(a == "cat") { 
                  Console.WriteLine("「{0}」です。", animal); 
            }else if(a == "dog")
            {
                Console.WriteLine("「{0}」です。",  animal);
            }
            else if (a == "bird")
            {
                Console.WriteLine("「{0}」です。",  animal);
            }
            else if (a == "tiger")
            {
                Console.WriteLine("「{0}」です。",  animal);
            }else
            {
                Console.WriteLine("対応するデータは登録されていません。");
            }
            
        }
    }
}
