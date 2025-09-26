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
      do {
         Console.Write ("\nMultiplication Tables\n~~~~~~~~~~~~~~~~~~~~~\nEnter a number: ");
         if (int.TryParse (Console.ReadLine (), out int num))
            for (int i = 1; i <= 10; i++)
               Console.WriteLine ($"{num} * {i,2} = {(long)num * i}");
         else Console.WriteLine ("Invalid input!");
         Console.Write ("Press 'Y' to continue: ");
      } while (Console.ReadLine () is "y" or "Y");
   }
}