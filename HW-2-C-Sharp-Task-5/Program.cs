//Задание 5
//Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать
//его результат. Необходимо поддерживать только две операции: + и –.

using System;

namespace HW_2_C_Sharp_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an arithmetic expression using + and -");
            string expres = Console.ReadLine();
            expres = expres.Replace(" ", "");
            string[] data = expres.Split(new char[] { '+', '-' });
            double[] fData = new Double[data.Length];
            for (int i = 0; i < data.Length; i++)
                fData[i] = Convert.ToDouble(data[i]);
            string arithmOperators = expres;
            for (int i = 0; i < 10; i++)
                arithmOperators = arithmOperators.Replace(Convert.ToChar(i+48), Convert.ToChar(0));
            char[] arr;
            arr = arithmOperators.ToCharArray(0, arithmOperators.Length);
            double itog = fData[0];
            int iterator = 1;
             foreach (char item in arr)
            {
                if (item == '+')
                {
                    itog += fData[iterator];
                    iterator++;
                }
                if (item == '-')
                {
                    itog -= fData[iterator];
                    iterator++;
                }
            }
            Console.WriteLine($"{expres}={itog}");
        }
    }
}
