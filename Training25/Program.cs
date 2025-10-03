// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check whether the password is strong or not with reasons.
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Console.WriteLine ("\nStrong Password\n~~~~~~~~~~~~~~~");
         string? password;
         do {
            Console.Write ("Enter a password: ");
            password = Console.ReadLine ();
            if (string.IsNullOrWhiteSpace (password)) Console.WriteLine ("Invalid Input!\n");
         } while (string.IsNullOrWhiteSpace (password));
         int passwordLength = password.Length;
         bool hasDigit = password.Any (char.IsDigit), hasLower = password.Any (char.IsLower),
            hasUpper = password.Any (char.IsUpper), hasSpecialChar =
            password.Any (sSpecialCharacters.Contains);
         if (passwordLength < 6)
            Console.WriteLine ("Must be atleast 6 characters in length");
         if (!hasDigit)
            Console.WriteLine ("Must conatin atleast one digit");
         if (!hasLower)
            Console.WriteLine ("Must conatin atleast one lowercase English character");
         if (!hasUpper)
            Console.WriteLine ("Must conatin atleast one uppercase English character");
         if (!hasSpecialChar)
            Console.WriteLine ("Must conatin atleast one special character");
         Console.WriteLine (passwordLength >= 6 && hasDigit && hasLower && hasUpper &&
            hasSpecialChar ? "Strong Password!" : "Weak Password!");
         Console.Write ("\nPress 'Y' to continue: ");
      } while (Console.ReadLine () is "y" or "Y");
   }

   static string sSpecialCharacters = "!@#$%^&*()-+";
}