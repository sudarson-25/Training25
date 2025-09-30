// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to calculate the GCD and LCM and display the result
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Write ("\nLCM and GCD Generator\n~~~~~~~~~~~~~~~~~~~~~\n" +
            "Enter the first number : ");
         if (int.TryParse (ReadLine (), out int num)) {
            Write ("Enter the second number: ");
            if (int.TryParse (ReadLine (), out int num1)) {
               if (Validate (num, num1))
                  WriteLine ($"GCD                    : {GCD (num, num1)}\nLCM                  " +
                     $"  : {LCM (num, num1)}");
            } else WriteLine ("Second number is invalid");
         } else WriteLine ("First number is invalid!");
         Write ("Press 'Y' to continue  : ");
      } while (ReadLine () is "y" or "Y");
   }

   // Returns the GCD of the two given integers
   static int GCD (int num, int num1) {
      num = Math.Abs (num); // GCD and LCM are always positive
      num1 = Math.Abs (num1);
      int temp;
      while (num1 != 0) {
         temp = num1;
         num1 = num % num1;
         num = temp;
      }
      return num;
   }

   // Returns the LCM of the two given integers
   static long LCM (int num, int num1) => (long)Math.Abs (num) * Math.Abs (num1) / GCD (num, num1);

   // Prints the error message
   static void PrintError (string msg) => WriteLine ($"Error: {msg}");

   // Validates the two input integers
   static bool Validate (int num, int num1) {
      var minFlag = num is int.MinValue || num1 is int.MinValue;
      if (minFlag) { PrintError ("int.MinValue is not supported!"); return false; }
      if (num == 0 && num1 == 0) {
         PrintError ("Both the inputs can't be zero");
         return false;
      }
      return true;
   }
}