// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program on main branch.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Voting Contest\n~~~~~~~~~~~~~~\nEnter a string: ");
         var S = ReadLine ();
         if (string.IsNullOrWhiteSpace (S)) { WriteLine ("Invalid input!"); continue; }
         if (!S.All (char.IsLetter)) { WriteLine ("Invalid input!"); continue; }
         char winner = GetWinner (S);
         WriteLine ($"{char.ToUpper (winner)} or {char.ToLower (winner)}\nPress 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   // Returns the winner of the voting contest
   static char GetWinner (string S) => S.GroupBy (char.ToLower).OrderByDescending (g => g.Count ())
      .ThenBy (g => S.IndexOf (g.Key)).First ().Key;
}