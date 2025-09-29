// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to convert a given decimal number to different forms (Hexadecimal, Binary)
// ------------------------------------------------------------------------------------------------
using System.Text;
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Write ("\nNumber Conversion Game\n~~~~~~~~~~~~~~~~~~~~~~\nInput : ");
         if (int.TryParse (ReadLine (), out int decValue)) {
            string bin = decValue.ToString ("B"), hex = decValue.ToString ("X");
            WriteLine ($"HEX   : {hex}\nBinary: {bin}");
            WriteLine (DecToBin (decValue) == bin ? "DecToBin () method works!"
               : "DecToBin() method fails!");
            WriteLine (DecToHex (decValue) == hex ? "DecToHex () method works!"
               : "DecToHex() method fails!");
         } else WriteLine ("Invalid Input!");
         Write ("Press 'Y' to continue: ");
      } while (ReadLine () is "Y" or "y");
   }

   // Returns the binary value of the given decimal number
   static string DecToBin (int decValue) {
      if (decValue == 0) return "0";
      var sb = new StringBuilder (32);
      for (int i = 31; i >= 0; i--)
         sb.Append (((decValue & (1 << i)) != 0) ? '1' : '0');
      return TrimLeadingZeros (sb, 32);
   }

   // Returns the hexadecimal value of the given decimal number
   static string DecToHex (int decValue) {
      if (decValue == 0) return "0";
      var sb = new StringBuilder ("00000000");
      for (int i = 7; i >= 0; i--)
         sb[7 - i] = sHex[(decValue >> (i * 4)) & 0xF];
      return TrimLeadingZeros (sb, 8);
   }

   // Returns a string after trimming leading zeros
   static string TrimLeadingZeros (StringBuilder sb, int size) {
      int idx = 0;
      while (sb[idx] == '0') idx++;
      return sb.ToString (idx, size - idx);
   }

   static string sHex = "0123456789ABCDEF";
}