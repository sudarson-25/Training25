// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to reduce a string of lowercase characters by deleting a pair of adjacent letters that
// match.
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Console.WriteLine ("\nReduced String\n~~~~~~~~~~~~~~");
         string? input;
         do {
            Console.Write ("Enter a lowercase string: ");
            input = Console.ReadLine ();
            if (string.IsNullOrWhiteSpace (input)) Console.WriteLine ("Invalid input!");
         } while (string.IsNullOrWhiteSpace (input));
         if (input.All (char.IsLower)) {
            Stack<char> stack = new ();
            foreach (char letter in input)
               if (stack.Count > 0 && stack.Peek () == letter) stack.Pop ();
               else stack.Push (letter);
            string reducedString = new ([.. stack.Reverse ()]);
            Console.WriteLine ("Reduced String          : " + reducedString);
         } else Console.WriteLine ("String must contain only lowercase characters");
         Console.Write ("Press 'Y' to continue   : ");
      } while (Console.ReadLine () is "y" or "Y");
   }
}