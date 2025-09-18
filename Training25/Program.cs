// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// program to convert a given decimal number to different forms (Hexadecimal, Binary)
// ------------------------------------------------------------------------------------------------
namespace Training25;
internal class Program {
   static void Main (string[] args) {
      do {
         Console.Write ("\nNumber Conversion Game\n~~~~~~~~~~~~~~~~~~~~~~\nInput: ");
         Console.WriteLine (int.TryParse (Console.ReadLine (), out int decValue)
            ? $"HEX: {decValue:X}\nBinary: {Convert.ToString (decValue, 2)}"
            : "Invalid Input");
         Console.Write ("Press 'Y' to continue: ");
      } while (Console.ReadLine () is "Y" or "y");
   }
}