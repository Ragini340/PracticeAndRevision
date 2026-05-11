using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Pattern_Printing
{
    /*Write a C# program to print a mirror diamond star (*) pattern based on the number of rows entered by the user.

The program should:

Accept the number of rows from the user
Print the upper pyramid and lower inverted pyramid
Use separate methods for:
Reading input
Printing spaces
Printing stars
Printing the upper half
Printing the lower half
  
    *
   ***
  *****
 *******
*********
 *******
  *****
   ***
    *
    
// Time Complexity: O(n²)
// Explanation:
// The pattern contains nested loops.
// For each row, spaces and stars are printed,
// resulting in quadratic time complexity.

// Space Complexity: O(1)
// Explanation:
// No extra data structures are used.
// Only constant extra space is required.
     */
    public class MirrorDiamondPattern
    {
        // Method to read input
        public static int ReadInput()
        {
            Console.Write("Enter number of rows: ");
            return int.Parse(Console.ReadLine());
        }

        // Method to print spaces
        public static void PrintSpaces(int spaces)
        {
            for (int i = 1; i <= spaces; i++)
            {
                Console.Write(" ");
            }
        }

        // Method to print stars
        public static void PrintStars(int stars)
        {
            for (int i = 1; i <= stars; i++)
            {
                Console.Write("*");
            }
        }

        // Method to print upper pyramid
        public static void PrintUpperHalf(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                PrintSpaces(rows - i);
                PrintStars((2 * i) - 1);
                Console.WriteLine();
            }
        }

        // Method to print lower inverted pyramid
        public static void PrintLowerHalf(int rows)
        {
            for (int i = rows - 1; i >= 1; i--)
            {
                PrintSpaces(rows - i);
                PrintStars((2 * i) - 1);
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            int rows = ReadInput();

            PrintUpperHalf(rows);
            PrintLowerHalf(rows);
        }
    }
}