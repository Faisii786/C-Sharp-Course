/*
================================================================================
TOPIC 32: USING STATEMENTS - Resource Management
================================================================================

WHAT IS THIS?
-------------
The 'using' statement ensures resources (files, database connections, network
streams) are properly disposed/closed when done. It automatically calls Dispose()
even if an exception occurs, preventing memory leaks and resource issues.

WHY DO WE NEED THIS?
--------------------
- Prevent memory leaks - Resources are always freed
- Automatic cleanup - Don't need to remember to close files
- Exception safety - Resources closed even if error occurs
- Best practice - Required for file/database operations
- Professional code - Always use for IDisposable resources

WHERE IS THIS USED?
-------------------
- File operations: StreamReader, StreamWriter
- Database connections: SqlConnection, DbContext
- Network resources: HttpClient, WebClient
- Any class that implements IDisposable
- Critical for: File I/O, database access, network calls

CONCEPTS YOU'LL LEARN:
---------------------
1. using statement - Automatic disposal
2. IDisposable interface - Resources that need cleanup
3. Modern syntax: using var resource = ...
4. Multiple using statements
5. When to use using

================================================================================
*/

using System;
using System.IO;

namespace UsingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // WITHOUT using (BAD - might leak resources)
            StreamWriter writer1 = new StreamWriter("file.txt");
            writer1.WriteLine("Hello");
            // What if an exception occurs here? File might not close!
            writer1.Close();  // Must remember to close manually
            
            // WITH using (GOOD - automatically disposes)
            using (StreamWriter writer2 = new StreamWriter("file.txt"))
            {
                writer2.WriteLine("Hello");
                // Automatically calls Dispose() even if exception occurs!
            }  // File is automatically closed here
            
            // Modern C# syntax (preferred)
            using var writer3 = new StreamWriter("file.txt");
            writer3.WriteLine("Hello");
            // Automatically disposed when variable goes out of scope
        }
    }
}

// How using Works
class HowUsingWorks
{
    static void Main(string[] args)
    {
        // This code:
        using (var resource = new SomeResource())
        {
            resource.DoSomething();
        }
        
        // Is equivalent to:
        var resource2 = new SomeResource();
        try
        {
            resource2.DoSomething();
        }
        finally
        {
            resource2?.Dispose();  // Always called, even on exception
        }
    }
}

// IDisposable Interface
class IDisposableExample
{
    // Classes that use resources should implement IDisposable
    class FileHandler : IDisposable
    {
        private StreamWriter _writer;
        
        public FileHandler(string filename)
        {
            _writer = new StreamWriter(filename);
        }
        
        public void Write(string text)
        {
            _writer.WriteLine(text);
        }
        
        // Dispose method - called automatically by using
        public void Dispose()
        {
            _writer?.Close();
            _writer?.Dispose();
            Console.WriteLine("File closed and disposed!");
        }
    }
    
    static void Main(string[] args)
    {
        // using automatically calls Dispose()
        using (var handler = new FileHandler("data.txt"))
        {
            handler.Write("Line 1");
            handler.Write("Line 2");
        }  // Dispose() called here automatically
        
        // Or with modern syntax
        using var handler2 = new FileHandler("data2.txt");
        handler2.Write("Line 1");
        // Dispose() called when handler2 goes out of scope
    }
}

// Common Types That Use using
class CommonUsingTypes
{
    static void Main(string[] args)
    {
        // File operations
        using var reader = new StreamReader("file.txt");
        string content = reader.ReadToEnd();
        
        using var writer = new StreamWriter("output.txt");
        writer.WriteLine("Hello");
        
        // Database connections (simplified)
        // using var connection = new SqlConnection(connectionString);
        // connection.Open();
        // ... use connection
        
        // HTTP clients
        // using var client = new HttpClient();
        // var response = await client.GetAsync("https://api.example.com");
    }
}

// Multiple using Statements
class MultipleUsing
{
    static void Main(string[] args)
    {
        // Multiple resources
        using (var reader = new StreamReader("input.txt"))
        using (var writer = new StreamWriter("output.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToUpper());
            }
        }  // Both disposed automatically
        
        // Or nested
        using (var reader = new StreamReader("input.txt"))
        {
            using (var writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine(reader.ReadToEnd());
            }  // writer disposed
        }  // reader disposed
    }
}

// When to Use using
class WhenToUseUsing
{
    static void Main(string[] args)
    {
        // ✅ USE using for:
        // - File operations (StreamReader, StreamWriter)
        // - Database connections
        // - Network resources (HttpClient)
        // - Any class that implements IDisposable
        
        // ❌ DON'T use using for:
        // - Regular objects that don't use resources
        // - Objects you need to keep alive
        
        // Example: Don't use using for regular objects
        var person = new Person { Name = "Alice" };
        // using var person = ...  // Not needed - Person doesn't use resources
    }
}

// Real-World Example
class RealWorldExample
{
    static void ReadAndProcessFile(string filename)
    {
        // File is automatically closed even if exception occurs
        using var reader = new StreamReader(filename);
        
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            ProcessLine(line);
        }
        
        // reader.Dispose() called automatically here
    }
    
    static void ProcessLine(string line)
    {
        Console.WriteLine($"Processing: {line}");
    }
}

/*
=== TOPIC 32 SUMMARY: USING STATEMENTS ===
- using ensures resources are properly disposed (closed, freed)
- Syntax: using (var resource = new Resource()) { ... }
- Modern syntax: using var resource = new Resource();
- Automatically calls Dispose() even if exception occurs
- Use for: Files, database connections, network resources, any IDisposable
- Prevents memory leaks and resource issues
- Remember: using = automatic cleanup, always use for file/database operations!
*/
