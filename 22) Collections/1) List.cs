/*
================================================================================
TOPIC 22: COLLECTIONS - List<T> (Dynamic Arrays)
================================================================================

WHAT IS THIS?
-------------
List<T> is a collection that stores multiple items of the same type. Unlike arrays,
Lists can grow and shrink dynamically - you can add or remove items anytime!

WHY DO WE NEED THIS?
--------------------
- Arrays have fixed size - you must know size in advance
- Lists are flexible - add/remove items as needed
- Real-world data is dynamic (users, orders, products change)
- Much easier than managing array sizes manually
- Foundation for LINQ (you'll learn this next!)

WHERE IS THIS USED?
-------------------
- Storing user data, shopping carts, product lists
- Database results, API responses
- Any situation where you don't know size in advance
- Most common collection type in C#
- Used in 90% of real applications

CONCEPTS YOU'LL LEARN:
---------------------
1. List<T> - Generic type (T = any type like int, string)
2. Add() - Add items dynamically
3. Remove() - Remove items
4. Count - Get number of items (not Length!)
5. Contains() - Check if item exists
6. Index access - list[0] like arrays
7. foreach loop - Iterate through items

================================================================================
*/

using System;
using System.Collections.Generic;

namespace CollectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a List of strings
            List<string> fruits = new List<string>();
            
            // Add items to the list
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            
            // Access items by index (like arrays)
            Console.WriteLine(fruits[0]);  // Apple
            Console.WriteLine(fruits[1]);  // Banana
            
            // Count property (not Length like arrays)
            Console.WriteLine($"Total fruits: {fruits.Count}");  // 3
            
            // Loop through list
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            
            // Remove an item
            fruits.Remove("Banana");
            Console.WriteLine($"After removing Banana: {fruits.Count}");  // 2
            
            // Check if item exists
            if (fruits.Contains("Apple"))
            {
                Console.WriteLine("Apple is in the list!");
            }
            
            // Clear all items
            fruits.Clear();
            Console.WriteLine($"After clearing: {fruits.Count}");  // 0
        }
    }
}

// List Methods You'll Use Most:
// Add(item) - Add item to end
// Remove(item) - Remove first occurrence
// RemoveAt(index) - Remove at specific index
// Contains(item) - Check if item exists (returns bool)
// Count - Get number of items (property, not method)
// Clear() - Remove all items
// Insert(index, item) - Insert at specific position
// IndexOf(item) - Find index of item

// Example: List of Numbers
class ListNumbers
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 20, 30 };  // Initialize with values
        
        numbers.Add(40);
        numbers.Add(50);
        
        // Find sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"Sum: {sum}");  // 150
        
        // Or use LINQ (you'll learn this next!)
        // int sum = numbers.Sum();
    }
}

/*
=== TOPIC 22 SUMMARY: LIST<T> ===
- List<T> is a dynamic collection that can grow/shrink
- Create: List<string> list = new List<string>();
- Add: list.Add("item");
- Access: list[0] (like arrays)
- Count: list.Count (property, not Length)
- Remove: list.Remove("item") or list.RemoveAt(0)
- Contains: list.Contains("item") returns bool
- Loop: foreach (var item in list) { ... }
- Remember: Lists are dynamic, arrays are fixed size. Use Count, not Length!
*/
