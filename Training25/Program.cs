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
         WriteLine ("Sort and Swap Special Characters\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
         string input = GetValidString ("Enter the letters: ");
         char specialCharacter = GetValidChar<char> ("Enter the special character: ",
            input => char.ToLower (char.Parse (input)));
         string order = GetValidChar<string> ("Type 'A' for ascending order or 'D' for" +
            " descending order: ", input => char.Parse (input) is 'A' or 'a' ? "ascending" :
            "descending");
         var output = SortAndSwap (input.ToCharArray (), specialCharacter, order);
         WriteLine ($"Letters: {input}\nSorted : {string.Join (", ", output)}\nPress 'Y' to" +
            " continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   //Prints the prompt message and returns the validated input from the user
   static string GetValidString (string prompt) {
      while (true) {
         Write (prompt);
         var input = ReadLine ();
         if (input == null || string.IsNullOrWhiteSpace (input) || !input.All (char.IsLetter)) {
            PrintError ();
            continue;
         }
         return input.ToLower ();
      }
   }

   //Prints the prompt message and returns the validated input from the user
   static T GetValidChar<T> (string prompt, Func<string, T> Convert) {
      while (true) {
         Write (prompt);
         var input = ReadLine ();
         if (input == null || !char.TryParse (input, out char specialChar) ||
            !char.IsLetter (specialChar)) { PrintError (); continue; }
         return Convert (input);
      }
   }

   //Prints an error message
   static void PrintError () => WriteLine ("Invalid input!");

   // Sorts the given array by keeping the elements matching the given character to the last of the
   // array based on the given order
   static List<char> SortAndSwap (char[] inputArray, char specialChar, string order) {
      var inputList = inputArray.ToList ();
      int count = inputList.RemoveAll (ch => ch == specialChar);
      inputList = [.. inputList.Order ()];
      if (order is "descending") inputList = [.. inputList.OrderDescending ()];
      for (int i = 0; i < count; i++) inputList.Add (specialChar);
      return inputList;
   }
}