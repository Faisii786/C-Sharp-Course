/*
================================================================================
TOPIC 24: DEPENDENCY INJECTION - DI Containers (Advanced)
================================================================================

WHAT IS THIS?
-------------
DI Containers automatically manage dependency injection. Instead of manually
creating and injecting dependencies, the container does it for you. You register
services once, and the container handles the rest.

WHY DO WE NEED THIS?
--------------------
- Automation - Don't manually wire dependencies
- Lifecycle management - Control when objects are created
- Centralized configuration - All dependencies in one place
- Required for: ASP.NET Core, enterprise applications
- Professional standard - Used in all modern frameworks

WHERE IS THIS USED?
-------------------
- ASP.NET Core (built-in DI container)
- Enterprise applications
- Microservices architecture
- Any application with complex dependencies
- Professional C# development

CONCEPTS YOU'LL LEARN:
---------------------
1. ServiceCollection - Register services
2. ServiceProvider - Resolve services
3. Service lifetimes: Singleton, Scoped, Transient
4. Registration patterns - Register interfaces, resolve implementations
5. Dependency resolution - Container creates objects automatically

================================================================================
*/

// DI Containers (Dependency Injection Containers)
// In real applications, you use a DI container to manage dependencies automatically.
// Popular containers: Microsoft.Extensions.DependencyInjection (built-in), Autofac, Ninject

// This example uses Microsoft.Extensions.DependencyInjection (most common)

using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIContainerExample
{
    // Define interfaces
    interface ILogger
    {
        void Log(string message);
    }
    
    interface IEmailService
    {
        void SendEmail(string to, string message);
    }
    
    interface IUserService
    {
        void RegisterUser(string email, string name);
    }
    
    // Implementations
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
    
    class EmailService : IEmailService
    {
        private readonly ILogger _logger;
        
        // DI Container automatically injects ILogger!
        public EmailService(ILogger logger)
        {
            _logger = logger;
        }
        
        public void SendEmail(string to, string message)
        {
            _logger.Log($"Sending email to {to}");
            Console.WriteLine($"Email: {message}");
        }
    }
    
    class UserService : IUserService
    {
        private readonly IEmailService _emailService;
        private readonly ILogger _logger;
        
        // DI Container injects both dependencies!
        public UserService(IEmailService emailService, ILogger logger)
        {
            _emailService = emailService;
            _logger = logger;
        }
        
        public void RegisterUser(string email, string name)
        {
            _logger.Log($"Registering user: {name}");
            _emailService.SendEmail(email, $"Welcome {name}!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create service collection (the container)
            var services = new ServiceCollection();
            
            // Step 2: Register services (tell container what to inject)
            // Singleton: One instance for entire application lifetime
            services.AddSingleton<ILogger, ConsoleLogger>();
            
            // Scoped: One instance per scope (e.g., per HTTP request)
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IUserService, UserService>();
            
            // Transient: New instance every time (default)
            // services.AddTransient<IService, Service>();
            
            // Step 3: Build service provider
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            
            // Step 4: Get service (container creates it with all dependencies!)
            IUserService userService = serviceProvider.GetRequiredService<IUserService>();
            
            // Use it - all dependencies are automatically injected!
            userService.RegisterUser("user@example.com", "Alice");
            
            // Cleanup
            serviceProvider.Dispose();
        }
    }
}

// Service Lifetimes
class ServiceLifetimes
{
    interface IService { }
    class Service : IService { }
    
    static void Example()
    {
        var services = new ServiceCollection();
        
        // SINGLETON - One instance for entire app lifetime
        services.AddSingleton<IService, Service>();
        // Use for: Loggers, Configuration, Caches
        
        // SCOPED - One instance per scope (e.g., per HTTP request)
        services.AddScoped<IService, Service>();
        // Use for: Database contexts, Repositories
        
        // TRANSIENT - New instance every time
        services.AddTransient<IService, Service>();
        // Use for: Lightweight services with no state
    }
}

// Real-World: ASP.NET Core Example (Simplified)
class AspNetCoreExample
{
    // In ASP.NET Core, DI is built-in!
    // In Startup.cs or Program.cs:
    /*
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<ILogger, FileLogger>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
    }
    */
    
    // In a controller:
    /*
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        
        // ASP.NET Core automatically injects IUserService!
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        public IActionResult Register(string email, string name)
        {
            _userService.RegisterUser(email, name);
            return Ok();
        }
    }
    */
}

/*
=== TOPIC 25 SUMMARY: DI CONTAINERS ===
- DI Container manages dependencies automatically
- Microsoft.Extensions.DependencyInjection is most common
- Steps: 1) Create ServiceCollection, 2) Register services, 3) Build ServiceProvider, 4) Get services
- Service Lifetimes:
  - Singleton: One instance for app lifetime
  - Scoped: One instance per scope (e.g., HTTP request)
  - Transient: New instance every time
- Remember: Register interfaces, not concrete classes. Container handles the rest!
- Note: To use Microsoft.Extensions.DependencyInjection, install NuGet package:
  Install-Package Microsoft.Extensions.DependencyInjection
*/
