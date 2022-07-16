//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53   //D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2) формула

namespace Task
{
    class Task21
    {
         static void Main (string[] args ) 

        {

            //Console.WriteLine("Введите пятизначное число: ");
            //string? number = Console.ReadLine();
            int x1 = Coordinate("x", "A");
            int y1 = Coordinate("y", "A");
            int z1 = Coordinate("z", "A"); // Ввод данных
            int x2 = Coordinate("x", "B");
            int y2 = Coordinate("y", "B");
            int z2 = Coordinate("z", "B");

            int Coordinate(string coorName, string pointName)
            {
            Console.Write($"Введите координату {coorName} точки {pointName}: ");    // Ввод в консоли 
            return Convert.ToInt16(Console.ReadLine());
            }

                double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
                return Math.Sqrt(Math.Pow((x2-x1), 2) +             //применение фомулы
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
            } 

            double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

            Console.WriteLine($"Длина отрезка  {segmentLength}");   
        
              

            }
        }
    
}
