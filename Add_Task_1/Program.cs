using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Задача 1. На вход подаётся натуральное десятичное число.
// Проверьте, является ли оно палиндромом в двоичной записи.
namespace Add_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; // 27 - polindrom
            string new_number = null;
            Boolean flag = true;
            int length_binary;

            Console.Write("введите число: ");
            number = int.Parse(Console.ReadLine());

            Trans_to_binary(number);
             
            check_polinom(new_number);

            Console.ReadLine();

            string Trans_to_binary (int number10)
            { 
                
                while (number10 >= 2)
                {
                    new_number = number10 % 2 + new_number;
                    number10 = number10 / 2;
                }
                new_number = number10 + new_number;
                length_binary = new_number.Length;
                return new_number;

            }

            void check_polinom (string binary)
            {
                for (int i = 0; i < length_binary / 2; i++)
                {
                    if (new_number[i] != new_number[length_binary - 1 - i])
                    {
                        flag = false;
                        Console.WriteLine($"{new_number} НЕ является полиномом");
                        break;
                    }
                }
                if (flag == true) Console.WriteLine($"{new_number} является полиномом");
            }
            
        }
    }
}
