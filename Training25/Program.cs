// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Excel column name generator
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      int colNum;
      while (true) {
         Write ("Enter a column number: ");
         if (int.TryParse (ReadLine (), out colNum) && colNum > 0 && colNum <= 16384) break;
         WriteLine ("Invalid input");
      }
      WriteLine ("Column name: " + GetColumnName (colNum));
   }

   static string GetColumnName (int colNum) {
      string colName = "";
      while (colNum > 0) {
         colNum--;
         int rem = colNum % 26;
         colName = (char)('A' + rem) + colName;
         colNum /= 26;
      }
      return colName;
   }
}