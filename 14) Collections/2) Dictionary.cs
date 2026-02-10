/*
================================================================================
TOPIC 22: COLLECTIONS - Dictionary<TKey, TValue> (Key-Value Pairs)
================================================================================

WHAT IS THIS?
-------------
Dictionary<TKey, TValue> stores key-value pairs. Like a real dictionary: you look
up a word (key) to get its definition (value). Each key must be unique, and you
can quickly find values by their key.

WHY DO WE NEED THIS?
--------------------
- Fast lookup - Find value by key instantly (O(1) performance)
- Key-value mapping - Natural for many real-world scenarios
- Unique keys - Prevents duplicates automatically
- Better than arrays - Don't need to know index, use meaningful keys
- Common pattern - Used everywhere in real applications

WHERE IS THIS USED?
-------------------
- User data: Dictionary<string, User> (username -> user object)
- Settings: Dictionary<string, string> (setting name -> value)
- Caching: Dictionary<int, Product> (product ID -> product)
- API responses: Dictionary<string, object>
- Configuration: Dictionary<string, string>
- Any key-value mapping scenario

CONCEPTS YOU'LL LEARN:
---------------------
1. Key-value pairs - Each key maps to one value
2. Unique keys - Cannot have duplicate keys
3. Access: dict["key"] or dict.TryGetValue("key", out value)
4. Add/Update: dict["key"] = value
5. ContainsKey() - Check if key exists
6. Keys and Values - Collections of all keys/values
7. Safe access - Use TryGetValue to avoid errors

================================================================================
*/

using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Dictionary: key is string, value is int
            Dictionary<string, int> ages = new Dictionary<string, int>();
            
            // Add key-value pairs
            ages.Add("Alice", 25);
            ages.Add("Bob", 30);
            ages.Add("Charlie", 35);
            
            // Access value by key
            Console.WriteLine($"Alice's age: {ages["Alice"]}");  // 25
            
            // Or use TryGetValue (safer - won't throw error if key doesn't exist)
            if (ages.TryGetValue("Bob", out int bobAge))
            {
                Console.WriteLine($"Bob's age: {bobAge}");  // 30
            }
            
            // Check if key exists
            if (ages.ContainsKey("Charlie"))
            {
                Console.WriteLine("Charlie exists!");
            }
            
            // Update a value
            ages["Alice"] = 26;  // Alice had a birthday!
            
            // Remove a key-value pair
            ages.Remove("Bob");
            
            // Count
            Console.WriteLine($"Total people: {ages.Count}");  // 2
            
            // Loop through dictionary
            foreach (KeyValuePair<string, int> person in ages)
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old");
            }
            
            // Or loop through keys only
            foreach (string name in ages.Keys)
            {
                Console.WriteLine(name);
            }
            
            // Or loop through values only
            foreach (int age in ages.Values)
            {
                Console.WriteLine(age);
            }
        }
    }
}

// Real-World Example: Student Grades
class StudentGrades
{
    static void Main(string[] args)
    {
        Dictionary<string, string> grades = new Dictionary<string, string>
        {
            { "Math", "A" },
            { "Science", "B" },
            { "English", "A" }
        };
        
        // Add more
        grades["History"] = "B+";
        
        // Display all grades
        foreach (var subject in grades)
        {
            Console.WriteLine($"{subject.Key}: {subject.Value}");
        }
        
        // Check if student passed all subjects (all grades >= B)
        bool allPassed = true;
        foreach (var grade in grades.Values)
        {
            if (grade == "F" || grade == "D")
            {
                allPassed = false;
                break;
            }
        }
        Console.WriteLine($"All passed: {allPassed}");
    }
}

// Dictionary Methods You'll Use Most:
// Add(key, value) - Add key-value pair (throws error if key exists)
// [key] = value - Add or update value
// [key] - Get value (throws error if key doesn't exist)
// TryGetValue(key, out value) - Safe way to get value (returns bool)
// ContainsKey(key) - Check if key exists
// Remove(key) - Remove key-value pair
// Count - Number of key-value pairs
// Keys - Collection of all keys
// Values - Collection of all values
// Clear() - Remove all items

/*
=== TOPIC 22 SUMMARY: DICTIONARY<TKey, TValue> ===
- Dictionary stores key-value pairs (like a real dictionary)
- Each key must be unique
- Create: Dictionary<string, int> dict = new Dictionary<string, int>();
- Add: dict.Add("key", value) or dict["key"] = value
- Access: dict["key"] (throws error if key doesn't exist)
- Safe access: dict.TryGetValue("key", out int value)
- Check: dict.ContainsKey("key")
- Remove: dict.Remove("key")
- Loop: foreach (KeyValuePair<string, int> item in dict) { item.Key, item.Value }
- Remember: Keys must be unique! Use TryGetValue for safe access.
*/
