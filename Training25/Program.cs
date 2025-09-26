// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to display the chess board
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training25;

internal class Program {
   static void Main (string[] args) {
      Console.OutputEncoding = new UnicodeEncoding ();
      string[] whitePieces = { "♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖" }, blackPieces = { "♜", "♞",
         "♝", "♛", "♚", "♝", "♞", "♜" };
      Console.WriteLine ("┏━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┓");
      for (int row = 0; row < 8; row++) {
         Console.Write ("┃");
         for (int col = 0; col < 8; col++) {
            string piece = row switch {
               0 => blackPieces[col],
               1 => "♟",
               6 => "♙",
               7 => whitePieces[col],
               _ => " ",
            };
            Console.Write ($" {piece}  ┃");
         }
         if (row < 7)
            Console.WriteLine ("\n┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");
      }
      Console.WriteLine ("\n┗━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┛");
   }
}