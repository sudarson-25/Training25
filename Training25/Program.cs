// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Magic Square(3x3)
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      List<List<int>> matrix = [];
      for (int i = 0; i < 3; i++) {
         List<int> row = [];
         for (int j = 0; j < 3; j++) {
            int num;
            while (true) {
               Write ($"Enter element ({i},{j}): ");
               if (int.TryParse (ReadLine (), out num)) break;
               WriteLine ("Invalid Input");
            }
            row.Add (num);
         }
         matrix.Add (row);
      }
      WriteLine (IsMagicSquare (matrix) ? "Magic Square!" : "Not a magic square!");
   }

   static bool IsMagicSquare (List<List<int>> matrix) {
      List<int> sums = [];
      int[] colSums = [0, 0, 0];
      int leftDiag = 0, rightDiag = 0;
      for (int i = 0; i < 3; i++) {
         sums.Add (matrix[i].Sum ());
         for (int j = 0; j < 3; j++) {
            if (i == j) leftDiag += matrix[i][j];
            if (i + j == 2) rightDiag += matrix[i][j];
            colSums[i] += matrix[j][i];
         }
      }
      for (int i = 0; i < 3; i++) sums.Add (colSums[i]);
      sums.Add (leftDiag);
      sums.Add (rightDiag);
      return sums.All (a => a == sums[0]);
   }
}