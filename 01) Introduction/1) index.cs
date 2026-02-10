/*
================================================================================
TOPIC 1: C# INTRODUCTION
================================================================================

WHAT IS THIS?
-------------
This is your first C# program! Every C# program starts with this basic structure.
You'll learn the essential building blocks: using statements, namespaces, classes,
and the Main method.

WHY DO WE NEED THIS?
--------------------
- This is the foundation of every C# program
- Without this structure, your code won't run
- Understanding this helps you read and write any C# code
- It's like learning the alphabet before writing sentences

WHERE IS THIS USED?
-------------------
- Every C# application (console apps, web apps, games, mobile apps)
- All C# code files start with similar structure
- This pattern appears in 99% of C# projects

CONCEPTS YOU'LL LEARN:
---------------------
1. using System; - Importing namespaces to use built-in classes
2. namespace - Organizing code into logical groups
3. class - Container for code (data and methods)
4. static void Main() - Entry point where program starts
5. Console.WriteLine() - Printing output to screen
6. Semicolons (;) - Every statement ends with semicolon
7. Case sensitivity - C# is case-sensitive!

================================================================================
*/

using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");    
    }
  }
}

// What is C#?
// C# is pronounced "C-Sharp".

// It is an object-oriented programming language created by Microsoft that runs on the .NET Framework.

// C# has roots from the C family, and the language is close to other popular languages like C++ and Java.

// The first version was released in year 2002. The latest version, C# 13, was released in November 2024.

// C# is used for:

// Mobile applications
// Desktop applications
// Web applications
// Web services
// Web sites
// Games
// VR
// Database applications
// And much, much more!
// Why Use C#?
// It is one of the most popular programming languages in the world
// It is easy to learn and simple to use
// It has huge community support
// C# is an object-oriented language which gives a clear structure to programs and allows code to be reused, lowering development costs
// As C# is close to C, C++ and Java, it makes it easy for programmers to switch to C# or vice versa


// Example explained
// Line 1: using System means that we can use classes from the System namespace.

// Line 2: A blank line. C# ignores white space. However, multiple lines makes the code more readable.

// Line 3: namespace is used to organize your code, and it is a container for classes and other namespaces.

// Line 4: The curly braces {} marks the beginning and the end of a block of code.

// Line 5: class is a container for data and methods, which brings functionality to your program. Every line of code that runs in C# must be inside a class. In our example, we named the class Program.

// Don't worry if you don't understand how using System, namespace and class works. Just think of it as something that (almost) always appears in your program, and that you will learn more about them in a later chapter.

// Line 7: Another thing that always appear in a C# program is the Main method. Any code inside its curly brackets {} will be executed. You don't have to understand the keywords before and after Main. You will get to know them bit by bit while reading this tutorial.

// Line 9: Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text. In our example, it will output "Hello World!".

// If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.

// Note: Every C# statement ends with a semicolon ;.

// Note: C# is case-sensitive; "MyClass" and "myclass" have different meaning.

// Note: Unlike Java, the name of the C# file does not have to match the class name, but they often do (for better organization). When saving the file, save it using a proper name and add ".cs" to the end of the filename. To run the example above on your computer, make sure that C# is properly installed: Go to the Get Started Chapter for how to install C#. The output should be:

// Hello World!

/*
=== TOPIC 1 SUMMARY: C# INTRODUCTION ===
- C# is an object-oriented language from Microsoft (pronounced "C-Sharp"), used for apps, games, web, and more.
- A minimal program has: using System; (use System classes), a namespace (organizes code), a class (holds data and methods), and static void Main(string[] args) (entry point).
- Code inside Main runs when the program starts.
- Console.WriteLine("Hello World!"); prints text. Every statement ends with ;. C# is case-sensitive.
- Remember: C# is case-sensitive; "MyClass" and "myclass" are different.
*/