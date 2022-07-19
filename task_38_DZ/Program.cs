//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76



namespace Task38
{
    class Program
    {
        public static void Main ()
        {
            Console.WriteLine("Задайте массив");
           int size = Convert.ToInt32(Console.ReadLine());
           double[] numbers = new double[size];
           FillArrayRandomNumbers(numbers);
           Console.WriteLine();
           Console.WriteLine("Вот наш массив: ");
           PrintArray(numbers);
           double min = Int32.MaxValue;
           double max = Int32.MinValue;
           
           for (int i = 0; i < numbers.Length; i++)
           {
             if (numbers [i] > max)
             {
                max = numbers [i];
             }
             if (numbers [i] < min)
             {
                min = numbers [i];
             }
           }
           Console.WriteLine($" Максимальное значение = {max }; Минимальное значение = {min} ");
           Console.WriteLine($" Разница = {max - min } ");
           

        }
        static void FillArrayRandomNumbers(double[] numbers)
        {

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToDouble(new Random().Next(1,100));
            }
        }
        static void PrintArray(double[] numbers)
        {
        
            Console.Write("[ ");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] +  " ");

            }
            Console.Write("]");
            Console.WriteLine();

        }
    }
}
