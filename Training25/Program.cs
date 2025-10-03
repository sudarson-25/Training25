// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program that takes a string and returns the reversed string.
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Console.WriteLine ("\nReverse the String\n~~~~~~~~~~~~~~~~~~");
         string? input;
         do {
            Console.Write ("Enter a string : ");
            input = Console.ReadLine ();
            if (string.IsNullOrWhiteSpace (input)) Console.WriteLine ("Invalid input!");
         } while (string.IsNullOrWhiteSpace (input));
         List<char> rev = [.. input.Replace (" ", "").Reverse ()];
         for (int i = 0; i < input.Length; i++) {
            if (input[i] == ' ') rev.Insert (i, ' ');
            if (char.IsLower (input[i])) rev[i] = char.ToLower (rev[i]);
            if (char.IsUpper (input[i])) rev[i] = char.ToUpper (rev[i]);
         }
         Console.Write ("Reversed string: " + string.Concat (rev) + "\nPress 'Y' to continue: ");
      } while (Console.ReadLine () is "y" or "Y");
   }
}