/*
================================================================================
TOPIC 26: GENERICS - Type Parameters <T>
================================================================================

WHAT IS THIS?
-------------
Generics let you create classes, methods, and interfaces that work with ANY data type.
You've already used them! List<T> and Dictionary<TKey, TValue> are generic types.
The <T> is a placeholder for any type (int, string, custom class, etc.).

WHY DO WE NEED THIS?
--------------------
- Code reuse - Write once, use with any type
- Type safety - Compiler catches type errors
- Performance - No boxing/unboxing overhead
- Avoid code duplication - One generic class instead of many
- Foundation for Collections - List<T>, Dictionary<TKey, TValue> use generics

WHERE IS THIS USED?
-------------------
- Collections: List<T>, Dictionary<TKey, TValue>, Queue<T>
- LINQ methods: Where<T>, Select<T>
- Repository pattern - Generic repositories
- Any reusable code that works with multiple types
- Professional C# development

CONCEPTS YOU'LL LEARN:
---------------------
1. Generic classes: class Box<T> { }
2. Generic methods: void Swap<T>(ref T a, ref T b)
3. Type parameters: <T> placeholder
4. Constraints: where T : class, where T : new()
5. Multiple type parameters: Dictionary<TKey, TValue>

================================================================================
*/

using System;
using System.Collections.Generic;

namespace GenericsExample
{
    // WITHOUT Generics (BAD - Code duplication)
    class IntBox
    {
        public int Value { get; set; }
    }
    
    class StringBox
    {
        public string Value { get; set; }
    }
    
    // WITH Generics (GOOD - One class for all types)
    class Box<T>  // T is a type parameter (placeholder for any type)
    {
        public T Value { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Use Box with int
            Box<int> intBox = new Box<int>();
            intBox.Value = 42;
            
            // Use Box with string
            Box<string> stringBox = new Box<string>();
            stringBox.Value = "Hello";
            
            // Use Box with any type!
            Box<double> doubleBox = new Box<double>();
            doubleBox.Value = 3.14;
        }
    }
}

// Generic Methods
class GenericMethods
{
    // Generic method - works with any type
    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
    
    static void Main(string[] args)
    {
        int x = 10, y = 20;
        Swap<int>(ref x, ref y);
        Console.WriteLine($"x: {x}, y: {y}");  // x: 20, y: 10
        
        string str1 = "Hello", str2 = "World";
        Swap<string>(ref str1, ref str2);
        Console.WriteLine($"str1: {str1}, str2: {str2}");  // str1: World, str2: Hello
    }
}

// Generic Constraints
class GenericConstraints
{
    // Constraint: T must be a class (reference type)
    class Box<T> where T : class
    {
        public T Value { get; set; }
    }
    
    // Constraint: T must have a parameterless constructor
    class Factory<T> where T : new()
    {
        public T Create()
        {
            return new T();
        }
    }
    
    // Constraint: T must implement IComparable interface
    class SortedList<T> where T : IComparable<T>
    {
        public void Sort(T[] items)
        {
            // Can use CompareTo because T implements IComparable
            Array.Sort(items);
        }
    }
}

// Why Use Generics?
// 1. Type Safety - Compiler catches type errors
// 2. Performance - No boxing/unboxing for value types
// 3. Code Reuse - Write once, use with any type
// 4. IntelliSense - Better IDE support

// Real-World Example: Repository Pattern
class GenericRepository<T>
{
    private List<T> _items = new List<T>();
    
    public void Add(T item)
    {
        _items.Add(item);
    }
    
    public T GetById(int id)
    {
        // Simplified - real implementation would use ID property
        return _items[id];
    }
    
    public List<T> GetAll()
    {
        return _items;
    }
}

class User
{
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Repository for Users
        GenericRepository<User> userRepo = new GenericRepository<User>();
        userRepo.Add(new User { Name = "Alice" });
        
        // Repository for Products (same code!)
        GenericRepository<Product> productRepo = new GenericRepository<Product>();
        productRepo.Add(new Product { Name = "Laptop" });
    }
}

class Product
{
    public string Name { get; set; }
}

/*
=== TOPIC 26 SUMMARY: GENERICS ===
- Generics allow code to work with any type: class Box<T> { }
- Type parameter: <T> is a placeholder for any type
- Usage: Box<int>, Box<string>, List<int>, Dictionary<string, int>
- Generic methods: void Swap<T>(ref T a, ref T b)
- Constraints: where T : class, where T : new(), where T : IComparable<T>
- Benefits: Type safety, Performance, Code reuse
- Remember: List<T> and Dictionary<TKey, TValue> are generic types you've been using!
*/
