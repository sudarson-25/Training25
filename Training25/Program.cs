// ------------------------------------------------------------------------------------------------
// Training ~ A training program for new joinees at Metamation, Batch - July 2025.
// Copyright (c) Metamation India.
// ------------------------------------------------------------------
// Program.cs
// Program to implement a custom MyList<T> class using arrays as the underlying data structure
// ------------------------------------------------------------------------------------------------
using static System.Console;

namespace Training25;
internal class Program {
   static void Main () {
      MyList<int> list1 = new ();
      for (int i = 10; i <= 100; i += 10) list1.Add (i);
      list1.Print ();
      WriteLine (list1.Remove (50) ? "Element removed" : "Element not found");
      list1.Print ();
      WriteLine (list1[8]);
      list1.Insert (4, 9);
      list1.Print ();
      WriteLine (list1.Capacity);
      WriteLine (list1.Count);
      list1.RemoveAt (9);
      list1.Print ();
      list1.Clear ();
      list1.Print ();
   }

   #region class MyList ---------------------------------------------------------------------------
   /// <summary>This class implements a custom list using arrays as the underlying data structure.</summary>
   class MyList<T> {
      #region Constructor --------------------------------------------
      // Constructor to allocate the initial array
      public MyList () {
         mArray = new T[4];
         mCount = 0;
      }
      #endregion

      #region Properties ---------------------------------------------
      // Gets the current capacity of the underlying array
      public int Capacity => mArray.Length;

      // Gets the number of elements in the list
      public int Count => mCount;

      // Indexer to get or set elements at a specific index
      public T this[int index] {
         get {
            ValidateArgument (index);
            ValidateIndex (index);
            return mArray[index];
         }
         set {
            ValidateArgument (index);
            ValidateIndex (index);
            mArray[index] = value;
         }
      }
      #endregion

      #region Methods ------------------------------------------------
      // Adds the given element to the end of the list
      public void Add (T element) {
         ResizeArray ();
         mArray[mCount++] = element;
      }

      // Clears the list
      public void Clear () {
         if (mCount == 0) return;
         Array.Clear (mArray);
         mCount = 0;
      }

      // Inserts the given element at the specified index
      public void Insert (int index, T a) {
         ValidateArgument (index);
         if (index > mCount) throw new IndexOutOfRangeException ();
         ResizeArray ();
         for (int i = mCount; i > index; i--) mArray[i] = mArray[i - 1];
         mArray[index] = a;
         mCount++;
      }

      // Displays the elements of the list
      public void Print () {
         for (int i = 0; i < mCount; i++) Write (this[i] + " ");
         WriteLine ();
      }

      // Removes the first occurrence of the given element from the list
      public bool Remove (T element) {
         int index = Array.IndexOf (mArray, element);
         if (index is -1) return false;
         RemoveAt (index);
         return true;
      }

      // Removes the element at the specified index
      public void RemoveAt (int index) {
         ValidateArgument (index);
         ValidateIndex (index);
         for (int i = index; i < mCount - 1; i++) mArray[i] = mArray[i + 1];
         mCount--;
      }
      #endregion

      #region Implementation -----------------------------------------
      // Resizes the underlying array when capacity is reached
      void ResizeArray () {
         if (mCount == Capacity) Array.Resize (ref mArray, Capacity * 2);
      }

      // Validates that the index is non-negative
      void ValidateArgument (int index) => ArgumentOutOfRangeException.ThrowIfNegative (index);

      // Validates that the index is within the current count
      void ValidateIndex (int index) {
         if (index >= mCount) throw new IndexOutOfRangeException ();
      }
      #endregion

      #region Private data -------------------------------------------
      T[] mArray;
      int mCount;
      #endregion
   }
   #endregion
}