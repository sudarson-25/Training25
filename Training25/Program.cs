// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print the nth Armstrong number (assuming base 10).
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Nth Armstrong Number\n~~~~~~~~~~~~~~~~~~~~\nEnter a number (0 to 34): ");
         if (int.TryParse (ReadLine (), out int input) && input > 0 && input < 35) {
            int armstrongCount = 0, num;
            for (num = 0; armstrongCount < input; num++)
               if (IsArmstrong (num)) armstrongCount++;
            WriteLine ($"Nth Armstrong number    : {num - 1}");
         } else WriteLine ("Invalid input!");
         WriteLine ("Press 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   // Returns true if the number is an Armstrong number else returns false
   static bool IsArmstrong (int num) {
      int power = num.ToString ().Length, armstrong = 0;
      for (int i = num; i > 0; i /= 10) armstrong += (int)Math.Pow (i % 10, power);
      return armstrong == num;
   }
}