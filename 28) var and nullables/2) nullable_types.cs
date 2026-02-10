/*
================================================================================
TOPIC 28: NULLABLE TYPES - Handling null Values
================================================================================

WHAT IS THIS?
-------------
Nullable types allow value types (int, bool, double) to be null using the ?
syntax. Example: int? age = null. This is useful when a value might not exist
(like optional database fields, user input that might be missing).

WHY DO WE NEED THIS?
--------------------
- Database fields - Optional fields can be null
- User input - User might not provide value
- API responses - Some fields might be missing
- Avoid errors - Handle "no value" case safely
- Real-world data - Not everything has a value

WHERE IS THIS USED?
-------------------
- Database operations (optional fields)
- API responses (missing fields)
- User input validation
- Configuration (optional settings)
- Any situation where value might not exist

CONCEPTS YOU'LL LEARN:
---------------------
1. Nullable syntax: int?, bool?, double?, DateTime?
2. HasValue - Check if has value
3. Value - Get the actual value
4. GetValueOrDefault() - Get value or default
5. ?? operator - Null coalescing (use default if null)
6. ?. operator - Null-conditional (safe access)

================================================================================
*/

using System;

namespace NullableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regular int - cannot be null
            int age1 = 25;
            // int age2 = null;  // ERROR! int cannot be null
            
            // Nullable int - can be null
            int? age3 = 25;      // Can hold a value
            int? age4 = null;    // Can also be null!
            
            // Check if nullable has a value
            if (age3.HasValue)
            {
                Console.WriteLine($"Age: {age3.Value}");
            }
            else
            {
                Console.WriteLine("Age is not set");
            }
            
            // Shorter way - use ?? operator (null coalescing)
            int actualAge = age3 ?? 0;  // Use age3 if not null, otherwise use 0
            Console.WriteLine($"Actual age: {actualAge}");
        }
    }
}

// Nullable Syntax
class NullableSyntax
{
    static void Main(string[] args)
    {
        // All these are nullable types:
        int? nullableInt = null;
        bool? nullableBool = null;
        double? nullableDouble = null;
        DateTime? nullableDate = null;
        
        // Check if has value
        if (nullableInt.HasValue)
        {
            int value = nullableInt.Value;  // Get the value
        }
        
        // Or use GetValueOrDefault
        int valueOrDefault = nullableInt.GetValueOrDefault();  // 0 if null
        int valueOrDefault2 = nullableInt.GetValueOrDefault(100);  // 100 if null
    }
}

// Null Coalescing Operator ??
class NullCoalescing
{
    static void Main(string[] args)
    {
        int? age = null;
        
        // ?? operator - use left side if not null, otherwise use right side
        int actualAge = age ?? 0;  // 0 (because age is null)
        
        age = 25;
        actualAge = age ?? 0;  // 25 (because age is not null)
        
        // Chaining ??
        int? a = null;
        int? b = null;
        int? c = 10;
        int result = a ?? b ?? c ?? 0;  // 10 (first non-null value)
    }
}

// Null-Conditional Operator ?.
class NullConditional
{
    class Person
    {
        public string Name { get; set; }
        public Address Address { get; set; }
    }
    
    class Address
    {
        public string City { get; set; }
    }
    
    static void Main(string[] args)
    {
        Person person = null;
        
        // Without ?. - would throw NullReferenceException
        // string city = person.Address.City;  // ERROR if person is null!
        
        // With ?. - returns null if person is null
        string city = person?.Address?.City;  // null (safe!)
        
        // Use with ?? to provide default
        string safeCity = person?.Address?.City ?? "Unknown";
        
        // Works with methods too
        int? length = person?.Name?.Length;  // null if person or Name is null
    }
}

// Real-World Example: Database Values
class DatabaseExample
{
    static void Main(string[] args)
    {
        // Database might return null for optional fields
        int? userId = GetUserIdFromDatabase();  // Might be null
        
        if (userId.HasValue)
        {
            Console.WriteLine($"User ID: {userId.Value}");
        }
        else
        {
            Console.WriteLine("User ID not found");
        }
        
        // Or use ?? for default
        int id = userId ?? -1;  // -1 if not found
    }
    
    static int? GetUserIdFromDatabase()
    {
        // Simulate database call
        return null;  // User not found
    }
}

// Nullable Reference Types (C# 8.0+)
// Note: This is advanced - nullable value types (int?) are more common for basics

/*
=== TOPIC 28 SUMMARY: NULLABLE TYPES ===
- Nullable types allow value types to be null: int? age = null;
- Syntax: Add ? after type: int?, bool?, double?, DateTime?
- Check if has value: if (age.HasValue) { int value = age.Value; }
- GetValueOrDefault(): Returns value or default (0 for int)
- ?? operator: age ?? 0 (use age if not null, otherwise 0)
- ?. operator: person?.Name (safe access - returns null if person is null)
- Remember: Use nullable types when a value might not exist (e.g., optional database fields)
*/
