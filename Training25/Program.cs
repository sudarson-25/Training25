// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to reduce a string of lowercase characters by deleting a pair of adjacent letters that
// match.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Reduced String\n~~~~~~~~~~~~~~\nEnter a lowercase string: ");
         var input = ReadLine ();
         if (input is null) { WriteLine ("Invalid input!"); continue; }
         if (input == "") WriteLine ("Reduced String          : ");
         else if (input.All (char.IsLower)) {
            Stack<char> stack = new ();
            foreach (char letter in input)
               if (stack.Count > 0 && stack.Peek () == letter) stack.Pop ();
               else stack.Push (letter);
            WriteLine ($"Reduced String          : {new ([.. stack.Reverse ()])}");
         } else WriteLine ("String must contain only lowercase characters");
         WriteLine ("Press 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }
}