/*
================================================================================
TOPIC 24: ASYNC/AWAIT - Asynchronous Programming
================================================================================

WHAT IS THIS?
-------------
async/await allows your program to do other things while waiting for slow
operations (like downloading files, reading databases, API calls). Your program
doesn't freeze - it stays responsive!

WHY DO WE NEED THIS?
--------------------
- Without async: Program freezes while waiting (bad user experience!)
- With async: Program stays responsive, can do other work
- Modern apps MUST be async (web apps, mobile apps, APIs)
- Better performance - handle multiple operations simultaneously
- Required for: File I/O, network calls, database queries, web APIs

WHERE IS THIS USED?
-------------------
- Web applications (ASP.NET Core)
- Mobile apps (Xamarin, MAUI)
- API calls (HTTP requests)
- File operations (reading/writing files)
- Database queries
- Any slow operation that shouldn't block the UI

CONCEPTS YOU'LL LEARN:
---------------------
1. async Task - Method that can run asynchronously
2. await - Wait for async operation to complete
3. Task.Delay() - Simulate slow operations
4. Task.WhenAll() - Wait for multiple tasks
5. Error handling with async
6. Parallel vs sequential execution

================================================================================
*/

using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace AsyncAwaitExample
{
    class Program
    {
        // SYNCHRONOUS (blocking) - Bad for slow operations
        static void SynchronousMethod()
        {
            Console.WriteLine("Starting...");
            // Simulate slow operation (like downloading a file)
            System.Threading.Thread.Sleep(3000);  // Wait 3 seconds
            Console.WriteLine("Finished!");
        }
        
        // ASYNCHRONOUS (non-blocking) - Good for slow operations
        static async Task AsynchronousMethod()
        {
            Console.WriteLine("Starting...");
            // Simulate slow operation WITHOUT blocking
            await Task.Delay(3000);  // Wait 3 seconds asynchronously
            Console.WriteLine("Finished!");
        }
        
        static async Task Main(string[] args)
        {
            // Call async method
            await AsynchronousMethod();
            Console.WriteLine("Program continues while waiting!");
        }
    }
}

// Basic Syntax
class AsyncSyntax
{
    // 1. Method must return Task or Task<T>
    static async Task DoSomethingAsync()
    {
        await Task.Delay(1000);  // Wait 1 second
        Console.WriteLine("Done!");
    }
    
    // 2. If method returns a value, use Task<T>
    static async Task<string> GetNameAsync()
    {
        await Task.Delay(1000);
        return "Alice";
    }
    
    // 3. Call async methods with await
    static async Task Main(string[] args)
    {
        await DoSomethingAsync();
        string name = await GetNameAsync();
        Console.WriteLine(name);  // "Alice"
    }
}

// Real-World Example: Downloading Data
class DownloadExample
{
    static async Task<string> DownloadDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            // This doesn't block - program can do other things while downloading
            string result = await client.GetStringAsync(url);
            return result;
        }
    }
    
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting download...");
        string data = await DownloadDataAsync("https://api.example.com/data");
        Console.WriteLine($"Downloaded {data.Length} characters");
    }
}

// Multiple Async Operations
class MultipleAsync
{
    static async Task<int> GetNumberAsync(int delay)
    {
        await Task.Delay(delay);
        return delay;
    }
    
    static async Task Main(string[] args)
    {
        // Sequential (one after another) - SLOW
        int num1 = await GetNumberAsync(1000);
        int num2 = await GetNumberAsync(1000);
        int num3 = await GetNumberAsync(1000);
        // Total: 3 seconds
        
        // Parallel (at the same time) - FAST
        Task<int> task1 = GetNumberAsync(1000);
        Task<int> task2 = GetNumberAsync(1000);
        Task<int> task3 = GetNumberAsync(1000);
        
        await Task.WhenAll(task1, task2, task3);
        // Total: 1 second (all run simultaneously)
        
        int result1 = await task1;
        int result2 = await task2;
        int result3 = await task3;
    }
}

// Error Handling with Async
class AsyncErrorHandling
{
    static async Task<string> MightFailAsync()
    {
        await Task.Delay(1000);
        throw new Exception("Something went wrong!");
    }
    
    static async Task Main(string[] args)
    {
        try
        {
            string result = await MightFailAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

// Common Async Patterns
class AsyncPatterns
{
    // Pattern 1: Fire and forget (don't wait for result)
    static async Task FireAndForget()
    {
        _ = Task.Run(async () =>
        {
            await Task.Delay(1000);
            Console.WriteLine("Background task completed");
        });
        Console.WriteLine("This runs immediately!");
    }
    
    // Pattern 2: Timeout
    static async Task<string> GetDataWithTimeoutAsync()
    {
        Task<string> downloadTask = DownloadDataAsync("https://api.example.com");
        Task timeoutTask = Task.Delay(5000);  // 5 second timeout
        
        Task completedTask = await Task.WhenAny(downloadTask, timeoutTask);
        
        if (completedTask == timeoutTask)
        {
            throw new TimeoutException("Operation timed out!");
        }
        
        return await downloadTask;
    }
    
    static async Task<string> DownloadDataAsync(string url)
    {
        await Task.Delay(3000);
        return "Data";
    }
}

/*
=== TOPIC 24 SUMMARY: ASYNC/AWAIT ===
- async/await allows non-blocking operations
- Method signature: async Task MethodName() or async Task<T> MethodName()
- Use await before slow operations: await Task.Delay(1000)
- Main method: static async Task Main(string[] args)
- Task.Delay(ms) - Wait asynchronously
- Task.WhenAll() - Wait for multiple tasks in parallel
- Task.WhenAny() - Wait for first task to complete
- Always use try-catch with async methods
- Remember: async methods don't block - other code can run while waiting!
*/
