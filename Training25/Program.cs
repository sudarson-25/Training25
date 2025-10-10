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
         (char[] inputArray, string input) = GetValidatedInput<(char[], string)> ("Enter the" +
            " letters: ", input => !string.IsNullOrWhiteSpace (input) && input.All (char.IsLetter),
            input => ([.. input.ToLower ()], input)); // Multiple return values using tuple
         char specialCharacter = GetValidatedInput<char> ("Enter the special character: ",
            input => char.TryParse (input, out char specialChar) && char.IsLetter (specialChar),
            input => char.ToLower (char.Parse (input)));
         string order = GetValidatedInput<string> ("Type 'A' for ascending order or 'D' for" +
            " descending order: ", input => char.TryParse (input, out char specialChar) &&
            char.IsLetter (specialChar), input => char.Parse (input) is 'A' or 'a' ? "ascending" :
            "descending");
         SortAndSwap (inputArray, specialCharacter, order);
         WriteLine ($"Letters: {input}\nSorted : {string.Join (", ", inputArray)}" +
            "\nPress 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   //Prints the prompt message and returns the validated input from the user
   static T GetValidatedInput<T> (string prompt, Func<string, bool> IsValid, Func<string, T>
      Convert) {
      while (true) {
         Write (prompt);
         var input = ReadLine ();
         if (input == null || !IsValid (input)) { PrintError (); continue; }
         return Convert (input);
      }
   }

   //Prints an error message
   static void PrintError () => WriteLine ("Invalid input!");

   // Sorts the given array by keeping the elements matching the given character to the last of the
   // array based on the given order
   static void SortAndSwap (char[] inputArray, char specialChar, string order) {
      var inputList = inputArray.ToList ();
      int count = inputList.RemoveAll (ch => ch == specialChar);
      inputList.Sort ();
      if (order is "descending") inputList.Reverse ();
      for (int i = 0; i < count; i++) inputList.Add (specialChar);
      for (int i = 0; i < inputArray.Length; i++) inputArray[i] = inputList[i];
   }
}