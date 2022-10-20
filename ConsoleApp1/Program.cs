using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q.4百元買百雞
            //想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
            //字彙表:
            //公雞(Cock), 母雞(Hen), 小雞(Chicken)
           

            //y用聯立方程式，可以導出公式7x+4y=100,缺點是單價變動，就又要人工導出新公式，比較難維護程式
            //用回圈，缺點是需要跑100萬圈（100+100+100）
            int count = 0;//計算回圈
            for(int cock = 0; cock <= 100/5; cock++)
            {
                for (int hen = 0; hen <= (100 - 5*cock)/3; hen++)
                {
                    count++;
                    int chicken = 100 - cock - hen;

                    //判斷總價是一百
                    double price =  5 * cock + 3 * hen + (double)chicken / 3.0;
                    if(price == 100)
                    {
                        Console.WriteLine($"公鷄{cock}隻， 母鷄{hen}隻, 小鷄{chicken}隻");
                    }
                }
            }
            Console.WriteLine($"共{count}圈");

            //List<float> rooster = new List<float>();
            //List<float> hen = new List<float>();
            //List<float> chicken = new List<float>();

            //float x=0.0f;

            //for(float i=0; i<=100; i++)
            //{
            //    x = (200 - (8 * i)) / 14;//equation
            //    if ((int)x == x && x >= 0.0f)//checking if it is a integer
            //    {
            //        rooster.Add(x);//appending to lists
            //        hen.Add(i);
            //        chicken.Add(100 - (x + i));
            //    }
            //}
            //for (int i = 0; i <= 3; i++)
            //{
            //    System.Console.Write(rooster[i] + " ");//printing
            //}
            //Console.WriteLine("\n");
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.Write(hen[i] + " ");
            //}
            //Console.Write("\n");
            //for(int i = 0; i <= 3; i++)
            //{
            //    Console.Write(chicken[i] + " ");
            //}


        }
    }
}
