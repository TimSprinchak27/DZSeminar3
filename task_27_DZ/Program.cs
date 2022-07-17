// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
namespace Task27
{
    class Program
    {
        public static void Main ()
        {
            Console.Write("Введите число: ");
            int i = int.Parse(Console.ReadLine());
            int sum = 0;
            while (i > 0)
            {
                sum = sum + i %10;
                i = i / 10;
            }
            Console.WriteLine(sum);


        }
    }

}
