/*
================================================================================
TOPIC 23: LINQ - Language Integrated Query (VERY IMPORTANT!)
================================================================================

WHAT IS THIS?
-------------
LINQ (Language Integrated Query) lets you query and manipulate collections
(arrays, lists, dictionaries) in a simple, readable way. Instead of writing
loops, you write queries that look almost like English!

WHY DO WE NEED THIS?
--------------------
- Write less code - one LINQ query replaces multiple loops
- More readable - "Where" and "Select" are self-explanatory
- Powerful - Filter, transform, sort, group data easily
- Consistent - Same syntax works on arrays, lists, databases, XML
- Industry standard - Used in 99% of professional C# code
- You already know Min(), Max(), Sum() - LINQ has 50+ more methods!

WHERE IS THIS USED?
-------------------
- Filtering data: Get users where age > 18
- Transforming data: Convert list of names to uppercase
- Sorting: Order products by price
- Grouping: Group orders by customer
- Database queries (Entity Framework uses LINQ)
- API responses, JSON data processing
- EVERYWHERE in real applications!

CONCEPTS YOU'LL LEARN:
---------------------
1. Where() - Filter elements (like SQL WHERE)
2. Select() - Transform elements (like SQL SELECT)
3. First() / FirstOrDefault() - Get first element
4. Any() / All() - Check conditions
5. OrderBy() / OrderByDescending() - Sort data
6. Count() - Count elements
7. Lambda expressions (n => n > 5)

================================================================================
*/

using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 9, 3, 7, 4, 6 };
            
            // WHERE - Filter elements (like SQL WHERE)
            // Get only numbers greater than 5
            var filtered = numbers.Where(n => n > 5);
            foreach (int num in filtered)
            {
                Console.WriteLine(num);  // 8, 9, 7, 6
            }
            
            // SELECT - Transform elements (like SQL SELECT)
            // Multiply each number by 2
            var doubled = numbers.Select(n => n * 2);
            foreach (int num in doubled)
            {
                Console.WriteLine(num);  // 10, 4, 16, 2, 18, 6, 14, 8, 12
            }
            
            // FIRST - Get first element
            int first = numbers.First();  // 5
            int firstGreaterThan5 = numbers.First(n => n > 5);  // 8
            
            // FIRSTORDEFAULT - Get first or default value if none found
            int firstOrDefault = numbers.FirstOrDefault(n => n > 100);  // 0 (default for int)
            
            // ANY - Check if any element matches condition
            bool hasEven = numbers.Any(n => n % 2 == 0);  // true
            bool hasNegative = numbers.Any(n => n < 0);  // false
            
            // ALL - Check if ALL elements match condition
            bool allPositive = numbers.All(n => n > 0);  // true
            
            // ORDERBY - Sort ascending
            var sortedAsc = numbers.OrderBy(n => n);  // 1, 2, 3, 4, 5, 6, 7, 8, 9
            
            // ORDERBYDESCENDING - Sort descending
            var sortedDesc = numbers.OrderByDescending(n => n);  // 9, 8, 7, 6, 5, 4, 3, 2, 1
            
            // TAKE - Get first N elements
            var firstThree = numbers.Take(3);  // 5, 2, 8
            
            // SKIP - Skip first N elements
            var skipFirstThree = numbers.Skip(3);  // 1, 9, 3, 7, 4, 6
            
            // COUNT - Count elements (with condition)
            int count = numbers.Count();  // 9
            int countGreaterThan5 = numbers.Count(n => n > 5);  // 4
            
            // SUM - Sum of elements
            int sum = numbers.Sum();  // 45
            
            // AVERAGE - Average of elements
            double avg = numbers.Average();  // 5.0
            
            // MIN / MAX - Already know these!
            int min = numbers.Min();  // 1
            int max = numbers.Max();  // 9
        }
    }
}

// Real-World Example: Filtering and Transforming Data
class LINQRealWorld
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25, City = "New York" },
            new Person { Name = "Bob", Age = 30, City = "London" },
            new Person { Name = "Charlie", Age = 35, City = "New York" },
            new Person { Name = "Diana", Age = 28, City = "Paris" }
        };
        
        // Get people from New York
        var nyPeople = people.Where(p => p.City == "New York");
        
        // Get names of people older than 27
        var olderNames = people
            .Where(p => p.Age > 27)
            .Select(p => p.Name);
        
        // Get average age
        double avgAge = people.Average(p => p.Age);  // 29.5
        
        // Get oldest person's name
        string oldestName = people
            .OrderByDescending(p => p.Age)
            .First()
            .Name;  // "Charlie"
        
        // Check if anyone is under 20
        bool hasYoung = people.Any(p => p.Age < 20);  // false
        
        // Get people sorted by age
        var sortedByAge = people.OrderBy(p => p.Age);
    }
}

// Method Syntax vs Query Syntax
// LINQ has two ways to write queries:

class LINQSyntax
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        
        // METHOD SYNTAX (more common, what we've been using)
        var methodResult = numbers
            .Where(n => n > 2)
            .Select(n => n * 2)
            .OrderByDescending(n => n);
        
        // QUERY SYNTAX (looks like SQL)
        var queryResult = from n in numbers
                         where n > 2
                         select n * 2
                         into doubled
                         orderby doubled descending
                         select doubled;
        
        // Both produce the same result! Use method syntax - it's more common.
    }
}

/*
=== TOPIC 23 SUMMARY: LINQ BASICS ===
- LINQ = Language Integrated Query - query collections easily
- WHERE: Filter elements (n => n > 5)
- SELECT: Transform elements (n => n * 2)
- FIRST: Get first element (or First(n => condition))
- ANY: Check if any matches (Any(n => condition))
- ALL: Check if all match (All(n => condition))
- ORDERBY: Sort ascending (OrderBy(n => n))
- ORDERBYDESCENDING: Sort descending
- COUNT: Count elements (Count() or Count(n => condition))
- SUM, AVERAGE, MIN, MAX: Aggregations
- TAKE: First N elements
- SKIP: Skip first N elements
- Remember: Always use "using System.Linq;" at the top!
- Method syntax is more common than query syntax.
*/
