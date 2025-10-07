// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to print the sorted array by keeping the elements matching S to the last of the array.
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;

internal class Program {
   static void Main () {
      while (true) {
         Write ("Sort and Swap Special Characters\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\nEnter the" +
            " size of the array: ");
         if (!int.TryParse (ReadLine (), out int num) || num <= 0) { PrintError (); continue; }
         Write ("Enter the array elements: ");
         char[] A = new char[num];
         for (int i = 0; i < num; i++) {
            if (!char.TryParse (ReadLine (), out char element) || !char.IsLetter (element)) {
               PrintError (); i--; continue;
            }
            A[i] = char.ToLower (element);
         }
         char S;
         while (true) {
            Write ("Enter a special character: ");
            if (!char.TryParse (ReadLine (), out S) || !char.IsLetter (S)) {
               PrintError (); continue;
            }
            S = char.ToLower (S);
            break;
         }
         string O;
         while (true) {
            Write ("Enter the order: ");
            var order = ReadLine ();
            if (string.IsNullOrWhiteSpace (order)) { PrintError (); continue; }
            if (!order.All (char.IsLetter)) { PrintError (); continue; }
            O = new ([.. order.Select (char.ToLower)]);
            if (O is not ("ascending" or "descending")) { PrintError (); continue; }
            break;
         }
         SortAndSwap (A, S, O);
         WriteLine ($"The modified array is: {string.Join (", ", A)}\nPress 'Y' to continue");
         if (ReadKey (true).Key is not ConsoleKey.Y) break;
      }
   }

   //Prints an error message
   static void PrintError () => WriteLine ("Invalid input!");

   // Sorts the given array by keeping the elements matching the given character to the last of the
   // array based on the given order
   static void SortAndSwap (char[] A, char S, string O = "ascending") {
      var AList = A.ToList ();
      int count = AList.RemoveAll (ch => ch == S);
      AList.Sort ();
      if (O is "descending") AList.Reverse ();
      for (int i = 0; i < count; i++) AList.Add (S);
      for (int i = 0; i < A.Length; i++) A[i] = AList[i];
   }
}