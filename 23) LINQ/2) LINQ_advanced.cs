// ========== TOPIC 23: LINQ — Advanced Operations ==========
// Advanced LINQ operations you'll use frequently

using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            // GROUPBY - Group elements by a key
            string[] words = { "apple", "banana", "apricot", "blueberry", "cherry" };
            var grouped = words.GroupBy(w => w[0]);  // Group by first letter
            foreach (var group in grouped)
            {
                Console.WriteLine($"Words starting with '{group.Key}':");
                foreach (string word in group)
                {
                    Console.WriteLine($"  {word}");
                }
            }
            
            // DISTINCT - Get unique elements
            int[] duplicates = { 1, 2, 2, 3, 3, 3, 4 };
            var unique = duplicates.Distinct();  // 1, 2, 3, 4
            
            // CONCAT - Combine two collections
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            var combined = arr1.Concat(arr2);  // 1, 2, 3, 4, 5, 6
            
            // UNION - Combine and remove duplicates
            int[] set1 = { 1, 2, 3 };
            int[] set2 = { 3, 4, 5 };
            var union = set1.Union(set2);  // 1, 2, 3, 4, 5
            
            // INTERSECT - Get common elements
            var intersect = set1.Intersect(set2);  // 3
            
            // EXCEPT - Get elements in first but not in second
            var except = set1.Except(set2);  // 1, 2
            
            // TOLIST / TOARRAY - Convert to List or Array
            var list = numbers.Where(n => n > 5).ToList();
            var array = numbers.Where(n => n > 5).ToArray();
            
            // TOLOOKUP - Like GroupBy but creates a lookup table
            var lookup = words.ToLookup(w => w.Length);
            var threeLetterWords = lookup[3];  // Get all words with length 3
            
            // AGGREGATE - Custom aggregation
            int[] nums = { 1, 2, 3, 4, 5 };
            int product = nums.Aggregate(1, (acc, n) => acc * n);  // 120 (1*2*3*4*5)
            
            // ZIP - Combine two collections element by element
            int[] numbers = { 1, 2, 3 };
            string[] letters = { "A", "B", "C" };
            var zipped = numbers.Zip(letters, (n, l) => $"{n}{l}");  // "1A", "2B", "3C"
        }
    }
}

// Chaining LINQ Operations
class LINQChaining
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        // Chain multiple operations together
        var result = numbers
            .Where(n => n % 2 == 0)      // Get even numbers: 2, 4, 6, 8, 10
            .Select(n => n * n)          // Square them: 4, 16, 36, 64, 100
            .OrderByDescending(n => n)   // Sort descending: 100, 64, 36, 16, 4
            .Take(3)                     // Take top 3: 100, 64, 36
            .ToList();                   // Convert to List
        
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }
}

// LINQ with Objects
class LINQObjects
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
    
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 999.99m, Category = "Electronics" },
            new Product { Name = "Mouse", Price = 29.99m, Category = "Electronics" },
            new Product { Name = "Desk", Price = 199.99m, Category = "Furniture" },
            new Product { Name = "Chair", Price = 149.99m, Category = "Furniture" }
        };
        
        // Get expensive products (> $100)
        var expensive = products.Where(p => p.Price > 100);
        
        // Get product names only
        var names = products.Select(p => p.Name);
        
        // Group by category
        var byCategory = products.GroupBy(p => p.Category);
        foreach (var group in byCategory)
        {
            Console.WriteLine($"Category: {group.Key}");
            foreach (var product in group)
            {
                Console.WriteLine($"  {product.Name} - ${product.Price}");
            }
        }
        
        // Get total value of all products
        decimal total = products.Sum(p => p.Price);
        
        // Get average price by category
        var avgByCategory = products
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.Price) });
    }
}

/*
=== TOPIC 23 SUMMARY: LINQ ADVANCED ===
- GROUPBY: Group elements by a key
- DISTINCT: Get unique elements
- CONCAT: Combine collections
- UNION: Combine and remove duplicates
- INTERSECT: Get common elements
- EXCEPT: Get elements in first but not second
- TOLIST/TOARRAY: Convert to List or Array
- AGGREGATE: Custom aggregation
- ZIP: Combine two collections element by element
- Chain operations: .Where().Select().OrderBy().Take()
- Remember: LINQ operations are lazy - they don't execute until you iterate or call ToList()/ToArray()
*/
