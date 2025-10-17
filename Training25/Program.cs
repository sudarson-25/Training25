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
      list1.Display ();
      WriteLine (list1.Remove (50) ? "Element removed" : "Element not found");
      list1.Display ();
      WriteLine (list1[8]);
      list1.Insert (4, 9);
      list1.Display ();
      list1.RemoveAt (9);
      list1.Display ();
      list1.Clear ();
      list1.Display ();
   }

   #region class MyList ---------------------------------------------------------------------------
   /// <summary>This class implements a custom list using arrays as the underlying data structure.
   /// </summary>
   class MyList<T> {
      // Constructor to allocate the initial array
      public MyList () {
         mArray = new T[4];
         mCount = 0;
      }

      // Gets the number of elements in the list
      public int Count => mCount;

      // Gets the current capacity of the underlying array
      public int Capacity => mArray.Length;

      // Indexer to get or set elements at a specific index
      public T this[int index] {
         get {
            ArgumentOutOfRangeException.ThrowIfNegative (index);
            if (index >= mCount) throw new IndexOutOfRangeException ();
            return mArray[index];
         }
         set {
            ArgumentOutOfRangeException.ThrowIfNegative (index);
            if (index >= mCount) throw new IndexOutOfRangeException ();
            mArray[index] = value;
         }
      }

      // Adds the given element to the end of the list
      public void Add (T element) {
         if (mCount == Capacity) Array.Resize (ref mArray, Capacity * 2);
         mArray[mCount++] = element;
      }

      // Removes the first occurrence of the given element from the list
      public bool Remove (T element) {
         int index = Array.IndexOf (mArray, element);
         if (index is -1) return false;
         else {
            for (int i = index; i < mCount - 1; i++) mArray[i] = mArray[i + 1];
            mCount--;
            return true;
         }
      }

      // Clears the list
      public void Clear () {
         if (mCount == 0) return;
         Array.Clear (mArray);
         mCount = 0;
      }

      // Inserts the given element at the specified index
      public void Insert (int index, T a) {
         ArgumentOutOfRangeException.ThrowIfNegative (index);
         if (index > mCount) throw new IndexOutOfRangeException ();
         if (mCount == Capacity) Array.Resize (ref mArray, Capacity * 2);
         for (int i = mCount; i > index; i--) mArray[i] = mArray[i - 1];
         mArray[index] = a;
         mCount++;
      }

      // Removes the element at the specified index
      public void RemoveAt (int index) {
         ArgumentOutOfRangeException.ThrowIfNegative (index);
         if (index >= mCount) throw new IndexOutOfRangeException ();
         for (int i = index; i < mCount - 1; i++) mArray[i] = mArray[i + 1];
         mCount--;
      }

      // Displays the elements of the list
      public void Display () {
         for (int i = 0; i < mCount; i++) Write (this[i] + " ");
         WriteLine ();
      }

      #region Private data -------------------------------------------
      T[] mArray;
      int mCount;
      #endregion
   }
   #endregion
}