using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задача 3. Массив на 100 элементов задаётся случайными числами от 1 до 99.
// Определите самый часто встречающийся элемент в массиве.
// Если таких элементов несколько, вывести их все.


namespace Add_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array = new int[100];
            int [] repeat_array = new int[100];
            int ind_max = 0;

            FillArray(array);
            PrintArray(array);
            Fill_RArr(array);
                        
            for (int i = 0; i < repeat_array.Length; i++)
            {
                if (repeat_array[i] == repeat_array[ind_max]) 
                    Console.WriteLine($"число {i} встречается {repeat_array[ind_max]} раз/раза");
            }

            Console.ReadLine();


            void FillArray(int[] arr)
            {
                Random random = new Random();

                for (int i = 0; i < arr.Length; i++)
                    arr[i] = random.Next(1,100);
            }

            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                    Console.Write($"{arr[i]}-");
                Console.WriteLine();
            }

            void Fill_RArr(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    repeat_array[arr[i]]++;
                    if (repeat_array[ind_max] < repeat_array[arr[i]]) 
                        ind_max = arr[i];
                }
            }
           
        }
    }
}
