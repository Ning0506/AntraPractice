// 1. When to use String vs. StringBuilder in C#?

// - **String**: Use `String` when the string value will not change frequently. Strings are immutable, meaning any modification results in a new string creation, which can be inefficient for many manipulations.
// - **StringBuilder**: Use `StringBuilder` for scenarios where you need to modify the string frequently, such as appending, removing, or replacing characters. `StringBuilder` is mutable and more efficient for repeated modifications.

// 2. What is the base class for all arrays in C#?

// - The base class for all arrays in C# is `System.Array`.

// 3. How do you sort an array in C#?

// - You can sort an array using the `Array.Sort()` method. For example: `Array.Sort(array);`

// 4. What property of an array object can be used to get the total number of elements in an array?

// - The `Length` property is used to get the total number of elements in an array. For example: `array.Length`

// 5. Can you store multiple data types in System.Array?

// - No, `System.Array` can only store elements of the same type. To store multiple data types, you can use collections like `ArrayList` or `List<object>`.

// 6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?

// - `Array.CopyTo()`: Copies the elements of the array to another existing array starting at a specified index.
// - `Array.Clone()`: Creates a shallow copy of the array. The result is a new array containing the same elements.


using System;

class Program
{
    static void Main()
    {
        int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] copiedArray = new int[originalArray.Length];
        
        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }
        
        Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
        Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));
    }
}
```


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> list = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
            string input = Console.ReadLine();
            
            if (input.StartsWith("+"))
            {
                list.Add(input.Substring(2));
            }
            else if (input.StartsWith("-"))
            {
                list.Remove(input.Substring(2));
            }
            else if (input == "--")
            {
                list.Clear();
            }
            
            Console.WriteLine("Current List: " + string.Join(", ", list));
        }
    }
}
```


using System;
using System.Collections.Generic;

class Program
{
    static int[] FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                primes.Add(i);
            }
        }
        return primes.ToArray();
    }

    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        int[] primes = FindPrimesInRange(10, 50);
        Console.WriteLine("Primes: " + string.Join(", ", primes));
    }
}
```


using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 2, 4, -1 };
        int k = 2;
        int[] sum = new int[array.Length];
        
        for (int r = 1; r <= k; r++)
        {
            int[] rotated = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                rotated[(i + r) % array.Length] = array[i];
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                sum[i] += rotated[i];
            }
        }
        
        Console.WriteLine("Sum: " + string.Join(", ", sum));
    }
}
```


using System;

class Program
{
    static void Main()
    {
        int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int maxLength = 1;
        int currentLength = 1;
        int element = array[0];
        
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    element = array[i];
                }
            }
            else
            {
                currentLength = 1;
            }
        }
        
        Console.WriteLine("Longest Sequence: " + string.Join(", ", new int[maxLength].Select(_ => element)));
    }
}
```


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        var groups = array.GroupBy(n => n).OrderByDescending(g => g.Count());
        int mostFrequent = groups.First().Key;
        
        Console.WriteLine($"The number {mostFrequent} is the most frequent (occurs {groups.First().Count()} times)");
    }
}
```


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        
        // Using char array
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);
        Console.WriteLine("Reversed string (char array): " + reversedString);
        
        // Using for loop
        string reversedStringLoop = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedStringLoop += input[i];
        }
        Console.WriteLine("Reversed string (for loop): " + reversedStringLoop);
    }
}
```


using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string sentence = "C# is not C++, and PHP is not Delphi!";
        string[] words = Regex.Split(sentence, @"(\W+)");
        Array.Reverse(words);
        string reversedSentence = string.Join("", words);
        Console.WriteLine(reversedSentence);
    }
}
```


using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string text = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
        var words = text.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
        var palindromes = words.Where(word => IsPalindrome(word)).Distinct().OrderBy(word => word);
        Console.WriteLine(string.Join(", ", palindromes));
    }

    static bool IsPalindrome(string word)
    {
        string reversed = new string(word.Reverse().ToArray());
        return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
```


using System;

class Program
{
    static void Main()
    {
        string url = "https://www.apple.com/iphone";
        Uri uri = new Uri(url);
        
        string protocol = uri.Scheme;
        string server = uri.Host;
        string resource = uri.AbsolutePath.TrimStart('/');
        
        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}