// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print Pascal's triangle.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Write ("\nPascal's Triangle\n~~~~~~~~~~~~~~~~~\nEnter number of rows (1 to 34): ");
         if (int.TryParse (ReadLine (), out int rows) && rows > 0 && rows <= 34) {
            List<int[]> values = PascalValues (rows);
            for (int row = 0; row < rows; row++) {
               Write ("".PadLeft (rows - row));
               for (int col = 0; col < row + 1; col++) Write (values[row][col] + " ");
               WriteLine ();
            }
         } else WriteLine ("Invalid input!");
         Write ("\nPress 'y' to continue: ");
      } while (ReadLine () is "y" or "Y");
   }

   // Returns a list of integer arrays containing the values of Pascal's triangle.
   static List<int[]> PascalValues (int rows) {
      List<int[]> values = [];
      for (int row = 0; row < rows; row++) {
         int[] rowEntries = new int[row + 1];
         for (int col = 0; col <= row; col++)
            rowEntries[col] = col == 0 || col == row ? 1 : values[row - 1][col - 1] +
               values[row - 1][col];
         values.Add (rowEntries);
      }
      return values;
   }
}