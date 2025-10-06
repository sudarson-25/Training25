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
      do {
         WriteLine ("\nReduced String\n~~~~~~~~~~~~~~");
         string? input;
         do {
            Write ("Enter a lowercase string: ");
            input = ReadLine ();
            if (string.IsNullOrWhiteSpace (input)) WriteLine ("Invalid input!");
         } while (string.IsNullOrWhiteSpace (input));
         if (input.All (char.IsLower)) {
            Stack<char> stack = new ();
            foreach (char letter in input)
               if (stack.Count > 0 && stack.Peek () == letter) stack.Pop ();
               else stack.Push (letter);
            string reducedString = new ([.. stack.Reverse ()]);
            WriteLine ("Reduced String          : " + reducedString);
         } else WriteLine ("String must contain only lowercase characters");
         Write ("Press 'Y' to continue   : ");
      } while (ReadLine () is "y" or "Y");
   }
}