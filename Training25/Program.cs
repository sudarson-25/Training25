// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to display a given number in words and Roman numerals
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      do {
         Write ("\nEnter the choice of display\n1.Words\n2.Roman numerals (0 to 4000)\n" +
            "Enter your choice: ");
         if (int.TryParse (ReadLine (), out int choice) && choice == 1 || choice == 2) {
            Write ("Enter the number : ");
            if (int.TryParse (ReadLine (), out int num))
               switch (choice) {
                  case 1:
                     string numInWords = NumberToWords (num);
                     WriteLine ($"\n{num} - {char.ToUpper (numInWords[0]) +
                        numInWords[1..]}");
                     break;
                  case 2:
                     // Roman numerals are usually written for numbers from 1 to 3999
                     WriteLine (num > 0 && num < 4000 ? $"\n{num} - {NumberToRoman (num)}" :
                        "\nInput out of range!");
                     break;
                  default: break;
               } else WriteLine ("\nInvalid Input!");
         } else WriteLine ("\nInvalid choice!");
         Write ("Press 'Y' to continue: ");
      } while (ReadLine () is "y" or "Y");
   }

   // Returns the given integer in words
   static string NumberToWords (int num) {
      string numInWords = "";
      if (num == 0) return "Zero";
      if (num < 0) numInWords = "Minus ";
      if (num == int.MinValue)
         return numInWords += NumberToWords (int.MaxValue / 10 * 10) + "-" + NumberToWords (8);
      num = Math.Abs (num);
      foreach (var (value, label) in sValuesMap) {
         int quotient = num / value;
         if (quotient > 0) {
            numInWords += NumberToWords (quotient) + label;
            num %= value;
         }
      }
      if (num > 0 && numInWords != "" && numInWords != "Minus ")
         numInWords += "and ";
      if (num < 20) numInWords += sUnits[num];
      else {
         numInWords += sTens[num / 10];
         int digit = num % 10;
         if (digit > 0) numInWords += "-" + sUnits[digit];
      }
      return numInWords.TrimEnd ();
   }

   // Returns the roman numeral of the given integer
   static string NumberToRoman (int number) {
      string result = "";
      foreach (var (value, symbol) in sNumerals)
         while (number >= value) {
            result += symbol;
            number -= value;
         }
      return result;
   }

   static (int, string)[] sValuesMap = [(1000000000, " billion "), (1000000, " million "),
      (1000, " thousand "), (100, " hundred ")], sNumerals = [ (1000, "M"), (900, "CM"),
         (500, "D"), (400, "CD"), (100, "C"), (90, "XC"), (50, "L"), (40, "XL"), (10, "X"),
         (9, "IX"), (5, "V"), (4, "IV"), (1, "I") ];
   static string[] sUnits = [ "", "one", "two", "three", "four", "five", "six", "seven",
            "eight", "nine", "ten", "eleven", "twelve", "thirteen","fourteen", "fifteen", "sixteen"
      , "seventeen", "eighteen", "nineteen" ], sTens = [ "", "", "twenty", "thirty", "forty",
         "fifty", "sixty", "seventy", "eighty", "ninety" ];
}