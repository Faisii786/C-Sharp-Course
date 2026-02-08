// ========== TOPIC 12: TERNARY — Refresh: result = (condition) ? valueTrue : valueFalse; ==========
// Short Hand If...Else (Ternary Operator)
// There is also a short-hand if else, which is known as the ternary operator because it consists of three operands. It can be used to replace multiple lines of code with a single line. It is often used to replace simple if else statements:

// Syntax
// variable = (condition) ? expressionTrue :  expressionFalse;
// Instead of writing:

// Example
// int time = 20;
// if (time < 18) 
// {
//   Console.WriteLine("Good day.");
// } 
// else 
// {
//   Console.WriteLine("Good evening.");
// }

// You can simply write:

// Example
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

/*
=== TOPIC 12 SUMMARY (IF/ELSE): TERNARY ===
- Short-hand: variable = (condition) ? valueIfTrue : valueIfFalse; (e.g. string result = (time < 18) ? "Good day." : "Good evening.";).
- Remember: Use for simple two-way choices. Three parts: condition ? trueValue : falseValue.
*/
