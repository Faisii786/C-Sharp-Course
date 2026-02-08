// ========== TOPIC 2: OUTPUT — Refresh: WriteLine = print + new line; Write = print, no new line ==========

Console.WriteLine("Hello World!");

// C# Output
// To output values or print text in C#, you can use the WriteLine() method:

// Example
Console.WriteLine("Hello World!");

// You can add as many WriteLine() methods as you want. Note that it will add a new line for each method:

// Example
Console.WriteLine("Hello World!");
Console.WriteLine("I am Learning C#");
Console.WriteLine("It is awesome!");

// You can also output numbers, and perform mathematical calculations:

// Example
Console.WriteLine(3 + 3);

// The Write Method
// There is also a Write() method, which is similar to WriteLine().

// The only difference is that it does not insert a new line at the end of the output:

// Example
Console.Write("Hello World! ");
Console.Write("I will print on the same line.");

// Note that we add an extra space when needed (after "Hello World!" in the example above), for better readability.

/*
=== TOPIC 2 SUMMARY: OUTPUT ===
- Console.WriteLine(...) prints and adds a new line. You can call it many times; each call prints on a new line.
- It can print text or numbers (e.g. Console.WriteLine(3 + 3);).
- Console.Write(...) prints without a new line, so the next output continues on the same line.
- Remember: Add a space in the string after Write() if you want a space before the next output.
*/
