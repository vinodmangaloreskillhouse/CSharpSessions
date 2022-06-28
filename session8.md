### *Session 8*
## 3. Inheritance

One of the most important concepts in object-oriented programming is inheritance. Inheritance allows us to define a class in terms of another class, which makes it easier to create and maintain an application. This also provides an opportunity to reuse the code functionality and speeds up implementation time.

When creating a class, instead of writing completely new data members and member functions, the programmer can designate that the new class should inherit the members of an existing class. This existing class is called the `base` class, and the new class is referred to as the `derived` class.

The idea of inheritance implements the `IS-A` relationship. For example, mammal IS A animal, dog `IS-A` mammal hence dog `IS-A` animal as well, and so on.

### Base and Derived Classes

The syntax used in C# for creating derived classes is as follows −
```C#
<acess-specifier> class <base_class> {
   ...
}

class <derived_class> : <base_class> {
   ...
}
```

Example:
```C#
using System;

namespace InheritanceApplication {
   class Shape {
      public void setWidth(int w) {
         width = w;
      }
      public void setHeight(int h) {
         height = h;
      }
      protected int width;
      protected int height;
   }

   // Derived class
   class Rectangle: Shape {
      public int getArea() { 
         return (width * height); 
      }
   }

   class RectangleTester {
      static void Main(string[] args) {
         Rectangle Rect = new Rectangle();

         Rect.setWidth(5);
         Rect.setHeight(7);

         // Print the area of the object.
         Console.WriteLine("Total area: {0}",  Rect.getArea());
      }
   }
}
```

<br>

> ### Multiple Inheritance in C#
> **C# does not support multiple inheritance.** However, you can use *interfaces* to implement multiple inheritance, explained in the upcoming concepts.


## Abstract class and Inheritance - explained:

An abstract class is a `class` which must contain at least one `abstract` method. An `abstract` method is a method which is declared using `abstract` keyword and has an empty body. Its definition is defined in the sub classes.

Since `abstract` class is not a complete implementation (since it will have few method declaration but no definition) it is not allowed to create an instance of abstract class.

Consider an example of `Employee` object, where in an organization there could be two types of Employees, `FullTimeEmployee` and `ContractEmployee` where the logic behind calculation of their monthly salary might vary on various policies defined within the organization.

Example:

`FullTimeEmployee.cs`
```C#
public int ID { get; set;}    
public string FirstName { get; set; }    
public string LastName { get; set; }
public string ProjectName { get; set; }   

public int AnnualSalary { get; set; }    
    
public string GetFullName()    
{    
    return this.FirstName + " " + this.LastName;    
}    

public int GetMonthlySalary()    
{    
    return this.AnnualSalary / 12;    
}    
```

`ContractEmployee.cs`
```C#
public int ID { get; set; }    
public string FirstName { get; set; }    
public string LastName { get; set; }
public string ProjectName { get; set; }

public int HourlyPay { get; set; }    
public int TotalHours { get; set; }    


public string GetFullName()    
{    
    return this.FirstName + " " + this.LastName;    
}    

public int GetMonthlySalary()    
{    
    return this.TotalHours * this.HourlyPay;    
}    
```

`Program.cs`
```C#
class Program    
{    
    static void Main(string[] args)    
    {    
        FullTimeEmployee fte = new FullTimeEmployee();    
        {    
            fte.ID = 101;    
            fte.FirstName="Brody";    
            fte.LastName = "Koch";    
            fte.AnnualSalary=60000;    

        };    
        Console.WriteLine(fte.GetFullName());    
        Console.WriteLine(fte.GetMonthlySalary());    
        Console.WriteLine("--------------");    



        ContractEmployee cte = new ContractEmployee();    
        {    
            cte.ID = 101;    
            cte.FirstName = "Dahlia";    
            cte.LastName = "Moreno";  

            cte.HourlyPay = 200;    
            cte.TotalHours = 40;    

        };    
        Console.WriteLine(cte.GetFullName());    
        Console.WriteLine(cte.GetMonthlySalary());    
            
    }    

}    
```

But the above implementation has to repeat most of the logc, lines of statements in both the classes. The only difference we see is that FullTimeEmployee has `AnnualSalary` and ContractEmployee has `HourlyPay` and `TotalHours` properties. 

Introducing a base class called `Employee` to have common logic and properties is the right solution here.

`Employee.cs`

```C#
public int ID { get; set; }    
public string FirstName { get; set; }    
public string LastName { get; set; }    
public string ProjectName { get; set; }

public string GetFullName()    
{    
    return this.FirstName + " " + this.LastName;    
}    

public virtual int GetMonthlySalary() // make the method as virtual so it can be overriden by the sub classes.
{    
    throw new NotImplementedException();
}   
```

`FullTimeEmployee.cs`

```C#
class FullTimeEmployee : Employee // inheritance    
{    
    public int AnnualSalary { get; set; }    
    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.AnnualSalary/12;    
    }    
}   
```

`ContractEmployee.cs`

```C#
class ContractEmployee : Employee // inheritance    
{    
    public int HourlyPay { get; set; }    
    public int TotalHours { get; set; }    

    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.TotalHours * this.HourlyPay;    
    }    
}
```

As you can see the common logic is moved to a base class called `Employee` class and inherited two sub classes `FullTimeEmployee` and `ContractEmployee`.

But the method `GetMonthlySalary` marked as `virtual` and let the sub class `override` the implementation. But this has two drawbacks, 1 with `virtual` it is required to implement something in the body of the method even the logic is not known, 2 It is possible to create an instance of `Employee` class but the implementation is incomplete.

> At this moment `Employee emp = new Employee();` is possible!

We can rewrite the `Employee` base class to not to have the `virtual` method and also make the class and method both as `abstract`.

`Employee.cs`

```C#
public abstract class BaseEmployeeClass   // make class abstract 
{    
    public int ID { get; set; }    
    public string FirstName { get; set; }    
    public string LastName { get; set; }    

    public string GetFullName()    
    {    
        return this.FirstName + " " + LastName;    
    }    

    public abstract int GetMonthlySalary(); // abstract and no method logic
            
}  
```

`FullTimeEmployee.cs`

```C#
class FullTimeEmployee : Employee // inheritance    
{    
    public int AnnualSalary { get; set; }    
    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.AnnualSalary/12;    
    }    
}   
```

`ContractEmployee.cs`

```C#
class ContractEmployee : Employee // inheritance    
{    
    public int HourlyPay { get; set; }    
    public int TotalHours { get; set; }    

    public override int GetMonthlySalary() // overriding the base class method 
    {    
        return this.TotalHours * this.HourlyPay;    
    }    
}
```

`Program.cs`
```C#
class Program    
{    
    static void Main(string[] args)    
    {    
        Employee fte = new FullTimeEmployee();  // Base type Employee can be used  
        {    
            fte.ID = 101;    
            fte.FirstName="Brody";    
            fte.LastName = "Koch";    
            fte.AnnualSalary=60000;    

        };    
        Console.WriteLine(fte.GetFullName());    
        Console.WriteLine(fte.GetMonthlySalary());    
        Console.WriteLine("--------------");    



        Employee cte = new ContractEmployee();  // Base type Employee can be used   
        {    
            cte.ID = 101;    
            cte.FirstName = "Dahlia";    
            cte.LastName = "Moreno";  

            cte.HourlyPay = 200;    
            cte.TotalHours = 40;    

        };    
        Console.WriteLine(cte.GetFullName());    
        Console.WriteLine(cte.GetMonthlySalary()); 

        Employee emp = new Employee(); // Error: Cannot create instance of Abstract class.   
            
    }    

}   
```

As you can see when the child classes inherits any abstract class it enforces the child classes to implement all abstract members of base class. 

In the above example `public override int GetMonthlySalary()` is done in both the child classes otherwise it would give a compile time error.

Also in the `Program.cs` you can see the base type of both the instances of child class is represented as `Employee` class. Also at the end of the same file creating an instance of `Employee` class is not possible as mentioned in the comment.


### *End of session 8*

<br>