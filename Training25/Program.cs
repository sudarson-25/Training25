// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to check whether a given number is a valid Armstrong number or not
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Write ("\nArmstrong Number\n~~~~~~~~~~~~~~~~\nEnter a number: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0) {
            int numCopy = num, numCopy1 = num, power = 0;
            double arm = 0;
            while (numCopy > 0)
               (power, numCopy) = (power + 1, numCopy / 10);
            while (numCopy1 > 0)
               (arm, numCopy1) = (arm + Math.Pow (numCopy1 % 10, power), numCopy1 / 10);
            WriteLine (arm == num ? "Armstrong Number!" : "Not an Armstrong number ");
         } else WriteLine ("Invalid input!");
         Write ("Press 'Y' to continue: ");
      } while (ReadLine () is "y" or "Y");
   }
}