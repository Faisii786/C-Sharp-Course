/*
================================================================================
TOPIC 30: DATETIME - Working with Dates and Times
================================================================================

WHAT IS THIS?
-------------
DateTime represents a specific date and time. It's used for storing dates,
calculating differences, formatting dates for display, and handling time-based
operations. Very common in real applications!

WHY DO WE NEED THIS?
--------------------
- Store dates - Birthdays, order dates, deadlines
- Calculate time - Age, duration, time until event
- Format dates - Display dates in user-friendly format
- Schedule tasks - When to run jobs, reminders
- Logging - Timestamp events
- Business logic - Expiry dates, subscriptions

WHERE IS THIS USED?
-------------------
- User registration (birthday, account creation date)
- E-commerce (order dates, delivery dates)
- Scheduling applications (appointments, meetings)
- Logging and auditing (when did something happen)
- Financial applications (transaction dates)
- Any application that deals with time

CONCEPTS YOU'LL LEARN:
---------------------
1. DateTime.Now - Current date and time
2. DateTime.Today - Today at midnight
3. Creating dates: new DateTime(year, month, day)
4. Formatting: ToString("yyyy-MM-dd")
5. Adding time: AddDays(), AddMonths(), AddYears()
6. TimeSpan - Duration between dates
7. Comparing dates: >, <, ==

================================================================================
*/

using System;

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create DateTime
            DateTime now = DateTime.Now;  // Current date and time
            DateTime today = DateTime.Today;  // Today at midnight (00:00:00)
            DateTime utcNow = DateTime.UtcNow;  // Current UTC time
            
            // Create specific date
            DateTime birthday = new DateTime(1990, 5, 15);  // Year, Month, Day
            DateTime specific = new DateTime(2024, 12, 25, 14, 30, 0);  // With time
            
            // Parse from string
            DateTime parsed = DateTime.Parse("2024-12-25");
            DateTime.TryParse("2024-12-25", out DateTime safeParsed);
            
            // Format DateTime to string
            string formatted = now.ToString("yyyy-MM-dd");  // 2024-12-25
            string formatted2 = now.ToString("MM/dd/yyyy");  // 12/25/2024
            string formatted3 = now.ToString("dddd, MMMM dd, yyyy");  // Wednesday, December 25, 2024
            
            // Common format strings:
            // yyyy = year (4 digits)
            // MM = month (2 digits)
            // dd = day (2 digits)
            // HH = hour (24-hour)
            // mm = minutes
            // ss = seconds
        }
    }
}

// DateTime Properties
class DateTimeProperties
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2024, 12, 25, 14, 30, 45);
        
        // Date components
        int year = dt.Year;      // 2024
        int month = dt.Month;    // 12
        int day = dt.Day;        // 25
        
        // Time components
        int hour = dt.Hour;      // 14
        int minute = dt.Minute;   // 30
        int second = dt.Second;   // 45
        
        // Day of week
        DayOfWeek dayOfWeek = dt.DayOfWeek;  // Wednesday
        int dayOfYear = dt.DayOfYear;  // 360 (365th day of year)
        
        // Date only (no time)
        DateTime dateOnly = dt.Date;  // 2024-12-25 00:00:00
    }
}

// DateTime Operations
class DateTimeOperations
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        
        // Add time
        DateTime tomorrow = now.AddDays(1);
        DateTime nextWeek = now.AddDays(7);
        DateTime nextMonth = now.AddMonths(1);
        DateTime nextYear = now.AddYears(1);
        
        DateTime in2Hours = now.AddHours(2);
        DateTime in30Minutes = now.AddMinutes(30);
        
        // Subtract time
        DateTime yesterday = now.AddDays(-1);
        DateTime lastWeek = now.AddDays(-7);
        
        // Calculate difference
        DateTime start = new DateTime(2024, 1, 1);
        DateTime end = new DateTime(2024, 12, 31);
        TimeSpan difference = end - start;  // 365 days
        int days = difference.Days;
        
        // Compare dates
        bool isAfter = end > start;  // true
        bool isBefore = start < end;  // true
        bool isEqual = start == start;  // true
    }
}

// TimeSpan
class TimeSpanExample
{
    static void Main(string[] args)
    {
        // TimeSpan represents a duration (time interval)
        TimeSpan duration = new TimeSpan(2, 30, 0);  // 2 hours, 30 minutes, 0 seconds
        
        // Create TimeSpan
        TimeSpan oneDay = TimeSpan.FromDays(1);
        TimeSpan twoHours = TimeSpan.FromHours(2);
        TimeSpan thirtyMinutes = TimeSpan.FromMinutes(30);
        TimeSpan fiveSeconds = TimeSpan.FromSeconds(5);
        
        // TimeSpan properties
        int days = duration.Days;
        int hours = duration.Hours;
        int minutes = duration.Minutes;
        int seconds = duration.Seconds;
        double totalHours = duration.TotalHours;  // 2.5
        double totalMinutes = duration.TotalMinutes;  // 150
        
        // Add/subtract TimeSpan
        DateTime now = DateTime.Now;
        DateTime later = now + TimeSpan.FromHours(2);
        DateTime earlier = now - TimeSpan.FromDays(1);
    }
}

// Real-World Examples
class RealWorldExamples
{
    static void Main(string[] args)
    {
        // Calculate age
        DateTime birthDate = new DateTime(1990, 5, 15);
        int age = CalculateAge(birthDate);
        Console.WriteLine($"Age: {age}");
        
        // Check if date is in range
        DateTime startDate = new DateTime(2024, 1, 1);
        DateTime endDate = new DateTime(2024, 12, 31);
        DateTime checkDate = DateTime.Now;
        bool inRange = checkDate >= startDate && checkDate <= endDate;
        
        // Format for display
        DateTime eventDate = new DateTime(2024, 12, 25, 18, 0, 0);
        string display = eventDate.ToString("MMMM dd, yyyy 'at' h:mm tt");
        // "December 25, 2024 at 6:00 PM"
        
        // Get start/end of period
        DateTime today = DateTime.Today;
        DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
        DateTime endOfWeek = startOfWeek.AddDays(6);
    }
    
    static int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age)) age--;
        return age;
    }
}

// Common DateTime Format Strings
class DateTimeFormats
{
    static void Main(string[] args)
    {
        DateTime dt = new DateTime(2024, 12, 25, 14, 30, 45);
        
        // Common formats
        Console.WriteLine(dt.ToString("yyyy-MM-dd"));           // 2024-12-25
        Console.WriteLine(dt.ToString("MM/dd/yyyy"));           // 12/25/2024
        Console.WriteLine(dt.ToString("dd-MM-yyyy"));           // 25-12-2024
        Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss"));  // 2024-12-25 14:30:45
        Console.WriteLine(dt.ToString("dddd, MMMM dd, yyyy"));  // Wednesday, December 25, 2024
        Console.WriteLine(dt.ToString("MMM dd, yyyy"));         // Dec 25, 2024
        Console.WriteLine(dt.ToString("hh:mm tt"));            // 02:30 PM
    }
}

/*
=== TOPIC 30 SUMMARY: DATETIME ===
- DateTime represents a specific date and time
- DateTime.Now = current date/time, DateTime.Today = today at midnight
- Create: new DateTime(year, month, day) or new DateTime(year, month, day, hour, minute, second)
- Format: dt.ToString("yyyy-MM-dd") - use format strings
- Add time: dt.AddDays(1), dt.AddHours(2), dt.AddMonths(1)
- Subtract: dt.AddDays(-1) or use subtraction operator
- Difference: TimeSpan diff = end - start
- TimeSpan = duration/interval (TimeSpan.FromDays(1), TimeSpan.FromHours(2))
- Common formats: "yyyy-MM-dd", "MM/dd/yyyy", "dddd, MMMM dd, yyyy"
- Remember: DateTime is immutable - operations return new DateTime, don't modify original!
*/
