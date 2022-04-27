using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}!, сегодня {DateTime.Now}");


            Console.ReadLine(); 
            //не понял где именно нужно поставить точку останова, но тут программа работает
        }


    }

}

