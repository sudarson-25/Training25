// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to display the chess board
// ------------------------------------------------------------------------------------------------
using System.Text;

namespace Training25;

using static System.Console;

internal class Program {
   static void Main () {
      OutputEncoding = new UnicodeEncoding ();
      string[] whitePieces = { "♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖" }, blackPieces = { "♜",
         "♞", "♝", "♛", "♚", "♝", "♞", "♜" };
      WriteLine ("┏━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┓");
      int start = 0, end = 8;
      for (int row = start; row < end; row++) {
         Write ("┃");
         for (int col = start; col < end; col++) {
            string piece = row switch {
               0 => blackPieces[col],
               1 => "♟",
               6 => "♙",
               7 => whitePieces[col],
               _ => " ",
            };
            Write ($" {piece}  ┃");
         }
         if (row < 7)
            WriteLine ("\n┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");
      }
      WriteLine ("\n┗━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┛");
   }
}