// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print multiplication tables from 1 to 10 in a tabular form
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      Console.WriteLine ("Multiplication Tables\n~~~~~~~~~~~~~~~~~~~~~\n");
      for (int i = 1; i <= 10; i++) {
         for (int j = 1; j <= 10; j++)
            Console.WriteLine ($"{i} * {j,2} = {i * j}");
         Console.WriteLine ();
      }
   }
}