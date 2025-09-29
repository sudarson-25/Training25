// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print multiplication tables from 1 to 10 in a tabular form
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main () {
      Console.WriteLine ("Multiplication Tables\n~~~~~~~~~~~~~~~~~~~~~\n");
      int start = 1, end = 10;
      for (int multiplier = start; multiplier <= end; multiplier++) {
         for (int multiplicand = start; multiplicand <= end; multiplicand++)
            Console.WriteLine ($"{multiplier} * {multiplicand,2} = {multiplier * multiplicand}");
         Console.WriteLine ();
      }
   }
}