// Default Parameter Value
// You can also use a default parameter value, by using the equals sign (=).

// If we call the method without an argument, it uses the default value ("Norway"):

// Example
static void MyMethod(string country = "Norway")
{
    Console.WriteLine(country);
}

static void Main(string[] args)
{
    MyMethod("Sweden");
    MyMethod("India");
    MyMethod();
    MyMethod("USA");
}

// Sweden
// India
// Norway
// USA



// A parameter with a default value, is often known as an "optional parameter". From the example above, country is an optional parameter and "Norway" is the default value.