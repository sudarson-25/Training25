// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to find the smallest number of changes it takes to transform a number into one with
// identical digits.
// ------------------------------------------------------------------------------------------------
using static System.Console;
using static System.Math;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Smallest Transform\n~~~~~~~~~~~~~~~~~~~~\nEnter a number: ");
         if (!int.TryParse (ReadLine (), out int num)) { WriteLine ("Invalid Input!"); continue; }
         WriteLine ($"{GetSmallestTransform (num)} steps\nPress 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   // Returns the smallest transform steps
   static int GetSmallestTransform (int num) {
      List<int> digits = [.. num.ToString ().Select (a => a - '0')],
         distinctDigits = [.. digits.Distinct ().Order ()];
      int steps1 = digits.Sum (digit => Abs (digit - distinctDigits[distinctDigits.Count / 2]));
      (int count, int digit) reference = (0, 0);
      foreach (int distinctDigit in distinctDigits) {
         int count = digits.Count (digit => digit == distinctDigit);
         if (count > reference.count) reference = (count, distinctDigit);
      }
      int steps2 = digits.Sum (digit => Abs (digit - reference.digit));
      return steps1 < steps2 ? steps1 : steps2;
   }
}