using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задача 2. Напишите метод, который заполняет массив случайным количеством (от 1 до 100) нулей и единиц.
//Размер массива должен совпадать с квадратом количества единиц в нём.
namespace Add_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int n_units = rnd.Next(1, 10); // мах кол-во единиц = 10. для 10 единиц размер массива будет равен 100
            int[] array = new int[n_units * n_units];

            Console.WriteLine($"кол-во единиц= {n_units}, длина массива = {n_units*n_units}");
            Complect_Array(n_units);
            PrintArray(array);

            Console.ReadLine();

            void Complect_Array(int number)
            {
                int temp;
                int counter = 0;

                 while (counter<number)
                {
                    temp = rnd.Next(0, (number*number));
                    if (array[temp] != 1)
                    {
                        array[temp] = 1;
                        counter++;
                       
                    }
                }

            }

            void PrintArray (int[] arr)
            {
                Console.Write($"массив: {arr[0]}");
                for (int i = 1; i < arr.Length; i++) Console.Write($", {arr[i]}");
                Console.WriteLine();
            }
        }
    }
}
