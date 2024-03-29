﻿// Задайте одномерный массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

namespace Task34
{
    class Program
    {
        public static void Main ()
        {
           Console.WriteLine("Задайте размер массива");
           int size = Convert.ToInt32(Console.ReadLine());
           int[] numbers = new int[size];
           FillArrayRandomNumbers(numbers);
           Console.WriteLine("Вот наш массив: ");
           PrintArray(numbers);
           int count = 0;

           for (int i = 0; i < numbers.Length; i++)
           if (numbers[i] % 2 == 0)
           count++;
           Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
            
        }
        static void FillArrayRandomNumbers(int[] numbers)
        {

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(100,1000);
            }
        }
        static void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");

            }
            Console.Write("]");
        }   

    }
        
}
