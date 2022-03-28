using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_29
{
    //Задача 29: Напишите программу,
    //которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8];
            

            Creat_Array();
            Print_Array(arr);
            Sort_Array(arr);
            Print_Array(arr);
            Console.Read();

            void Creat_Array()

            {
                Random rng = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rng.Next(-10,11);
                }
            }

            void Sort_Array(int[] array) //procedure sorted
            {
                int temp = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i+1; j < array.Length; j++)
                    {
                        if (Math.Abs(array[i]) > Math.Abs(array[j]))
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }

                    }
                }
             }

            void Print_Array(int[] array)
            {
                Console.Write($" массив: {array[0]},");
                for (int i = 1; i < array.Length; i++)
                Console.Write($"{array[i]}, ");
                Console.WriteLine();

            }

            
        }
    }
}
