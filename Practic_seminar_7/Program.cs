using System.Collections.Generic;
using System.Linq;
using System;


namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] a = new int [5] {1,2,3,4,5};
            // int [,] b = new int [5,2] {{1,2,3,4,5},{1,2,3,4,5}};
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 }; // класс использует что он будет хранить <тип данных> 
            // можно дабавить в лист любое кол-во элементов 
            list.Add(6);
            list.Add(7);
            list.Add(10);

            foreach (int number in list) // проходит по любой коллекции лучше задавать тип данных INT
            //(не нужно смотреть на размерность, не нужно задавать условия и тд он проходит от начала и до конца )
            {
                Console.WriteLine(number);

            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);

            }

        }
    }
}
