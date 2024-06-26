// **1. What are the six combinations of access modifier keywords and what do they do?**

// 1. **public**: Accessible from any other code.
// 2. **private**: Accessible only within the containing class or struct.
// 3. **protected**: Accessible within the containing class or types derived from the containing class.
// 4. **internal**: Accessible only within the same assembly.
// 5. **protected internal**: Accessible within the same assembly or types derived from the containing class.
// 6. **private protected**: Accessible within the containing class or types derived from the containing class, but only within the same assembly.

// **2. What is the difference between the static, const, and readonly keywords when applied to a type member?**

// - **static**: Indicates that the member belongs to the type itself rather than an instance of the type.
// - **const**: Indicates that the value of the member is constant and cannot be changed. Must be assigned at the time of declaration.
// - **readonly**: Indicates that the member can only be assigned a value at the time of declaration or within a constructor of the same class.

// **3. What does a constructor do?**

// - A constructor initializes an object of a class. It is called when an instance of the class is created.

// **4. Why is the partial keyword useful?**

// - The `partial` keyword allows a class, struct, or interface to be split across multiple files. This can be useful for organizing code, especially in large projects or when using auto-generated code.

// **5. What is a tuple?**

// - A tuple is a data structure that can hold a fixed number of items, each of different types. Tuples are useful for returning multiple values from a method.

// **6. What does the C# record keyword do?**

// - The `record` keyword defines a reference type that provides built-in functionality for encapsulating data. Records are primarily used for creating immutable data objects with value-based equality.

// **7. What does overloading and overriding mean?**

// - **Overloading**: Providing multiple methods with the same name but different parameters within the same class.
// - **Overriding**: Providing a new implementation of a method in a derived class that was defined in a base class.

// **8. What is the difference between a field and a property?**

// - **Field**: A variable that is declared directly in a class or struct.
// - **Property**: A member that provides a flexible mechanism to read, write, or compute the value of a private field.

// **9. How do you make a method parameter optional?**

// - By providing a default value for the parameter. For example: `void MyMethod(int param1, int param2 = 0)`

// **10. What is an interface and how is it different from an abstract class?**

// - An interface defines a contract that implementing classes must fulfill. An abstract class can provide some implementation details.
// - Differences:
//   - Interfaces cannot have any implementation, abstract classes can.
//   - A class can implement multiple interfaces, but can only inherit from one abstract class.

// **11. What accessibility level are members of an interface?**

// - All members of an interface are `public` by default.

// **12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.**

// - True

// **13. True/False. The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.**

// - True

// **14. True/False. The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.**

// - True

// **15. True/False. Abstract methods can be used in a normal (non-abstract) class.**

// - False

// **16. True/False. Normal (non-abstract) methods can be used in an abstract class.**

// - True

// **17. True/False. Derived classes can override methods that were virtual in the base class.**

// - True

// **18. True/False. Derived classes can override methods that were abstract in the base class.**

// - True

// **19. True/False. In a derived class, you can override a method that was neither virtual nor abstract in the base class.**

// - False

// **20. True/False. A class that implements an interface does not have to provide an implementation for all of the members of the interface.**

// - False

// **21. True/False. A class that implements an interface is allowed to have other members that aren’t defined in the interface.**

// - True

// **22. True/False. A class can have more than one base class.**

// - False

// **23. True/False. A class can implement more than one interface.**

// - True


```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10);
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    static void Reverse(int[] numbers)
    {
        int length = numbers.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[length - i - 1];
            numbers[length - i - 1] = temp;
        }
    }

    static void PrintNumbers(int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}


using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
        }
    }

    static int Fibonacci(int n)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}


using System;
using System.Collections.Generic;

public abstract class Person
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    private List<string> addresses = new List<string>();

    public int CalculateAge()
    {
        return DateTime.Now.Year - BirthDate.Year;
    }

    public virtual decimal CalculateSalary()
    {
        return 0;
    }

    public void AddAddress(string address)
    {
        addresses.Add(address);
    }

    public List<string> GetAddresses()
    {
        return addresses;
    }
}


public class Instructor : Person
{
    public string Department { get; set; }
    public bool IsHead { get; set; }
    public DateTime JoinDate { get; set; }

    public override decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - JoinDate.Year;
        return base.CalculateSalary() + (yearsOfExperience * 1000);
    }
}


using System.Collections.Generic;

public class Student : Person
{
    private List<Course> courses = new List<Course>();

    public void EnrollInCourse(Course course)
    {
        courses.Add(course);
    }

    public decimal CalculateGPA()
    {
        // GPA calculation logic here
        return 0;
    }
}


using System.Collections.Generic;

public class Course
{
    public string CourseName { get; set; }
    public List<Student> EnrolledStudents { get; } = new List<Student>();
}


using System;
using System.Collections.Generic;

public class Department
{
    public string DepartmentName { get; set; }
    public Instructor Head { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Course> CoursesOffered { get; } = new List<Course>();
}


public interface IPersonService
{
    int CalculateAge();
    decimal CalculateSalary();
    void AddAddress(string address);
    List<string> GetAddresses();
}

public interface IStudentService : IPersonService
{
    void EnrollInCourse(Course course);
    decimal CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    string Department { get; set; }
    bool IsHead { get; set; }
    DateTime JoinDate { get; set; }
}


using System;

class Program
{
    static void Main()
    {
        Instructor instructor = new Instructor
        {
            Name = "John Doe",
            BirthDate = new DateTime(1980, 1, 1),
            JoinDate = new DateTime(2010, 1, 1),
            Department = "Computer Science",
            IsHead = true
        };

        Student student = new Student
        {
            Name = "Jane Smith",
            BirthDate = new DateTime(2000, 1, 1)
        };

        Course course = new Course { CourseName = "Programming 