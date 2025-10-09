// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to determine the winner of a voting contest based on character frequency and order.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Voting Contest\n~~~~~~~~~~~~~~\nEnter a string: ");
         var input = ReadLine ();
         if (string.IsNullOrWhiteSpace (input) || !input.All (char.IsLetter)) {
            WriteLine ("Invalid input!"); continue;
         }
         var (winner, max) = GetWinner (input);
         WriteLine ($"{char.ToUpper (winner)}, {max}\nPress 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   // Returns the winner of the voting contest and the number of votes
   static (char, int) GetWinner (string input) {
      input = input.ToLower ();
      int max = 0;
      char winner = '\0';
      foreach (char contestant in input) {
         int count = input.Count (ch => ch == contestant);
         if (count > max) (winner, max) = (contestant, count);
      }
      return (winner, max);
   }
}