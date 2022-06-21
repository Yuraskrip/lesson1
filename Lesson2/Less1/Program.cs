using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less1
{
    internal class Program
    {
        /// <summary>
        /// Задание 1. Вычисление простое ли число.
        /// </summary>
        static void Task1()
        {
            bool chislo = true;
            Console.WriteLine("Введите число\n");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    chislo = false;
                    break;
                }
            }
            if (chislo)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }
            Console.ReadKey();


        }

        /// <summary>
        /// Задание 2. Определение сложности
        /// </summary>
        static void Task2()
        {

            //Сложность O(3^n)

             int StrangeSum(int[] inputArray)
            {
                int sum = 0;
                for (int i = 0; i < inputArray.Length; i++)
                {
                    for (int j = 0; j < inputArray.Length; j++)
                    {
                    for (int k = 0; k < inputArray.Length; k++)
                        {
                            int y = 0;
                            if (j != 0)
                            {
                                y = k / j;
                            }
                            sum += inputArray[i] + i + k + j + y;
                        }
                    }
                }
                return sum;
            }



        }

        /// <summary>
        /// Задание 3. Функция вычисления числа Фибоначчи
        /// </summary>
        static void Task3()
        {
            
            bool f = true;
            while (f)
            {
                Console.Clear();
                Console.WriteLine("Функция вычисления числа Фибоначчи");
                Console.WriteLine("\nВычисление числа Фибоначчи через цикл - нажмите 1");
                Console.WriteLine("Вычисление числа Фибоначчи рекурсией - нажмите 2");
                Console.WriteLine("\nВыход в основное меню - нажмите 0");


                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        f = false;
                        return;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите любое число для окончания цикла Фибоначи");
                        int z = int.Parse(Console.ReadLine());
                        int j = 1;
                        for (int i = 1; i <= z; i += j)
                        {
                            Console.Write("{0}" + " ", i);
                            j = i - j;
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                       Console.Clear();
                        Console.WriteLine("Введите любое число от 1 до 46");
                        int n = int.Parse(Console.ReadLine());
                        if (n > 0 && n < 47)
                        {
                            if (n == 1)  {
                                Console.WriteLine(0);
                            } else  {
                                Fibonachi(0, 1, n);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Повторите ввод");
                        }
   
                        Console.ReadKey(true);

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Повторите ввод");
                        break;
                }
            }

        }
        /// <summary>
        /// Вычисление числа Фибоначчи
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="n">кол-во итераций</param>
        /// <returns></returns>
        static int Fibonachi(int x1, int x2, int n)
        {
            Console.Write(x1 + " ");
            if (n == 0)
            {
                return x1;
            }

            return Fibonachi(x2, x1 + x2, n-1);
        }


        static void Main(string[] args)
        {
            bool f = true;
            while (f)
            {
                Console.Clear();
                Console.WriteLine("\nДомашнее задание 1 урока. Алгоритмы и структура данных\nВыполнил Козак Юрий Викторович");
                Console.WriteLine("__________________________________________________________________________________________");
                Console.WriteLine("Содержание:");
                Console.WriteLine("\nЗадание 1 - нажмите 1\nОпределение простого числа");
                Console.WriteLine("\nЗадание 2 - нажмите 2\nОпределение сложности");
                Console.WriteLine("\nЗадание 3 - нажмите 3\nЧисло Фибоначчи");
                Console.WriteLine("\nДля выхода из программы нажмите 0");
                Console.WriteLine("__________________________________________________________________________________________");

                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 0:
                        f = false;
                        Console.WriteLine("До скорых встреч!");
                        return;
                    case 1:
                        Console.Clear();
                        Task1();
                        break;
                    case 2:
                        Console.Clear();
                        Task2();
                        break;
                    case 3:
                        Console.Clear();
                        Task3();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Повторите ввод");
                        break;
                }

            }

        }
    }
}
