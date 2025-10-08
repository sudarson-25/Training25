// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print the sorted array by keeping the elements matching special character to the last
// of the array.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Sort and Swap Special Characters\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter the" +
            " letters: ");
         char[] inputArray;
         string? input;
         while (true) {
            input = ReadLine ();
            if (string.IsNullOrWhiteSpace (input)) { PrintError (); continue; }
            if (!input.All (char.IsLetter)) { PrintError (); continue; }
            inputArray = [.. input.ToLower ()];
            break;
         }
         char specialChar;
         Write ("Enter the special character: ");
         while (true) {
            if (!char.TryParse (ReadLine (), out specialChar) || !char.IsLetter (specialChar)) {
               PrintError (); continue;
            }
            specialChar = char.ToLower (specialChar);
            break;
         }
         string order;
         Write ("Type 'A' for ascending order or 'D' for descending order: ");
         while (true) {
            if (!char.TryParse (ReadLine (), out char inputOrder) || inputOrder is not ('A' or 'a'
               or 'd' or 'D')) { PrintError (); continue; }
            order = inputOrder is 'A' or 'a' ? "ascending" : "descending";
            break;
         }
         SortAndSwap (inputArray, specialChar, order);
         WriteLine ($"Letters: {input}\nSorted: {string.Join (", ", inputArray)}\nPress 'Y' to " +
            "continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   //Prints an error message
   static void PrintError () => WriteLine ("Invalid input!");

   // Sorts the given array by keeping the elements matching the given character to the last of the
   // array based on the given order
   static void SortAndSwap (char[] inputArray, char specialChar, string order = "ascending") {
      var inputList = inputArray.ToList ();
      int count = inputList.RemoveAll (ch => ch == specialChar);
      inputList.Sort ();
      if (order is "descending") inputList.Reverse ();
      for (int i = 0; i < count; i++) inputList.Add (specialChar);
      for (int i = 0; i < inputArray.Length; i++) inputArray[i] = inputList[i];
   }
}