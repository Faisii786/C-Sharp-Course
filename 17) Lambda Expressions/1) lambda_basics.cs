/*
================================================================================
TOPIC 27: LAMBDA EXPRESSIONS - Arrow Functions =>
================================================================================

WHAT IS THIS?
-------------
Lambda expressions are a shorter way to write anonymous methods (methods without names).
You've already used them in LINQ! The => syntax is called "arrow function" or "lambda".
Example: numbers.Where(n => n > 5) means "for each n, return true if n > 5".

WHY DO WE NEED THIS?
--------------------
- Shorter code - One line instead of full method
- Readable - Clear intent (filter, transform, etc.)
- Required for LINQ - Can't use LINQ without lambdas
- Modern C# - Used everywhere in professional code
- Functional programming style - Clean and expressive

WHERE IS THIS USED?
-------------------
- LINQ queries: Where(n => n > 5), Select(n => n * 2)
- Event handlers: button.Click += (s, e) => { ... }
- Callbacks and delegates
- Anywhere you need a short, inline function

CONCEPTS YOU'LL LEARN:
---------------------
1. Syntax: (parameters) => expression
2. Single parameter: n => n * 2
3. Multiple parameters: (x, y) => x + y
4. Multiple statements: n => { ... return result; }
5. Action<T> - Method that returns void
6. Func<T, TResult> - Method that returns value

================================================================================
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Traditional Method (long way)
            int[] numbers = { 1, 2, 3, 4, 5 };
            
            // Using a named method
            var evens1 = numbers.Where(IsEven);
            
            // Using anonymous method (old way)
            var evens2 = numbers.Where(delegate(int n) { return n % 2 == 0; });
            
            // Using lambda expression (short way) - THIS IS WHAT YOU USE!
            var evens3 = numbers.Where(n => n % 2 == 0);
            
            // Lambda syntax: (parameters) => expression
            // n => n % 2 == 0 means: "for each n, return true if n is even"
        }
        
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}

// Lambda Syntax Examples
class LambdaSyntax
{
    static void Main(string[] args)
    {
        // Single parameter - no parentheses needed
        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));  // 25
        
        // Multiple parameters - parentheses required
        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine(add(3, 4));  // 7
        
        // No parameters - empty parentheses
        Func<string> greet = () => "Hello!";
        Console.WriteLine(greet());  // Hello!
        
        // Multiple statements - use curly braces and return
        Func<int, int> factorial = n =>
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        };
        Console.WriteLine(factorial(5));  // 120
    }
}

// Lambdas in LINQ (You've been using these!)
class LambdaInLINQ
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // WHERE - filter with lambda
        var evens = numbers.Where(n => n % 2 == 0);  // 2, 4, 6, 8, 10
        
        // SELECT - transform with lambda
        var squared = numbers.Select(n => n * n);  // 1, 4, 9, 16, 25, ...
        
        // FIRST - find with lambda
        var firstEven = numbers.First(n => n > 5);  // 6
        
        // ANY - check condition with lambda
        bool hasEven = numbers.Any(n => n % 2 == 0);  // true
        
        // ALL - check all with lambda
        bool allPositive = numbers.All(n => n > 0);  // true
        
        // ORDERBY - sort with lambda
        var sorted = numbers.OrderByDescending(n => n);  // 10, 9, 8, ...
    }
}

// Lambdas with Objects
class LambdaWithObjects
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 35 }
        };
        
        // Filter people older than 27
        var older = people.Where(p => p.Age > 27);
        
        // Get names only
        var names = people.Select(p => p.Name);
        
        // Find person named "Bob"
        var bob = people.FirstOrDefault(p => p.Name == "Bob");
        
        // Sort by age
        var sortedByAge = people.OrderBy(p => p.Age);
    }
}

// Action and Func Delegates
class ActionAndFunc
{
    static void Main(string[] args)
    {
        // Action - method that returns void
        Action<string> print = message => Console.WriteLine(message);
        print("Hello!");  // Hello!
        
        // Func<T, TResult> - method that returns a value
        Func<int, int> doubleIt = x => x * 2;
        Console.WriteLine(doubleIt(5));  // 10
        
        // Func with multiple parameters
        Func<int, int, int> multiply = (x, y) => x * y;
        Console.WriteLine(multiply(3, 4));  // 12
        
        // Func with different return type
        Func<string, int> getLength = s => s.Length;
        Console.WriteLine(getLength("Hello"));  // 5
    }
}

// When to Use Lambdas
// 1. LINQ queries - numbers.Where(n => n > 5)
// 2. Event handlers - button.Click += (s, e) => { ... }
// 3. Callbacks - DoSomething(() => Console.WriteLine("Done"))
// 4. Short, simple operations that don't need a full method

/*
=== TOPIC 27 SUMMARY: LAMBDA EXPRESSIONS ===
- Lambda = shorter way to write anonymous methods
- Syntax: (parameters) => expression
- Single parameter: n => n * 2 (no parentheses needed)
- Multiple parameters: (x, y) => x + y (parentheses required)
- Multiple statements: n => { ... return result; }
- Used everywhere in LINQ: Where(n => n > 5), Select(n => n * 2)
- Action<T> = method that returns void
- Func<T, TResult> = method that returns a value
- Remember: n => n > 5 means "for each n, return true if n is greater than 5"
*/
