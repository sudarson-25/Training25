// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to find the digital root of a given number.
// ------------------------------------------------------------------------------------------------
using static System.Console;
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Write ("\nDigital Root\n~~~~~~~~~~~~\nEnter a number: ");
         if (int.TryParse (ReadLine (), out int num) && num > 0)
            WriteLine ($"Digital Root : {(num == 0 ? 0 : 1 + ((num - 1) % 9))}");
         else WriteLine ("Invalid input!");
         Write ("Press 'Y' to continue: ");
      } while (ReadLine () is "y" or "Y");
   }
}