// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to calculate the GCD and LCM and display the result
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Console.Write ("\nLCM and GCD Generator\n~~~~~~~~~~~~~~~~~~~~~\nEnter the first number : ");
         if (int.TryParse (Console.ReadLine (), out int num) && num != int.MinValue) {
            Console.Write ("Enter the second number: ");
            if (int.TryParse (Console.ReadLine (), out int num1) && num1 != int.MinValue) {
               if (num == 0 && num1 == 0) Console.WriteLine ("GCD and LCM are undefined when both the inputs are 0");
               else {
                  int gcd = GCD (num, num1);
                  Console.WriteLine ($"GCD                    : {gcd}\nLCM                    : " +
                     $"{(long)Math.Abs (num) * Math.Abs (num1) / gcd}");
               }
            } else Console.WriteLine ("Second number is invalid");
         } else Console.WriteLine ("First number is invalid!");
         Console.Write ("Press 'Y' to continue  : ");
      } while (Console.ReadLine () is "y" or "Y");
   }

   ///// <summary>Returns the GCD of the two given integers</summary>
   static int GCD (int num, int num1) {
      num = Math.Abs (num);
      num1 = Math.Abs (num1);
      while (num1 != 0) {
         int temp = num1;
         num1 = num % num1;
         num = temp;
      }
      return num;
   }
}