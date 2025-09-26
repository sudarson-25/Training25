// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to convert a given decimal number to different forms (Hexadecimal, Binary)
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Console.Write ("\nNumber Conversion Game\n~~~~~~~~~~~~~~~~~~~~~~\nInput : ");
         if (int.TryParse (Console.ReadLine (), out int decValue)) {
            string bin = Convert.ToString (decValue, 2), hex = decValue.ToString ("X");
            Console.WriteLine ($"HEX   : {hex}\nBinary: {bin}");
            Console.WriteLine (DecToBin (decValue) == bin ? "DecToBin() method works!"
               : "DecToBin() method fails!");
            Console.WriteLine (DecToHex (decValue) == hex ? "DecToHex() method works!"
               : "DecToHex() method fails!");
         } else Console.WriteLine ("Invalid Input!");
         Console.Write ("Press 'Y' to continue: ");
      } while (Console.ReadLine () is "Y" or "y");
   }

   /// <summary>Returns the binary value of the given decimal number</summary>
   static string DecToBin (int decValue) {
      if (decValue == 0) return "0";
      var sb = new StringBuilder (32);
      for (int i = 31; i >= 0; i--)
         sb.Append (((decValue & (1 << i)) != 0) ? '1' : '0');
      int idx = 0;
      while (sb[idx] == '0') idx++;
      return sb.ToString (idx, 32 - idx);
   }

   /// <summary>Returns the hexadecimal value of the given decimal number</summary>
   static string DecToHex (int decValue) {
      if (decValue == 0) return "0";
      var sb = new StringBuilder ("00000000");
      for (int i = 7; i >= 0; i--)
         sb[7 - i] = sHexChars[(decValue >> (i * 4)) & 0xF];
      int idx = 0;
      while (sb[idx] == '0') idx++;
      return sb.ToString (idx, 8 - idx);
   }

   static char[] sHexChars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D',
      'E', 'F'];
}