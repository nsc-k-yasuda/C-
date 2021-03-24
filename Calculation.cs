using System;
using System.Collections.Generic;
using System.Text;

namespace prob7_3
{
    class Calculation
    {
        private int number1;
        //  二つ目の文字列
        private int number2;
        //  一つ目の文字列を設定
        public int Number1
        {
            set { number1 = value; }
            get { return number1; }
        }
        //  一つ目の文字列を設定
        public int Number2
        {
            set { number2 = value; }
            get { return number2; }
        }
        public int Add()
        {
            return number1 + number2;
        }
        public int Sub()
        {
            return number1 - number2;
        }
    }
}
