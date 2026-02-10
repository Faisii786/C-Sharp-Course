/*
================================================================================
TOPIC 31: STATIC - Class-Level Members
================================================================================

WHAT IS THIS?
-------------
The 'static' keyword means a member belongs to the class itself, not to instances
(objects). You access static members using the class name: ClassName.Method().
You've been using static: Console.WriteLine(), Math.Max(), DateTime.Now!

WHY DO WE NEED THIS?
--------------------
- Utility methods - Methods that don't need object state
- Shared data - Data shared by all instances
- Constants - Values that don't change
- Helper classes - Math, Console, String (all static)
- Performance - No need to create objects
- Common pattern - Used throughout .NET Framework

WHERE IS THIS USED?
-------------------
- Utility classes: Math.Max(), Math.Min(), Math.Sqrt()
- Console: Console.WriteLine(), Console.ReadLine()
- String methods: string.Join(), string.Format()
- DateTime: DateTime.Now, DateTime.Today
- Counters - Track how many objects created
- Helper methods - Don't need object state

CONCEPTS YOU'LL LEARN:
---------------------
1. Static methods - Called on class, not object
2. Static fields - Shared by all instances
3. Static classes - Cannot create instances
4. Static vs instance - When to use each
5. Static constructor - Runs once before first use

================================================================================
*/

using System;

namespace StaticExample
{
    class Program
    {
        // Instance member (belongs to each object)
        public string Name { get; set; }
        
        // Static member (belongs to the class)
        public static int Count { get; set; }
        
        public Program()
        {
            Count++;  // Increment static counter for each object created
        }
        
        // Static method (called on class, not object)
        public static void PrintCount()
        {
            Console.WriteLine($"Total objects created: {Count}");
        }
        
        // Instance method (called on object)
        public void PrintName()
        {
            Console.WriteLine($"Name: {Name}");
        }
        
        static void Main(string[] args)
        {
            // Create objects
            Program obj1 = new Program { Name = "Alice" };
            Program obj2 = new Program { Name = "Bob" };
            Program obj3 = new Program { Name = "Charlie" };
            
            // Access instance member (on object)
            obj1.PrintName();  // Name: Alice
            
            // Access static member (on class)
            Program.PrintCount();  // Total objects created: 3
            
            // Static members are shared by all instances
            Console.WriteLine(Program.Count);  // 3 (shared by all objects)
        }
    }
}

// Static Classes
class StaticClasses
{
    // Static class - cannot create instances, only contains static members
    static class MathHelper
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    
    static void Main(string[] args)
    {
        // Call static methods directly on class
        int sum = MathHelper.Add(5, 3);  // 8
        int product = MathHelper.Multiply(4, 6);  // 24
        
        // Cannot create instance of static class
        // MathHelper helper = new MathHelper();  // ERROR!
    }
}

// Static vs Instance
class StaticVsInstance
{
    class Counter
    {
        // Instance field - each object has its own
        public int InstanceCount = 0;
        
        // Static field - shared by all objects
        public static int StaticCount = 0;
        
        public void Increment()
        {
            InstanceCount++;  // Increment this object's count
            StaticCount++;   // Increment shared count
        }
    }
    
    static void Main(string[] args)
    {
        Counter c1 = new Counter();
        Counter c2 = new Counter();
        
        c1.Increment();
        c1.Increment();
        c2.Increment();
        
        Console.WriteLine($"c1.InstanceCount: {c1.InstanceCount}");  // 2
        Console.WriteLine($"c2.InstanceCount: {c2.InstanceCount}");  // 1
        Console.WriteLine($"Counter.StaticCount: {Counter.StaticCount}");  // 3 (shared!)
    }
}

// Common Static Members You've Used
class CommonStatic
{
    static void Main(string[] args)
    {
        // Console is a static class
        Console.WriteLine("Hello");  // Static method
        
        // Math is a static class
        int max = Math.Max(5, 10);  // Static method
        double sqrt = Math.Sqrt(16);  // Static method
        
        // DateTime has static properties
        DateTime now = DateTime.Now;  // Static property
        DateTime today = DateTime.Today;  // Static property
        
        // String has static methods
        string joined = string.Join(", ", new[] { "a", "b", "c" });  // Static method
    }
}

// Static Constructor
class StaticConstructor
{
    class MyClass
    {
        public static int Value;
        
        // Static constructor - runs once before first use of class
        static MyClass()
        {
            Value = 100;
            Console.WriteLine("Static constructor called!");
        }
    }
    
    static void Main(string[] args)
    {
        // Static constructor runs here (first time class is accessed)
        Console.WriteLine(MyClass.Value);  // 100
    }
}

// When to Use Static
class WhenToUseStatic
{
    // Use static for:
    // 1. Utility methods that don't need object state
    // 2. Constants or shared data
    // 3. Helper/utility classes (like Math, Console)
    
    // Don't use static for:
    // 1. Methods that need object state
    // 2. When you need multiple instances with different data
    
    static class StringHelper
    {
        // Good use of static - doesn't need object state
        public static string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
    
    class Person
    {
        // Instance members - each person has different name
        public string Name { get; set; }
        
        // Instance method - uses object's name
        public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}");
        }
    }
}

/*
=== TOPIC 31 SUMMARY: STATIC ===
- static members belong to the class, not instances
- Access: ClassName.StaticMember (not object.StaticMember)
- Static methods: Called on class - Math.Max(), Console.WriteLine()
- Static fields: Shared by all instances (like a counter)
- Static class: Cannot create instances, only static members
- Instance members: Each object has its own copy
- Use static for: Utility methods, shared data, helper classes
- Don't use static for: Methods that need object state
- Remember: static = belongs to class, instance = belongs to object
*/
