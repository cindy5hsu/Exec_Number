using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        //Q3.有一個數值,是四位數
        //   左邊二位的數字相同
        //   右邊二位的數字相同
        //   這個四位數值, 剛好也是某整數的平方
        //   請問這個四位數值是什麼 ?
        static void Main(string[] args)
        {
            
            string s;
            for (int i = 1000; i <= 9999; i++)
            {
                s = i.ToString();//converting toa a string
                if (s[0] == s[1] && s[2] == s[3])
                {
                    for (int j = 0; j < 100; j++)
                        if ((j * j) == i) { Console.WriteLine(i); }
                }
            }

            //////////////////
            //老師寫法
            //    for(int i = 1; i <10; i++)
            //    {
            //        for(int k = 1; k <10; k++)
            //        {
            //            //int number = i * 1100 + k * 11;
            //            int number = i * 1000 + i * 100 + k * 10 + k;//目前四位數
            //            double sqrt = Math.Sqrt(number);//這個數開sqrt
            //            if(sqrt == Math.Floor(sqrt))
            //            {
            //                Console.WriteLine(number);
            //            }

            //        }
            //    }

            //一行寫法
            //int begin = (int)Math.Ceiling(Math.Sqrt(1000));//34
            ////多行寫法
            //double n1 = Math.Sqrt(1000);//計算開根號值
            //double n2 = Math.Ceiling(n1);
            //int begin2 = (int)n2;


            //int end = (int)Math.Ceiling(Math.Sqrt(9999));//99
        }
    }
}
