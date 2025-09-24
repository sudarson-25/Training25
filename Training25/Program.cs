// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to display a given number in words and roman numerals
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training25;

internal class Program {
   static void Main (string[] args) {
      do {
         Console.Write ("\nMenu\n~~~~~\n1.Display in words\n2.Display in roman numerals (0<x<4000)" +
            "\nEnter your choice: ");
         if (int.TryParse (Console.ReadLine (), out int choice))
            switch (choice) {
               case 1:
                  Console.Write ("Enter the number : ");
                  if (int.TryParse (Console.ReadLine (), out int num)) {
                     string numInWords = NumberToWords (num);
                     Console.WriteLine ($"\n{num} - {char.ToUpper (numInWords[0]) +
                        numInWords[1..]}");
                  } else Console.WriteLine ("\nInvalid Input!");
                  break;
               case 2:
                  Console.Write ("Enter the number : ");
                  // Roman numerals are usually written for numbers from 1 to 3999
                  if (int.TryParse (Console.ReadLine (), out int num1) && num1 > 0 && num1 < 4000)
                     Console.WriteLine ($"\n{num1} - {NumberToRoman (num1)}");
                  else Console.WriteLine ("\nInvalid Input!");
                  break;
               default: Console.WriteLine ("\nInvalid choice!"); break;
            } else Console.WriteLine ("\nInvalid Input!");
         Console.Write ("Press 'Y' to continue: ");
      } while (Console.ReadLine () is "y" or "Y");
   }

   static (int, string)[] valuesMap = [(1000000000, " billion "), (1000000, " million "),
         (1000, " thousand "), (100, " hundred ")];
   static string[] unitsMap = [ "", "one", "two", "three", "four", "five", "six", "seven",
            "eight", "nine", "ten", "eleven", "twelve", "thirteen","fourteen", "fifteen", "sixteen",
         "seventeen", "eighteen", "nineteen" ], tensMap = [ "", "", "twenty", "thirty", "forty",
         "fifty", "sixty", "seventy", "eighty", "ninety" ];

   /// <summary>Returns the given integer in words</summary>
   static string NumberToWords (int num) {
      string numInWords = "";
      if (num == 0) return "Zero";
      if (num < 0) numInWords = "Minus ";
      if (num == int.MinValue)
         return numInWords += NumberToWords (int.MaxValue / 10 * 10) + "-" + NumberToWords (8);
      int absNum = Math.Abs (num);
      foreach (var (value, label) in valuesMap)
         if (absNum / value > 0) {
            numInWords += NumberToWords (absNum / value) + label;
            absNum %= value;
         }
      if (num > 0 && numInWords != "") numInWords += "and ";
      if (absNum < 20) numInWords += unitsMap[absNum];
      else {
         numInWords += tensMap[absNum / 10];
         if (absNum % 10 > 0) numInWords += "-" + unitsMap[absNum % 10];
      }
      return numInWords.TrimEnd ();
   }

   /// <summary>Returns the roman numeral of the given integer</summary>
   static string NumberToRoman (int number) {
      (int, string)[] numerals = [ (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"), (100, "C"),
         (90, "XC"), (50, "L"), (40, "XL"), (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I") ];
      var result = new StringBuilder ();
      foreach (var (value, symbol) in numerals)
         while (number >= value) {
            result.Append (symbol);
            number -= value;
         }
      return result.ToString ();
   }
}