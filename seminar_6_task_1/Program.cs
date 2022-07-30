// Напишите программу, которая перевернет одномерный масив (последний элемент будет на первом месте, а первый на последенем)
//[1 2 3 4 5] ->[5 4 3 2 1]
// [7 6 3 6] -> [6 3 7 6]

public class ProgSeminar
{
    public int[] GetArray()
    {
        Random random = new Random();
        int x = random.Next(5, 11);
        int[] arr = new int[x];

        Console.WriteLine("Вводим массив: ");


        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(0, 41);
            Console.Write(arr[i] + " ");
        }

        return arr;
    }

    public static void Main()
    {
        ProgSeminar progSeminar = new ProgSeminar();
        int[] mass = progSeminar.GetArray();
        for (int i = 0; i < mass.Length / 2; i++)
        {
            int a = mass[i];
            mass[i] = mass[mass.Length - 1 - i];
            mass[mass.Length - 1 - i]= a;
            Console.WriteLine(" ");

        }
       
        Console.WriteLine("Выводим получившийся массив: ");

        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write(mass[i] + " ");
        }


    }
}