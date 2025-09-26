// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to find the digital root of a given number.
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Console.Write ("\nDigital Root\n~~~~~~~~~~~~\nEnter a number: ");
         Console.WriteLine (int.TryParse (Console.ReadLine (), out int num) ?
            (num < 0 ? "Digital root is undifined!" : DigitalRoot (num)) : "Invalid input!");
         Console.Write ("Press 'Y' to continue: ");
      } while (Console.ReadLine () is "y" or "Y");
   }

   static int DigitalRoot (int num) {
      if (num == 0) return 0;
      return 1 + (num - 1) % 9;
   }
}