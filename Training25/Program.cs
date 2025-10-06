// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check whether a given number is a valid Armstrong number or not
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Armstrong Number\n~~~~~~~~~~~~~~~~\nEnter a number: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0)
            WriteLine (IsArmstrong (num) ? "Armstrong Number!" : "Not an Armstrong number ");
         else WriteLine ("Invalid input!");
         WriteLine ("Press 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   static bool IsArmstrong (int num) {
      int power = num.ToString ().Length;
      double armstrong = 0;
      for (int i = 0; i < power; i++)
         armstrong += Math.Pow (num / (int)Math.Pow (10, i) % 10, power);
      return armstrong == num;
   }
}