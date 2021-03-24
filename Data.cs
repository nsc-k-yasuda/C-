using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace prob7_1
{
    class Data
    {
        //  メンバ変数number
        private int number = 100;
        //  メンバ変数comment
        private string comment = "";
        public void Datas()
        {
            Console.WriteLine("number = {0} ", number);
            Console.WriteLine("comment = {0}", comment);
        }
        //  data1のプロパティ（読み込みオンリー）
        public int Number
        {
            get { return number; }
        }
        //  data2のプロパティ（書き込みオンリー）
        public string Comment
        {
            set { comment = value; }
        }
    }
}
