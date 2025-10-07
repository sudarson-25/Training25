// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check whether the password is strong or not with some criteria.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Strong Password\n~~~~~~~~~~~~~~~\nEnter a password: ");
         var password = ReadLine ();
         if (string.IsNullOrWhiteSpace (password)) { WriteLine ("Invalid Input!\n"); continue; }
         bool iWeak = false;
         if (password.Length < 6) iWeak = PrintError ("Must be atleast 6 characters in length");
         if (!password.Any (char.IsDigit)) iWeak = PrintError ("Must contain atleast one digit");
         if (!password.Any (char.IsLower)) iWeak = PrintError ("Must contain atleast one " +
            "lowercase English character");
         if (!password.Any (char.IsUpper)) iWeak = PrintError ("Must contain atleast one " +
            "uppercase English character");
         if (password.All (char.IsLetterOrDigit)) iWeak = PrintError ("Must contain " +
            "atleast one special character");
         WriteLine (iWeak ? "Weak Password!" : "Strong Password!");
         WriteLine ("Press 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }

      // Prints the specified error message and returns true
      static bool PrintError (string msg) {
         WriteLine (msg);
         return true;
      }
   }
}