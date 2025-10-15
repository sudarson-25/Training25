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
         GetValidChar ("Enter the special character: ", out char specialCharacter);
         GetValidChar ("\nType 'a' for ascending order: ", out char order);
         var output = SortAndSwap ([.. input], specialCharacter, order);
         WriteLine ($"\nLetters: {input}\nSorted : {string.Join (", ", output)}\nPress 'Y' to" +
            " continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   // Prints the prompt message and returns the validated input from the user
   static void GetValidChar (string prompt, out char value) {
      while (true) {
         Write (prompt);
         value = ReadKey ().KeyChar;
         if (!char.IsLetter (value)) { PrintError (); continue; }
         value = char.ToLower (value);
         break;
      }
   }

   // Prints the prompt message and returns the validated input from the user
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

   // Prints an error message
   static void PrintError () => WriteLine ("Invalid input!");

   // Sorts the given list by keeping the elements matching the given character to the last of the
   // list based on the given order
   static List<char> SortAndSwap (List<char> inputList, char specialChar, char order) {
      int count = inputList.RemoveAll (ch => ch == specialChar);
      inputList = order is 'a' ? [.. inputList.Order ()] :
         [.. inputList.OrderDescending ()];
      for (int i = 0; i < count; i++) inputList.Add (specialChar);
      return inputList;
   }
}