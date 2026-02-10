// ========== TOPIC 12: ELSE — Refresh: else { ... } when if condition is false ==========
// The else Statement
// Use the else statement to specify a block of code to be executed if the condition is False.

// Syntax
// if (condition)
// {
//   // block of code to be executed if the condition is True
// } 
// else 
// {
//   // block of code to be executed if the condition is False
// }
// Example
int time = 20;
if (time < 18) 
{
  Console.WriteLine("Good day.");
} 
else 
{
  Console.WriteLine("Good evening.");
}
// Outputs "Good evening."

/*
=== TOPIC 12 SUMMARY (IF/ELSE): ELSE ===
- else: run when the same condition is false: else { ... }.
- Remember: No condition after else. Only one of if-block or else-block runs.
*/

// Example explained
// In the example above, time (20) is greater than 18, so the condition is False. Because of this, we move on to the else condition and print to the screen "Good evening". If the time was less than 18, the program would print "Good day".