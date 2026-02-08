// ========== TOPIC 10: STRING INTERPOLATION — Refresh: $"{name}" with $ and { } ==========
// String Interpolation
// Another option of string concatenation, is string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces, like with concatenation:

// Example
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);

// Also note that you have to use the dollar sign ($) when using the string interpolation method.

// String interpolation was introduced in C# version 6.

/*
=== TOPIC 10 SUMMARY (STRINGS): INTERPOLATION ===
- $"text {variable} more text" — use $ and { } to embed variables; no need to add spaces manually.
- Remember: Must have $ before the opening quote. You can put any expression inside { } e.g. {x + y}.
*/
