/*
================================================================================
TOPIC 15: BREAK & CONTINUE - Controlling Loop Flow
================================================================================

WHAT IS THIS?
-------------
break exits a loop immediately. continue skips the rest of the current iteration
and goes to the next one. These give you control over loop execution flow.

WHY DO WE NEED THIS?
--------------------
- Early exit - Stop loop when condition met (found item)
- Skip iterations - Skip certain items in loop
- Performance - Exit early when done
- Control flow - Fine-grained control over loops
- Common pattern - Used frequently in real code

WHERE IS THIS USED?
-------------------
- Search loops: break when item found
- Validation: continue when item invalid
- Processing: skip certain items
- Error handling: break on error
- Every loop that needs conditional control!

CONCEPTS YOU'LL LEARN:
---------------------
1. break - Exit loop immediately
2. continue - Skip to next iteration
3. break in switch - Exit switch statement
4. Nested loops - break/continue behavior
5. When to use each

================================================================================
*/

// C# Break
// You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.

// The break statement can also be used to jump out of a loop.

// This example jumps out of the loop when i is equal to 4:

// Example
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    break;
  }
  Console.WriteLine(i);
}

// C# Continue
// The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.

// This example skips the value of 4:

// Example
for (int i = 0; i < 10; i++) 
{
  if (i == 4) 
  {
    continue;
  }
  Console.WriteLine(i);
}

// Break and Continue in While Loop
// You can also use break and continue in while loops:

// Break Example
int i = 0;
while (i < 10) 
{
  Console.WriteLine(i);
  i++;
  if (i == 4) 
  {
    break;
  }
}
 

// Continue Example
int i = 0;
while (i < 10) 
{
  if (i == 4) 
  {
    i++;
    continue;
  }
  Console.WriteLine(i);
  i++;
}

/*
=== TOPIC 15 SUMMARY: BREAK & CONTINUE ===
- break: exit the current loop (or switch) immediately — no more iterations. continue: skip the rest of the current iteration and go to the next one. Both work in for, while, and do-while. In while with continue, still update the loop variable so the loop can end.
- Remember: break = "stop the loop now". continue = "skip to next iteration". In while + continue, increment before continue or you may get infinite loop.
*/

