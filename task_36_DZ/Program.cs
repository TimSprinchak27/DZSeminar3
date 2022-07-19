// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
namespace Task36
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
           int sum = 0;
        

           for (int i = 0; i < numbers.Length; i+=2) if (numbers [i] > 0 ) // чтобы программа не считала отричательные значения 
          
           sum = sum + numbers[i];

           Console.WriteLine($" Cумма элементов на нечетных позтциях = {sum}");
            

        }
        static void FillArrayRandomNumbers(int[] numbers)
        {

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Random().Next(-100,100);
            }
        }
        static void PrintArray(int[] numbers)
        {
            Console.Write("[ ");
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] +  " ");

            }
            Console.Write("]");

        }
    }
}
