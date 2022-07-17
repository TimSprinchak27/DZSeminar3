// Напишите цикл, который принимает на вход два числа (А, В) и возводит число А в натуральную степень В.

namespace Task25
{
    class Program
    {
        public static void Main ()
        {
            Console.Write("Введите число А: ");
            double A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int stepen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(+ Math.Pow(A, stepen ));


            

            // for (int i = 1; i <= B; i++)
            
            // {
            //     result = result * B;
            // }
            // Console.WriteLine(result);
           


        }

    }

}