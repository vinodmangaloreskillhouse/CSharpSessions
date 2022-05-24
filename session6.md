### *Session 6*

# Object Oriented Programming in C#

**Object Oriented Programming** (OOP) is a programming model where programs are organized around objects and data rather than action and logic.

OOP allows decomposition of a problem into a number of entities called objects and then builds data and functions around these objects.

A **class** is the core of any modern Object Oriented Programming language such as C#. 

A class is a blueprint of an object that contains variables for storing data and functions to perform operations on the data.

A class will not occupy any memory space and hence it is only a logical representation of data.

To create a class, you simply use the keyword "class" followed by the class name:
```c#
class Employee
{
    // memebers of the class like private variables, public properties or methods
}
```

The complete syntax to be followed to create a class in C#:
<access specifier> class  class_name {
   // member variables
   <access specifier> <data type> variable1;
   <access specifier> <data type> variable2;
   ...
   <access specifier> <data type> variableN;
   // member methods
   <access specifier> <return type> method1(parameter_list) {
      // method body
   }
   <access specifier> <return type> method2(parameter_list) {
      // method body
   }
   ...
   <access specifier> <return type> methodN(parameter_list) {
      // method body
   }
}

*	Access specifiers (Explained below in Encapsulation) specify the access rules for the members as well as the class itself. If not mentioned, then the default access specifier for a class type is internal. Default access for the members is private.
*	Data type specifies the type of variable, and return type specifies the data type of the data the method returns, if any.
*	To access the class members, you use the dot (.) operator.
*	The dot operator links the name of an object with the name of a member.


Another example of defining a class and creating their instances:

```c#
using System;

namespace BoxApplication {
   class Box {
      public double length;   // Length of a box
      public double breadth;  // Breadth of a box
      public double height;   // Height of a box
   }
   class Boxtester {
      static void Main(string[] args) {
         Box Box1 = new Box();   // Declare Box1 of type Box
         Box Box2 = new Box();   // Declare Box2 of type Box
         double volume = 0.0;    // Store the volume of a box here

         // box 1 specification
         Box1.height = 5.0;
         Box1.length = 6.0;
         Box1.breadth = 7.0;

         // box 2 specification
         Box2.height = 10.0;
         Box2.length = 12.0;
         Box2.breadth = 13.0;
           
         // volume of box 1
         volume = Box1.height * Box1.length * Box1.breadth;
         Console.WriteLine("Volume of Box1 : {0}",  volume);

         // volume of box 2
         volume = Box2.height * Box2.length * Box2.breadth;
         Console.WriteLine("Volume of Box2 : {0}", volume);
         Console.ReadKey();
      }
   }
}
```

**Constructors**: A class constructor is a special member function of a class that is executed whenever we create new objects of that class.

A constructor has exactly the same name as that of class and it does not have any return type. They are used to initialize any members of the class or to do any one time operation by default when the object is being created.

A *default constructor* does not have any parameter but if you need, a constructor can have parameters. Such constructors are called parameterized constructors.

Example:
```c#
using System;

namespace LineApplication {
   class Line {
      private double length;   // Length of a line
      private double weightPixel; // Weight of the line
      
      public Line() { // default constructor
         Console.WriteLine("Object is being created");
      }

      public Line(double l, double w) { // parameterized constructor
          this.length = l;
          this.weightPixel = w;
          Console.WriteLine("Object is being created");
      }
      ...
      ...
      ...
   }
```

## ✅ Tasks:

✅ Represent Two employees with following attributes and behaviour. 

1. Employee named “Thomas” is aged 56 years is working as a Chief Technical Officer in a company named “DataMart”. When some one asks Thomas to Work, he replies with a smile “Hey I am Thomas. I am working! Thank you”. When some one asks him to Stand Up, Thomas would Stand up and say “I am 56 years old. How may I help you?”.

2. Employee named “Pinto” is aged 60 years is working as a Chief Operating Officer in a company named “QMart”. When someone asks Pinto to Work, he replies with a smile “Hey I am Pinto. I am working! Thank you”. When someone asks him to Stand Up, Pinto would Stand up and say “I am 60 years old. How may I help you?”.


### *End of session 6*

<br>
