// Напишите программу, которая задает случайный массив случайного размера (от 5 до 10) элементов 
//(значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел
// 1,2,5,7,19 -->[2,4,25,49,361]

namespace Task29
{
    class Program
    {
        public static void Main ()
        {
            int[] Array = new int[5];
            
            
            // как сделать рандом массива (разный набор)?
            Random a = new Random ();
            //Random b = new Random ();
            
            

            for (int i = 1; i <= Array.Length; i++)
            {
                
                Array[i - 1] = a.Next(1,41);
                //Array[i - 1] = b.Next(5,10);
                
                
            }
            Console.WriteLine("Ответ: ");
            foreach (int f in Array)
            Console.WriteLine("{0} --> {1}", f, f*f);
            Console.WriteLine(" ");
            
            //Console.ReadLine();





            //  int[] array = new int [5];
            //  Random ran = new Random();
            
            //  for (int i = 1; i <= 5; i++)
            //  {
            //     array [i] = new Random().Next(1,39);
            //     foreach (int f in array)
            //     Console.WriteLine("{0} --> {1}", f, f*f);
            //  } 

            // PrintArry(array, 1);
        }

        // public static void PrintArry(int[] digits, int count  )
        // {
            // if (count ==5  )
            // return;
            
            // //Console.Write("{digits[count]}");
            // Console.WriteLine($"{digits[count]}");

            // PrintArry(digits, count+1);

        // }





    }
}