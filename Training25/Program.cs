// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to find the smallest number of changes it takes to transform a number into one with
// identical digits.
// ------------------------------------------------------------------------------------------------
using static System.Console;

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
      List<int> digits = [.. num.ToString ().Select (a => a - 48)],
         distinctDigits = [.. digits.Distinct ()];
      distinctDigits.Sort ();
      int steps1 = StepsCalculator (digits, distinctDigits[distinctDigits.Count / 2]);
      List<(int, int)> frequency = [];
      foreach (int distinctDigit in distinctDigits)
         frequency.Add ((digits.Count (digit => digit == distinctDigit), distinctDigit));
      frequency.Sort ();
      frequency.Reverse ();
      int steps2 = StepsCalculator (digits, frequency[0].Item2);
      return steps1 < steps2 ? steps1 : steps2;

      // Returns the number of steps required to convert all digits to the reference digit
      static int StepsCalculator (List<int> digits, int reference) {
         int steps = 0;
         foreach (int number in digits)
            steps += number >= reference ? number - reference : reference - number;
         return steps;
      }
   }
}