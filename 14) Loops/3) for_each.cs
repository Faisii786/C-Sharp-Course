// ========== TOPIC 14: FOREACH — Refresh: foreach (type item in array) { } ==========
// The foreach Loop
// There is also a foreach loop, which is used exclusively to loop through elements in an array (or other data sets):

// Syntax
// foreach (type variableName in arrayName) 
// {
//   // code block to be executed
// }
// The following example outputs all elements in the cars array, using a foreach loop:

// Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string i in cars) 
{
  Console.WriteLine(i);
}

// Note: Don't worry if you don't understand the example above. You will learn more about Arrays in the C# Arrays chapter.

/*
=== TOPIC 14 SUMMARY (LOOPS): FOREACH ===
- foreach: go through each element in a collection (e.g. array): foreach (type item in array) { ... }.
- Remember: Simpler than for when you don't need the index. Type must match element type (e.g. string for string[]).
*/