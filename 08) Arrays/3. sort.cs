// ========== TOPIC 16: SORT & LINQ — Refresh: Array.Sort(arr); Linq: Max(), Min(), Sum() ==========
// Sort an Array
// There are many array methods available, for example Sort(), which sorts an array alphabetically or in an ascending order:

// Example
// Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
  Console.WriteLine(i);
}
 
// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers)
{
  Console.WriteLine(i);
} 

// System.Linq Namespace
// Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace:

// Example
using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] myNumbers = {5, 1, 8, 9};
      Console.WriteLine(myNumbers.Max());  // returns the largest value
      Console.WriteLine(myNumbers.Min());  // returns the smallest value
      Console.WriteLine(myNumbers.Sum());  // returns the sum of elements
    }
  }
}
 
 
 
 

// You will learn more about other namespaces in a later chapter.

/*
=== TOPIC 16 SUMMARY (ARRAYS): SORT & LINQ ===
- Sort: Array.Sort(arr) — sorts alphabetically (strings) or ascending (numbers).
- System.Linq: using System.Linq; then arr.Max(), arr.Min(), arr.Sum() for largest, smallest, and sum of elements.
- Remember: Sort modifies the array in place. Min/Max/Sum need using System.Linq; and work on int[], etc.
*/
