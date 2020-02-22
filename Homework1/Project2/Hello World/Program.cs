using System;

namespace Calculator
{
    class Calculator
    {
        public static double Opera(double number1, double number2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "a":
                    result = number1 + number2;
                    break;
                case "s":
                    result = number1 - number2;
                    break;
                case "m":
                    result = number1 * number2;
                    break;
                case "d":
                    if (number2 != 0)
                        result = number1 / number2;
                    break;
            }
            return result;
        }


        class Program
        {
            static void Main(String[] args)
            {
                bool end = false;
                Console.WriteLine("这是一个计算器");

                while (!end)
                {
                    string numInput1 = "";
                    string numInput2 = "";
                    double result = 0;

                    Console.WriteLine("请输入计算的第一个数");
                    numInput1 = Console.ReadLine();
                    double number1 = 0;
                    while (!double.TryParse(numInput1, out number1))
                    {
                        Console.Write("请输入一个数字");
                        numInput1 = Console.ReadLine();
                    }
                    Console.WriteLine("请输入计算的第一个数");
                    numInput2 = Console.ReadLine();
                    double number2 = 0;
                    while (!double.TryParse(numInput2, out number2))
                    {
                        Console.Write("请输入一个数字");
                        numInput2 = Console.ReadLine();
                    }

                    Console.WriteLine("请选择你所要做的计算");
                    Console.WriteLine("\ta-加法");
                    Console.WriteLine("\ts-减法");
                    Console.WriteLine("\tm-乘法");
                    Console.WriteLine("\td-除法");
                    string op = Console.ReadLine();

                    try
                    {
                        result = Calculator.Opera(number1, number2, op);
                        if (double.IsNaN(result))
                            Console.WriteLine("计算出错，请检查");
                        else Console.WriteLine("结果是: {0:0.##}\n", result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("错误" + e.Message);
                    }


                    if (Console.ReadLine() == "n") end = true;

                }


            }
        }
    }
}
   


