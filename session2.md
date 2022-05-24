### *Session 2*

# C# Fundamentals

### Identifiers

In programming languages, identifiers are used for identification purposes. Or in other words, identifiers are the user-defined name of the program components. In C#, an identifier can be a namespace, class name, method name, variable name or label.
Example:

```c#
public class MyClass1 {
    static public void Main () 
    {
          int x;
    }
}
```

Here the total number of identifiers present in the above example is 3 and the names of these identifiers are:
`MyClass1`: Name of the class, `Main`: Method name, `x`: Variable name

**Rules for defining identifiers in C#**: There are certain valid rules for defining a valid C# identifier. These rules should be followed, otherwise, we will get a *compile-time* error.

Observe all identifiers used in the below program:
// Simple C# program to illustrate identifiers

```c#
using System;
namespace SkillHouse // a namespace identified with the given name 'SkillHouse'
{
    class CSharpLearning { // a class identified with the given name 'CSharpLearning'
    
        // Main Method
        static public void Main() // a method identified with the given name 'Main'
        {
    
            // variable
            int a = 10; // this variable will be identified with the name 'a' in the entire program
            int b = 39; // this variable will be identified with the name 'b' in the entire program
            int c; // this variable will be identified with the name 'c' in the entire program
    
            // simple addition
            c = a + b;
            Console.WriteLine("The sum of two number is: {0}", c);
        }
    }
}
```

## Variables

A variable contains a data value of the specific *data type*.

Variables are used to store information to be referenced and manipulated in a computer program.

They also provide a way of labelling data with a descriptive name, so our programs can be understood more clearly by the reader and ourselves.

It is helpful to think of variables as containers that hold information. Their sole purpose is to label and store data in memory. This data can then be used throughout your program.

Syntax:
`type variable_name = value; `
or
`type variable_names;`
Example:
`char var = 'h'; // Declaring and Initializing character variable`
`int a, b, c; // Declaring variables a, b and c of int type`


Rules for naming variables:

*	Variable names can contain the letters ‘a-z’ or ’A-Z’ or digits 0-9 as well as the character ‘_’.
*	The name of the variables cannot be started with a digit.
*	The name of the variable cannot be any C# keyword say int, float, null, String, etc unless you use @ symbol as the prefix.

Valid Variables Names
int age;

float _studentname;

object dimension3

char @char = 'A'; // keyword used but valid because prefixed with @


Invalid Variables Names
int if; // "if" is a keyword

object 3dObject; // Cannot start with digit

## Initialization

The term initializing means to assign some value to the variable. Basically, the actual use of variables comes under the initialization part. In C# each data type has some default value which is used when there is no explicitly set value for a given variable. Initialization can be done separately or may be with declaration.

Example:
int y = 7; // Declaring and initializing the variable at same time
int x; // Declaring variable x
x = 5; // initializing x with value 5, late initialization


Two Ways for Initialization:

## 1 Compile time initialization

It means to provide the value to the variable during the compilation of the program. If the programmer didn’t provide any value then the compiler will provide some default value to the variables in some cases. Generally, this type of initialization helpful when the programmer wants to provide some default value.

int x = 32;              
// printing the value
Console.WriteLine("Value of x is "+x);

## 2 Run time initialization

In this, the user has to enter the value and that value is copied to the required variable. In this type of initialization, there is one more possibility in which value is assigned to variable after completion of a function call.

int num = Convert.ToInt32(Console.ReadLine()); // reading from user input
  
// printing the result
Console.WriteLine("Value of num is " + num);

float result = calculateArea(100, 200); // result is now known after completion of calculateArea function call.
// printing the result
Console.WriteLine("Value of result is " + result);

## ✅ Tasks
✅ Create a console project and perform following operations
1.  Read the following sentence and declare necessary variables of respective types for underlined words.
“A car named “i20” made by the company named “Hyundai” runs at the maximum speed of 120 km/hr. It has got 4 wheels. Mileage given by the car is 12.5 kms/litre. System asks the user to input the number of Kilometres that user wants to drive and collects the information. Based on what user entered and current mileage, system calculates the number of litres (Fuel) required to make the journey”

✅ Identify the identifiers in the following example. Copy following code into your new project and insert the comments appropriately above the statement if it is an identifier. If it is a variable specify the same.

```c#
using System;
namespace SkillHouse 
{
    class CSharpLearning {
    
        // Main Method
        static public void Main()
        {
    
            int a = 10;
            int b = 39;
            int c;
    
            // simple addition
            c = a + b;
            Console.WriteLine("The sum of two number is: {0}", c);
        }
    }
}
```

### *End of session 2*

<br>

### [Session 3](./session3.md)