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
         if (!int.TryParse (ReadLine (), out int num) || num < 0) {
            WriteLine ("Invalid Input!"); continue;
         }
         WriteLine ($"{GetSmallestTransform (num, out string result)} steps\nTransformed number:" +
            $" {result}\nPress 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   // Returns the smallest transform steps
   static int GetSmallestTransform (int num, out string result) {
      List<int> digits = [.. num.ToString ().Select (a => a - '0').Order ()];
      int count = digits.Count, median = digits[count / 2];
      result = new ((char)('0' + median), count);
      return digits.Sum (digit => Abs (digit - median));
   }
}