using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
namespace Tasck_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //основание
            int b = 0; // степень
            int degree = 1;

            Console.Write("введите основание: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("введите степень: ");
            b = int.Parse(Console.ReadLine());
            
            Calc_Degree(a, b);

            Console.Write($"{a} в степени {b} = {degree}");
            Console.ReadLine();

            int Calc_Degree (int x, int y) //рекурсия
            {
                if ( y > 0)
                {
                    degree = Calc_Degree (x, y - 1) * x;
                }
                return degree;
            }

        }
    }
}
