// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to convert a given decimal number to different forms (Hexadecimal, Binary)
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) {
      do {
         Console.Write ("\nNumber Conversion Game\n~~~~~~~~~~~~~~~~~~~~~~\nInput: ");
         if (int.TryParse (Console.ReadLine (), out int decValue)) {
            var bin = Convert.ToString (decValue, 2);
            Console.WriteLine ($"HEX: {decValue:X}\nBinary: {bin}");
            Console.WriteLine (DecToBin (decValue) == bin ? "DecToBin() method works!"
               : "DecToBin() method fails!");
         } else
            Console.WriteLine ("Invalid Input!");
         Console.Write ("Press 'Y' to continue: ");
      } while (Console.ReadLine () is "Y" or "y");
   }

   static string DecToBin (int decValue) {
      if (decValue == 0) return "0";
      char[] bits = new char[32];
      for (int i = 31; i >= 0; i--)
         bits[31 - i] = ((decValue & (1 << i)) != 0) ? '1' : '0';
      return new string (bits);
   }
}