/*
================================================================================
TOPIC 29: REF AND OUT PARAMETERS - Passing by Reference
================================================================================

WHAT IS THIS?
-------------
By default, C# passes parameters by value (creates a copy). ref and out allow
you to pass by reference (use the original variable). Changes inside the method
affect the original variable!

WHY DO WE NEED THIS?
--------------------
- Return multiple values - Methods can modify multiple variables
- Swap values - Change two variables in one method
- TryParse pattern - Very common! int.TryParse(string, out int)
- Performance - Avoid copying large structures
- Required for: Dictionary.TryGetValue(), int.TryParse()

WHERE IS THIS USED?
-------------------
- TryParse methods: int.TryParse(input, out int result)
- Dictionary: dict.TryGetValue(key, out value)
- Swap operations: Swap(ref a, ref b)
- Methods that need to modify multiple values
- Performance-critical code

CONCEPTS YOU'LL LEARN:
---------------------
1. ref - Pass by reference, variable must be initialized
2. out - Pass by reference, variable doesn't need initialization
3. TryParse pattern - Common use of out parameter
4. When to use ref vs out
5. Multiple return values

================================================================================
*/

using System;

namespace RefOutExample
{
    class Program
    {
        // Normal parameter (by value - creates a copy)
        static void NormalMethod(int x)
        {
            x = 100;  // Only changes the copy, not the original
        }
        
        // ref parameter (by reference - uses original variable)
        static void RefMethod(ref int x)
        {
            x = 100;  // Changes the original variable!
        }
        
        // out parameter (by reference, but must be assigned in method)
        static void OutMethod(out int x)
        {
            x = 200;  // MUST assign a value before method returns
        }
        
        static void Main(string[] args)
        {
            int number = 10;
            
            // Normal - doesn't change number
            NormalMethod(number);
            Console.WriteLine(number);  // Still 10
            
            // ref - changes number
            RefMethod(ref number);
            Console.WriteLine(number);  // Now 100!
            
            // out - variable doesn't need to be initialized
            int result;
            OutMethod(out result);
            Console.WriteLine(result);  // 200
        }
    }
}

// ref Parameter
class RefExample
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        Swap(ref x, ref y);
        Console.WriteLine($"x: {x}, y: {y}");  // x: 20, y: 10
    }
}

// out Parameter
class OutExample
{
    // out is used when method needs to return multiple values
    static void Divide(int dividend, int divisor, out int quotient, out int remainder)
    {
        quotient = dividend / divisor;
        remainder = dividend % divisor;
    }
    
    static void Main(string[] args)
    {
        int q, r;
        Divide(10, 3, out q, out r);
        Console.WriteLine($"Quotient: {q}, Remainder: {r}");  // Quotient: 3, Remainder: 1
        
        // Modern C# - declare out variable inline
        Divide(20, 4, out int quotient2, out int remainder2);
        Console.WriteLine($"Quotient: {quotient2}, Remainder: {remainder2}");
    }
}

// TryParse Pattern (Very Common!)
class TryParseExample
{
    static void Main(string[] args)
    {
        string input = "123";
        
        // TryParse uses out parameter
        if (int.TryParse(input, out int number))
        {
            Console.WriteLine($"Parsed: {number}");  // Parsed: 123
        }
        else
        {
            Console.WriteLine("Invalid number");
        }
        
        // Dictionary.TryGetValue also uses out
        Dictionary<string, int> ages = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 }
        };
        
        if (ages.TryGetValue("Alice", out int age))
        {
            Console.WriteLine($"Alice's age: {age}");  // Alice's age: 25
        }
    }
}

// ref vs out
class RefVsOut
{
    static void RefExample(ref int x)
    {
        // x must be initialized before calling
        x = x + 10;  // Can read and write
    }
    
    static void OutExample(out int x)
    {
        // x doesn't need to be initialized before calling
        // x = x + 10;  // ERROR! Can't read x before assigning
        x = 10;  // MUST assign before method returns
    }
    
    static void Main(string[] args)
    {
        int a = 5;
        RefExample(ref a);  // a must be initialized
        
        int b;
        OutExample(out b);  // b doesn't need to be initialized
    }
}

// When to Use ref vs out
class WhenToUse
{
    // Use ref when:
    // - You want to modify an existing variable
    // - Variable must be initialized before calling
    
    // Use out when:
    // - Method needs to return multiple values
    // - Variable doesn't need to be initialized
    // - Method MUST assign a value (like TryParse)
    
    static void Main(string[] args)
    {
        // ref example - modify existing
        int count = 0;
        Increment(ref count);
        
        // out example - get new value
        if (TryGetValue(out int value))
        {
            Console.WriteLine(value);
        }
    }
    
    static void Increment(ref int x)
    {
        x++;
    }
    
    static bool TryGetValue(out int value)
    {
        value = 42;
        return true;
    }
}

/*
=== TOPIC 29 SUMMARY: REF AND OUT ===
- By default, parameters are passed by value (copy)
- ref = pass by reference, variable must be initialized
- out = pass by reference, variable doesn't need initialization, MUST be assigned in method
- ref: Use when modifying existing variable
- out: Use when returning multiple values or optional results (TryParse pattern)
- Common uses: Swap(ref a, ref b), TryParse(string, out int), TryGetValue(key, out value)
- Remember: ref can read and write, out can only write (must assign before return)
*/
