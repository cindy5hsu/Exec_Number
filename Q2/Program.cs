using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q2.找出數值區間內的所有質數
            string strResult = "";//存輸出的結果
            for(int i = 2; i < 101; i++)
            {
                bool isPrimeNumber = true;//每一個數都是質數
                //每一個除以之前所有的數
                for(int k = 2; k < i-1; k++)
                {
                    //取于的結果為0，說明那被整除，即不是質數
                    if(i%k == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                }
                //如果是質數,則記錄到結果中
                if (isPrimeNumber) strResult += i + ", ";
            }
            Console.WriteLine("1-100之内的質數有：" + strResult);
            Console.ReadLine();

        }
    }
}
