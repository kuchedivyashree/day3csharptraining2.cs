using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class jagged2d
    {
        static void Main(string[] args)
        {
            int[][,] jaggedArray = new int[3][,]
            {
                new int[,] { { 1,8}, { 6,7} },
                new int[,] {{8,3}, { 5, 6 }, { 9,10} },
                new int[,] {{11,23}, { 100,88}, { 0,10} }
            };

            Console.WriteLine(jaggedArray[0][0, 1]);
            Console.WriteLine(jaggedArray[1][2, 1]);
            Console.WriteLine(jaggedArray[2][1, 0]);

            Console.ReadLine();
        }
    }
}
