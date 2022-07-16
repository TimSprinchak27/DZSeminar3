// 2.Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

namespace Task2
{
    class Program
    {
        public static void Main ()
        {
            int[] array = new int [8];
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = new Random().Next(0, 2);
            }
            PrintArry(array, 0);

        }
        public static void PrintArry(int[] digits, int count  )
        {
            if (count ==8)
            return;
            Console.Write($"{digits[count]}");
            PrintArry(digits, count+1);

        }
    }
}