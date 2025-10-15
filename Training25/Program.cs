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
         GetValidChar ("Enter the special character: ", char.ToLower, out char specialCharacter);
         GetValidChar ("\nType 'A' for ascending order or 'D' for" +
            " descending order: ", input => input is 'A' or 'a' ? "ascending" :
            "descending", out string order);
         var output = SortAndSwap ([.. input], specialCharacter, order);
         WriteLine ($"\nLetters: {input}\nSorted : {string.Join (", ", output)}\nPress 'Y' to" +
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
   static void GetValidChar<T> (string prompt, Func<char, T> Convert, out T value) {
      while (true) {
         Write (prompt);
         var input = ReadKey ().KeyChar;
         if (!char.IsLetter (input)) { PrintError (); continue; }
         value = Convert (input);
         break;
      }
   }

   //Prints an error message
   static void PrintError () => WriteLine ("Invalid input!");

   // Sorts the given list by keeping the elements matching the given character to the last of the
   // list based on the given order
   static List<char> SortAndSwap (List<char> inputList, char specialChar, string order) {
      int count = inputList.RemoveAll (ch => ch == specialChar);
      inputList = order is "descending" ? [.. inputList.OrderDescending ()] :
         [.. inputList.Order ()];
      for (int i = 0; i < count; i++) inputList.Add (specialChar);
      return inputList;
   }
}