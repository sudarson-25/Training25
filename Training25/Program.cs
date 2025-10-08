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
   static void Main (string[] args) {
      if (args.Length != 1 || !int.TryParse (args[0], out int input) || input <= 0 || input > 32) {
         WriteLine ("Invalid input!"); return;
      }
      int armstrongCount = 0, num = 0;
      while (armstrongCount < input) { if (IsArmstrong (num)) armstrongCount++; num++; }
      WriteLine ($"Nth Armstrong number : {num - 1}");
   }

   // Returns true if the number is an Armstrong number else returns false
   static bool IsArmstrong (int num) {
      int power = num.ToString ().Length, armstrong = 0;
      for (int i = num; i > 0; i /= 10) armstrong += (int)Math.Pow (i % 10, power);
      return armstrong == num;
   }
}