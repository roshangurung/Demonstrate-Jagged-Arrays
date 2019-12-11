using System;

namespace Demonstrate_Jagged_Arrays
{
    class Program//////This C# Program is used to Demonstrate Jagged Arrays. The elements of a jagged array can be of different dimensions and sizes. A jagged array is sometimes called an “array of arrays.” Create a new array in the jagged array, and assign its coefficient values, and form second row and third row by using array initialize.///
    {
        static void Main(string[] args)
        {
            int[][] jag = new int[3][];
            jag[0] = new int[2];
            jag[0][0] = 11;
            jag[0][1] = 12;
            jag[1] = new int[1] { 11 };
            jag[2] = new int[3] { 14, 15, 16 };
            for (int i = 0; i < jag.Length; i++)
            {
                int[] innerArray = jag[i];///Here Jagged Arrays can store efficiently many rows of varying lengths. Any type of data, reference or value, can be used. For loop is used to print the jagged array element values///
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.WriteLine(innerArray[a] + " ");
                }
            }
            Console.Read();
        }
    }
}
///Output: 
/// 11,12,11,14,15,16