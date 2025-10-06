// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check whether the password is strong or not with reasons.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         WriteLine ("\nStrong Password\n~~~~~~~~~~~~~~~");
         string? password;
         do {
            Write ("Enter a password: ");
            password = ReadLine ();
            if (string.IsNullOrWhiteSpace (password)) WriteLine ("Invalid Input!\n");
         } while (string.IsNullOrWhiteSpace (password));
         int passwordLength = password.Length;
         bool hasDigit = password.Any (char.IsDigit), hasLower = password.Any (char.IsLower),
            hasUpper = password.Any (char.IsUpper), hasSpecialChar =
            password.Any (sSpecialCharacters.Contains);
         if (passwordLength < 6)
            WriteLine ("Must be atleast 6 characters in length");
         if (!hasDigit)
            WriteLine ("Must conatin atleast one digit");
         if (!hasLower)
            WriteLine ("Must conatin atleast one lowercase English character");
         if (!hasUpper)
            WriteLine ("Must conatin atleast one uppercase English character");
         if (!hasSpecialChar)
            WriteLine ("Must conatin atleast one special character");
         WriteLine (passwordLength >= 6 && hasDigit && hasLower && hasUpper &&
            hasSpecialChar ? "Strong Password!" : "Weak Password!");
         Write ("\nPress 'Y' to continue: ");
      } while (ReadLine () is "y" or "Y");
   }

   static string sSpecialCharacters = "!@#$%^&*()-+";
}