using System;

namespace project4
{
    class Program
    {
        static void Information(int[] a, out int max, out int min, out int total, out double average)
        {
            max = 0;                                
            min = 10000;
            total = 0;
            for (int i = 0; i < 10; i++)        //求出最大值，最小值，平均值，总数
            {
                if (max < a[i])
                { max = a[i]; }
                if (min > a[i])
                { min = a[i]; }
                total += a[i];
            }
            average = total / 10.0;

        }
        static void Main(string[] args)
        {
            int max, min,total;      //定义所要求的四个变量及数组
            double average;
            int[] array=new int[10];

            Console.Write("请输入10个数组元素的值\n");   //初始化数组
            for (int i = 0; i<10; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            
            Information(array,out max,out min,out total,out average);   
            Console.Write("最大值:{0}最小值:{1}平均值:{2} 总值:{3}",max,min,average,total);
          
        }
    }
}
