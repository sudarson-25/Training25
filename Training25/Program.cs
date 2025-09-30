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
         if (int.TryParse (ReadLine (), out int num)) {
            if (Validate (num)) WriteLine ($"Digital Root  : {DigitalRoot (num)}");
         } else WriteLine ("Invalid input!");
         Write ("Press 'Y' to continue: ");
      } while (ReadLine () is "y" or "Y");
   }

   static int DigitalRoot (int num) {
      if (num == 0) return 0;
      return 1 + (num - 1) % 9;
   }

   static bool Validate (int num) {
      if (num < 0) { WriteLine ("Digital root is undefined!"); return false; }
      return true;
   }
}