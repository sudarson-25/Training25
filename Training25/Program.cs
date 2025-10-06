// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program that takes a string and returns the reversed string.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         WriteLine ("Reverse the String\n~~~~~~~~~~~~~~~~~~");
         string? input;
         do {
            Write ("Enter a string : ");
            input = ReadLine ();
            if (string.IsNullOrWhiteSpace (input)) WriteLine ("Invalid input!");
         } while (string.IsNullOrWhiteSpace (input));
         List<char> rev = [.. input.Replace (" ", "").Reverse ()];
         int inputLen = input.Length;
         for (int i = 0; i < inputLen; i++) {
            char ch = input[i];
            if (ch == ' ') rev.Insert (i, ' ');
            if (char.IsLower (ch)) rev[i] = char.ToLower (rev[i]);
            if (char.IsUpper (ch)) rev[i] = char.ToUpper (rev[i]);
         }
         WriteLine ($"Reversed string: {new ([.. rev])}\nPress 'Y' to continue");
      } while (ReadKey (true).Key is ConsoleKey.Y);
   }
}