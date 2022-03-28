using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_27
{
    //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 0;
            int summ_number = 0;
            int i;
           
            Console.Write("введите число: ");
            number = int.Parse(Console.ReadLine());

            Console.Write($"сумма цифр числа {number} = ");

            while (number > 0)
            {
                summ_number += number % 10;
                number = number / 10;
            }

            Console.Write($" {summ_number}");
            Console.ReadLine();

        }
    }
}
