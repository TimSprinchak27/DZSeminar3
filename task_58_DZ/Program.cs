namespace Task58
{
    public class Program
    // Задайте две матрицы.
    // Напишите программу, которая выведет матрицу произведения
    // элементов двух предыдущих матриц
    // Например, заданы 2 массива:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 5 2 6 7
    // и
    // 1 5 8 5
    // 4 9 4 2
    // 7 2 2 6
    // 2 3 4 7
    // Их произведение будет равно следующему массиву:
    // 1 20 56 10
    // 20 81 8 6
    // 56 8 4 24
    // 10 6 24 49

    {
        static void Main(string[] args)
        {
            int[,] arrayFirst = new int[4, 4];
            int[,] arraySecond = new int[4, 4];


            FillarrayFirst(arrayFirst);
            PrintArrayFirst(arrayFirst);
            Console.WriteLine();
            FillarraySecond(arraySecond);
            PrintArraySecond(arraySecond);
            Console.WriteLine();
            MultiplicationArray(arrayFirst, arraySecond);



        }

        public static void FillarrayFirst(int[,] arr)

        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            return;
        }

        public static void FillarraySecond(int[,] arr)

        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = new Random().Next(1, 10);
                }
            }
            return;
        }

        public static void PrintArrayFirst(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintArraySecond(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static void MultiplicationArray(int[,] arrayFirst, int[,] arraySecond)
        {
            var resultMultiplication = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];

            for (int i = 0; i < arrayFirst.GetLength(0); i++)
            {
                for (int j = 0; j < arraySecond.GetLength(1); j++)
                {
                    resultMultiplication[i, j] += arrayFirst[i, j] * arraySecond[i, j];
                    Console.Write($"{resultMultiplication[i, j]} ");
                }
                Console.WriteLine();
            }
            return;
        }
    }
}
