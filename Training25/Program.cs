// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to calculate the GCD and LCM and display the result
// ------------------------------------------------------------------------------------------------
namespace Training25;

internal class Program {
   static void Main () {
      do {
         Console.Write ("\nLCM and GCD Generator\n~~~~~~~~~~~~~~~~~~~~~\n" +
            "Enter the first number : ");
         if (int.TryParse (Console.ReadLine (), out int num)) {
            Console.Write ("Enter the second number: ");
            if (int.TryParse (Console.ReadLine (), out int num1))
               try {
                  Console.WriteLine ($"GCD                    : {GCD (num, num1)}\nLCM      " +
                  $"              : {LCM (num, num1)}");
               } catch (ArgumentOutOfRangeException ex) {
                  Console.WriteLine ($"Error: {ex.Message}");
               } catch (ArgumentException ex) {
                  Console.WriteLine ($"Error: {ex.Message}");
               }
            else Console.WriteLine ("Second number is invalid");
         } else Console.WriteLine ("First number is invalid!");
         Console.Write ("Press 'Y' to continue  : ");
      } while (Console.ReadLine () is "y" or "Y");
   }

   /// <summary>Returns the GCD of the two given integers</summary>
   static int GCD (int num, int num1) {
      if (num == int.MinValue)
         throw new ArgumentOutOfRangeException (nameof (num), "int.MinValue is not supported!");
      if (num1 == int.MinValue)
         throw new ArgumentOutOfRangeException (nameof (num1), "int.MinValue is not supported!");
      if (num == 0 && num1 == 0)
         throw new ArgumentException ("Both the inputs can't be zero", $"{nameof (num)}, {nameof (num1)}");
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

   /// <summary>Returns the LCM of the two given integers</summary>
   static long LCM (int num, int num1) => (long)Math.Abs (num) * Math.Abs (num1) / GCD (num, num1);
}