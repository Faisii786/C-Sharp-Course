/*
================================================================================
TOPIC 28: VAR KEYWORD - Type Inference
================================================================================

WHAT IS THIS?
-------------
The 'var' keyword lets the compiler automatically figure out the variable type
from the value you assign. The variable is still strongly typed - just shorter
to write! Example: var name = "Alice" (compiler knows it's string).

WHY DO WE NEED THIS?
--------------------
- Shorter code - Less typing
- Cleaner LINQ queries - var result = numbers.Where(...)
- Required for anonymous types - Can't use explicit type
- Modern C# style - Used in professional code
- Still type-safe - Compiler enforces types

WHERE IS THIS USED?
-------------------
- LINQ queries (very common!)
- Anonymous types (required!)
- Long generic types: var dict = new Dictionary<string, List<int>>()
- When type is obvious from right side

CONCEPTS YOU'LL LEARN:
---------------------
1. Type inference - Compiler figures out type
2. When to use var - LINQ, anonymous types, obvious types
3. When NOT to use var - Unclear types, primitives
4. Still strongly typed - No performance difference

================================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace VarExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicit type (long way)
            string name1 = "Alice";
            int age1 = 25;
            List<string> names1 = new List<string>();
            
            // Using var (short way - compiler figures out the type)
            var name2 = "Alice";        // Compiler knows it's string
            var age2 = 25;              // Compiler knows it's int
            var names2 = new List<string>();  // Compiler knows it's List<string>
            
            // Both are the same! var is just shorter.
            // name1 and name2 are both string type.
            
            // Common use cases for var:
            
            // 1. LINQ queries (very common!)
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var evens = numbers.Where(n => n % 2 == 0).ToList();
            // evens is List<int> - compiler knows from LINQ chain
            
            // 2. Complex types
            var person = new { Name = "Alice", Age = 25 };
            // person is anonymous type - var is required here!
            
            // 3. Long generic types
            var dictionary = new Dictionary<string, List<int>>();
            // Shorter than: Dictionary<string, List<int>> dictionary = ...
            
            // 4. When type is obvious from right side
            var count = numbers.Count();  // Obviously int
            var message = "Hello";        // Obviously string
        }
    }
}

// When to Use var
class WhenToUseVar
{
    static void Main(string[] args)
    {
        // ✅ GOOD - Use var when:
        // 1. Type is obvious from right side
        var name = "Alice";  // Obviously string
        var age = 25;       // Obviously int
        
        // 2. LINQ queries
        var result = numbers.Where(n => n > 5).Select(n => n * 2).ToList();
        
        // 3. Anonymous types (required!)
        var person = new { Name = "Alice", Age = 25 };
        
        // ❌ BAD - Don't use var when:
        // 1. Type is not obvious
        // var data = GetData();  // What type is data? Not clear!
        // Better: List<string> data = GetData();
        
        // 2. Primitive types (optional, but explicit is clearer)
        // var x = 5;  // Works, but int x = 5; is clearer
    }
}

// var vs Explicit Types
class VarVsExplicit
{
    static void Main(string[] args)
    {
        // Both are identical - choose based on readability
        string name1 = "Alice";
        var name2 = "Alice";
        
        // name1 and name2 are both string - no difference!
        
        // Use explicit when:
        // - Type is not obvious
        // - You want to be very clear about the type
        // - Working with primitives (int, string, bool)
        
        // Use var when:
        // - LINQ queries
        // - Long generic types
        // - Anonymous types
        // - Type is obvious from context
    }
}

/*
=== TOPIC 28 SUMMARY: VAR KEYWORD ===
- var = compiler figures out the type automatically
- Still strongly typed - just shorter syntax
- Common uses: LINQ queries, anonymous types, long generic types
- Use when type is obvious: var name = "Alice";
- Don't use when type is unclear: var data = GetData(); (unclear!)
- Remember: var is just syntactic sugar - variable still has a specific type!
*/
