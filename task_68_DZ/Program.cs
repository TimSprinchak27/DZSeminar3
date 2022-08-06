namespace Task68
{
    public class Program
    // Напишите программу вычисления функции Аккермана с помощью рекурсии.
    // Даны два неотрицательных числа m и n.
    // m = 2, n = 3 -> A(m,n) = 29

    {
        static void Main(string[] args)
        {
            int m = 2, n = 3;
            static int A(int n, int m)
            {
                if (n == 0)
                    return m + 1;
                else
                  if ((n != 0) && (m == 0))
                    return A(n - 1, 1);
                else
                    return A(n - 1, A(n, m - 1));
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Результат вычисления финкции Аккермана для заданных знечений = {A(n, m)}" + "\n");

        }

    }
}
