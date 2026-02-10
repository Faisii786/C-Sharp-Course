/*
================================================================================
TOPIC 20: FILES - Reading and Writing Files
================================================================================

WHAT IS THIS?
-------------
File operations let you read from and write to files on disk. The File class
provides methods to create, read, write, and manage files. Essential for
persisting data between program runs.

WHY DO WE NEED THIS?
--------------------
- Data persistence - Save data to disk, load later
- Configuration - Read settings from files
- Logging - Write logs to files
- Data import/export - Read CSV, JSON, text files
- Required for: Most real-world applications

WHERE IS THIS USED?
-------------------
- Configuration files: appsettings.json, config.txt
- Data storage: Save user data, application state
- Logging: Write error logs, activity logs
- Reports: Generate and save reports
- Data processing: Read input files, write output files

CONCEPTS YOU'LL LEARN:
---------------------
1. File class - System.IO namespace
2. WriteAllText() - Create and write to file
3. ReadAllText() - Read entire file
4. File.Exists() - Check if file exists
5. AppendText() - Add to existing file
6. Delete() - Remove file

================================================================================
*/

// Working With Files
// The File class from the System.IO namespace, allows us to work with files:

Example
using System.IO;  // include the System.IO namespace

File.SomeFileMethod();  // use the file class with methods
// The File class has many useful methods for creating and getting information about files. For example:

// Method	Description
// AppendText()	Appends text at the end of an existing file
// Copy()	Copies a file
// Create()	Creates or overwrites a file
// Delete()	Deletes a file
// Exists()	Tests whether the file exists
// ReadAllText()	Reads the contents of a file
// Replace()	Replaces the contents of a file with the contents of another file
// WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
// For a full list of File methods, go to Microsoft .Net File Class Reference.

// Write To a File and Read It
// In the following example, we use the WriteAllText() method to create a file named "filename.txt" and write some content to it. Then we use the ReadAllText() method to read the contents of the file:

// Example
using System.IO;  // include the System.IO namespace

string writeText = "Hello World!";  // Create a text string
File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
Console.WriteLine(readText);  // Output the content
// The output will be:

// Hello World!
