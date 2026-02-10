/*
================================================================================
TOPIC 25: DEPENDENCY INJECTION (DI) - Key Architecture Pattern
================================================================================

WHAT IS THIS?
-------------
Dependency Injection (DI) means passing dependencies (services, repositories)
into a class from outside, instead of creating them inside the class.
This creates "loose coupling" - classes don't depend on specific implementations.

WHY DO WE NEED THIS?
--------------------
- Testability - Easy to test with mock objects
- Flexibility - Swap implementations without changing code
- Maintainability - Changes in one class don't break others
- Professional standard - Used in all enterprise applications
- Required for: ASP.NET Core, modern frameworks, clean architecture

WHERE IS THIS USED?
-------------------
- ASP.NET Core (built-in DI container)
- Enterprise applications
- Unit testing (inject mock services)
- Microservices architecture
- Any application with multiple layers
- Professional C# development

CONCEPTS YOU'LL LEARN:
---------------------
1. Constructor Injection - Pass dependencies via constructor
2. Interface-based design - Depend on abstractions, not concrete classes
3. Loose coupling - Classes don't create their own dependencies
4. Testability - Easy to test with mock objects
5. Property Injection - Alternative injection method

================================================================================
*/

using System;

namespace DependencyInjectionExample
{
    // WITHOUT Dependency Injection (BAD - Tight Coupling)
    class BadExample
    {
        // Class creates its own dependency - hard to test or change
        private DatabaseConnection db = new DatabaseConnection();
        
        public void SaveData(string data)
        {
            db.Save(data);
        }
    }
    
    // WITH Dependency Injection (GOOD - Loose Coupling)
    
    // Step 1: Define an interface (abstraction)
    interface IDataRepository
    {
        void Save(string data);
        string Load(int id);
    }
    
    // Step 2: Create concrete implementations
    class DatabaseRepository : IDataRepository
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving to database: {data}");
        }
        
        public string Load(int id)
        {
            return $"Data from database: {id}";
        }
    }
    
    class FileRepository : IDataRepository
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving to file: {data}");
        }
        
        public string Load(int id)
        {
            return $"Data from file: {id}";
        }
    }
    
    // Step 3: Inject dependency through constructor
    class GoodExample
    {
        private readonly IDataRepository _repository;
        
        // Dependency is injected (passed in) rather than created inside
        public GoodExample(IDataRepository repository)
        {
            _repository = repository;
        }
        
        public void SaveData(string data)
        {
            _repository.Save(data);
        }
        
        public string GetData(int id)
        {
            return _repository.Load(id);
        }
    }
    
    // Usage
    class Program
    {
        static void Main(string[] args)
        {
            // Can easily switch between implementations!
            IDataRepository dbRepo = new DatabaseRepository();
            IDataRepository fileRepo = new FileRepository();
            
            // Use database
            GoodExample service1 = new GoodExample(dbRepo);
            service1.SaveData("User data");
            
            // Use file (same code, different implementation!)
            GoodExample service2 = new GoodExample(fileRepo);
            service2.SaveData("User data");
        }
    }
}

// Real-World Example: Email Service
namespace EmailServiceExample
{
    interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
    
    class SmtpEmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Sending email via SMTP to {to}: {subject}");
        }
    }
    
    class MockEmailService : IEmailService  // For testing!
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"[TEST] Would send email to {to}: {subject}");
        }
    }
    
    class UserService
    {
        private readonly IEmailService _emailService;
        
        public UserService(IEmailService emailService)
        {
            _emailService = emailService;
        }
        
        public void RegisterUser(string email, string name)
        {
            // Register user logic...
            Console.WriteLine($"Registering user: {name}");
            
            // Send welcome email
            _emailService.SendEmail(email, "Welcome!", $"Hi {name}, welcome!");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Production: Use real email service
            IEmailService emailService = new SmtpEmailService();
            UserService userService = new UserService(emailService);
            userService.RegisterUser("user@example.com", "Alice");
            
            // Testing: Use mock email service (doesn't actually send emails!)
            IEmailService mockEmail = new MockEmailService();
            UserService testService = new UserService(mockEmail);
            testService.RegisterUser("test@example.com", "Test User");
        }
    }
}

// Property Injection (Alternative to Constructor Injection)
class PropertyInjection
{
    interface ILogger
    {
        void Log(string message);
    }
    
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
    
    class Service
    {
        // Property injection (less common, but sometimes useful)
        public ILogger Logger { get; set; }
        
        public void DoWork()
        {
            Logger?.Log("Doing work...");
        }
    }
    
    static void Main(string[] args)
    {
        Service service = new Service();
        service.Logger = new ConsoleLogger();  // Inject via property
        service.DoWork();
    }
}

// Why Use Dependency Injection?
// 1. TESTABILITY - Easy to test with mock objects
// 2. FLEXIBILITY - Easy to swap implementations
// 3. MAINTAINABILITY - Changes in one class don't break others
// 4. LOOSE COUPLING - Classes don't depend on concrete implementations

/*
=== TOPIC 25 SUMMARY: DEPENDENCY INJECTION ===
- DI = Pass dependencies into a class instead of creating them inside
- Steps: 1) Define interface, 2) Create implementations, 3) Inject via constructor
- Constructor Injection: public ClassName(IDependency dep) { _dep = dep; }
- Property Injection: public IDependency Dep { get; set; }
- Benefits: Testability, Flexibility, Maintainability, Loose Coupling
- Remember: Depend on abstractions (interfaces), not concrete classes!
*/
