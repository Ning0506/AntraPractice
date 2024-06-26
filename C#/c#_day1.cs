// 1. What type would you choose for the following “numbers”?

// - A person’s telephone number: `string` (to include characters like hyphens, spaces, or parentheses)
// - A person’s height: `float` or `double` (to handle decimals)
// - A person’s age: `int`
// - A person’s gender: `enum { Male, Female, PreferNotToAnswer }`
// - A person’s salary: `decimal` (for financial calculations)
// - A book’s ISBN: `string` (since it may contain hyphens)
// - A book’s price: `decimal`
// - A book’s shipping weight: `float` or `double`
// - A country’s population: `long` (to handle large numbers)
// - The number of stars in the universe: `ulong` (to handle extremely large numbers)
// - The number of employees in each of the small or medium businesses in the United Kingdom: `int`

// 2. Differences between value type and reference type variables:

// - Value types hold the actual data. Examples include `int`, `float`, `bool`.
// - Reference types hold a reference to the data. Examples include `class`, `interface`, `delegate`.

// Boxing and Unboxing:
// - Boxing is the process of converting a value type to an object type.
// - Unboxing is the process of converting an object type back to a value type.

// 3. Managed resource and unmanaged resource in .NET:

// - Managed resources are those that are managed by the .NET runtime's garbage collector, such as objects created in managed memory.
// - Unmanaged resources are those not managed by the garbage collector, such as file handles, database connections, and COM objects.

// 4. Purpose of Garbage Collector in .NET:

// - The Garbage Collector (GC) in .NET automatically manages memory, freeing up space occupied by objects that are no longer in use to prevent memory leaks.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your favorite color:");
        string color = Console.ReadLine();
        
        Console.WriteLine("Enter your astrology sign:");
        string sign = Console.ReadLine();
        
        Console.WriteLine("Enter your street address number:");
        string streetNumber = Console.ReadLine();
        
        string hackerName = $"{color}{sign}{streetNumber}";
        Console.WriteLine($"Your hacker name is {hackerName}");
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes, Range: {sbyte.MinValue} to {sbyte.MaxValue}");
        Console.WriteLine($"byte: {sizeof(byte)} bytes, Range: {byte.MinValue} to {byte.MaxValue}");
        Console.WriteLine($"short: {sizeof(short)} bytes, Range: {short.MinValue} to {short.MaxValue}");
        Console.WriteLine($"ushort: {sizeof(ushort)} bytes, Range: {ushort.MinValue} to {ushort.MaxValue}");
        Console.WriteLine($"int: {sizeof(int)} bytes, Range: {int.MinValue} to {int.MaxValue}");
        Console.WriteLine($"uint: {sizeof(uint)} bytes, Range: {uint.MinValue} to {uint.MaxValue}");
        Console.WriteLine($"long: {sizeof(long)} bytes, Range: {long.MinValue} to {long.MaxValue}");
        Console.WriteLine($"ulong: {sizeof(ulong)} bytes, Range: {ulong.MinValue} to {ulong.MaxValue}");
        Console.WriteLine($"float: {sizeof(float)} bytes, Range: {float.MinValue} to {float.MaxValue}");
        Console.WriteLine($"double: {sizeof(double)} bytes, Range: {double.MinValue} to {double.MaxValue}");
        Console.WriteLine($"decimal: {sizeof(decimal)} bytes, Range: {decimal.MinValue} to {decimal.MaxValue}");
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number of centuries:");
        int centuries = int.Parse(Console.ReadLine());
        
        int years = centuries * 100;
        int days = (int)(years * 365.24);
        int hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        long milliseconds = seconds * 1000;
        long microseconds = milliseconds * 1000;
        long nanoseconds = microseconds * 1000;
        
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}


// 1. What happens when you divide an int variable by 0?

// - It throws a `System.DivideByZeroException`.

// 2. What happens when you divide a double variable by 0?

// - It results in `Infinity` or `-Infinity` depending on the sign of the numerator.

// 3. What happens when you overflow an int variable?

// - It wraps around to the minimum value if overflow checking is disabled, otherwise it throws an `OverflowException` if checked.

// 4. Difference between `x = y++;` and `x = ++y;`?

// - `x = y++;` assigns the value of `y` to `x` before incrementing `y`.
// - `x = ++y;` increments `y` first and then assigns the new value to `x`.

// 5. Difference between break, continue, and return in a loop?

// - `break` exits the loop.
// - `continue` skips the rest of the current iteration and proceeds to the next iteration.
// - `return` exits the method.

// 6. Three parts of a for statement:

// - Initialization, condition, and iterator. The condition is required.

// 7. Difference between = and == operators?

// - `=` is the assignment operator.
// - `==` is the equality operator.

// 8. Does the following statement compile? `for ( ; true; ) ;`

// - Yes, it compiles and creates an infinite loop.

// 9. What does the underscore `_` represent in a switch expression?

// - It represents the default case.

// 10. What interface must an object implement to be enumerated over by using the foreach statement?

// - `IEnumerable`


using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}


int max = 500;
for (byte i = 0; i < max; i++)
{
    if (i == byte.MaxValue)
    {
        Console.WriteLine("Warning: byte overflow about to happen");
    }
    Console.WriteLine(i);
}


using System;

class Program
{
    static void Main()
    {
        int correctNumber = new Random().Next(1, 4);
        Console.WriteLine("Guess a number between 1 and 3:");
        
        int guessedNumber = int.Parse(Console.ReadLine());
        
        if (guessedNumber < 1 || guessedNumber > 3)
        {
            Console.WriteLine("Your guess is out of range.");
        }
        else if (guessedNumber < correctNumber)
        {
            Console.WriteLine("Too low.");
        }
        else if (guessedNumber > correctNumber)
        {
            Console.WriteLine("Too high.");
        }
        else
        {
            Console.WriteLine("Correct!");
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your birthdate (MM/DD/YYYY):");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        
        int ageInDays = (DateTime.Now - birthDate).Days;
        Console.WriteLine($"You are {ageInDays} days old.");
        
        int daysToNextAnniversary = 10000 - (ageInDays % 10000);
        DateTime nextAnniversary = DateTime.Now.AddDays(daysToNextAnniversary);
        
        Console.WriteLine($"Your next 10,000 day anniversary is on {nextAnniversary.ToShortDateString()}.");
    }
}


using System;

class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        
        if (now.Hour >= 5 && now.Hour < 12)
        {
            Console.WriteLine("Good Morning");
        }
