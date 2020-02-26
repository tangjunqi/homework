using System;

namespace project5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[101];     //创建整数数组，并初始化，以0标准为素数
            for (int i = 1; i < 101; i++)
                number[i] = 0;
           
            for (int i = 2; i <= 50; i++)    //筛选，剔除非素数
                for (int j = 2; i * j <= 100; j++)
                    number[i * j] = 1;

            for (int i = 2; i < 101; i++)    //显示素数
                if (number[i] == 0)
                { Console.WriteLine(i); }           
        }
    }
}
