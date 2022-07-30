

// Задайте двумерный массив размером mxn, заполненный случайными вещественными числами
// m=3 , n=4
namespace Task47
{
    class Program
    {
        public static void Main()
        {
            // Console.Write("Введите m: ");
            // int m = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Введите n: ");
            // int n = Convert.ToInt32(Console.ReadLine());
            // Console.Clear();
            // Console.WriteLine($"m = {m}, n = {n}.");
            double[,] array = new double[3, 4];
            CreateArrayDouble(array);
            WriteArray(array);

            Console.WriteLine( "Заполненый случайными числами массив  ");
        }

        static void CreateArrayDouble(double[,] array)
        {
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = new Random().NextDouble() * 20 - 10;
                }
            }
        }

        
        static void WriteArray(double[,] array)
        {
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double allNumber = Math.Round(array[i, j], 1);
                    Console.Write(allNumber + " ");
                    
                }
                 Console.WriteLine( );
            } 

              
        }  


    }           
}
