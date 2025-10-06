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
         Write ("Armstrong Number\n~~~~~~~~~~~~~~~~\nEnter a number: ");
         if (int.TryParse (ReadLine (), out int num) && num >= 0) {
            int numCopy = num, power = num.ToString ().Length;
            double armstrong = 0;
            while (numCopy > 0)
               (armstrong, numCopy) = (armstrong + Math.Pow (numCopy % 10, power), numCopy / 10);
            WriteLine (armstrong == num ? "Armstrong Number!" : "Not an Armstrong number ");
         } else WriteLine ("Invalid input!");
         WriteLine ("Press 'Y' to continue");
      } while (ReadKey (true).Key is ConsoleKey.Y);
   }
}