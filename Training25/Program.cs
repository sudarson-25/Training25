// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Even-Odd Digit Sorter.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      int num;
      while (true) {
         Write ("Enter an Integer: ");
         if (int.TryParse (ReadLine (), out num)) break;
         WriteLine ("Invalid Input");
      }
      var sorted = Sorter (num);
      foreach (int digit in sorted) Write (digit);
   }

   static List<int> Sorter (int num) {
      List<int> digits = [];
      while (num > 0) {
         digits.Add (num % 10);
         num /= 10;
      }
      List<int> evenDigits = [.. digits.Where (d => d % 2 == 0)],
         oddDigits = [.. digits.Where (d => d % 2 != 0)];
      evenDigits.Sort ();
      oddDigits.Sort ();
      foreach (int digit in oddDigits) evenDigits.Add (digit);
      int len = evenDigits.Count;
      return evenDigits;
   }
}