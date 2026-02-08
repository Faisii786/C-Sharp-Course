// ========== TOPIC 16: LOOP THROUGH ARRAY — Refresh: for with Length; foreach (type x in arr) ==========
// Loop Through an Array
// You can loop through the array elements with the for loop, and use the Length property to specify how many times the loop should run.

// The following example outputs all elements in the cars array:

// Example
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
for (int i = 0; i < cars.Length; i++) 
{
  Console.WriteLine(cars[i]);
}

// The foreach Loop
// There is also a foreach loop, which is used exclusively to loop through elements in an array:

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
 

// The example above can be read like this: for each string element (called i - as in index) in cars, print out the value of i.

// If you compare the for loop and foreach loop, you will see that the foreach method is easier to write, it does not require a counter (using the Length property), and it is more readable.

/*
=== TOPIC 16 SUMMARY (ARRAYS): LOOP THROUGH ===
- for: for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
- foreach: foreach (type item in arr) { ... } — simpler, no index; use when you just need each element.
- Remember: Use for when you need the index (e.g. to change elements). Use foreach for read-only iteration.
*/
