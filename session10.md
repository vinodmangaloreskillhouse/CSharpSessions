### *Session 10*
### Static members: 
A non-static class can contain static methods, fields, properties, or events. The static member is callable on a class even when no instance of the class has been created. The static member is always accessed by the class name, not the instance name. Only one copy of a static member exists, regardless of how many instances of the class are created. Static methods and properties cannot access non-static fields and events in their containing type, and they cannot access an instance variable of any object unless it's explicitly passed in a method parameter.

## Partial Class

In C#, you can split the implementation of a `class` in multiple `.cs` files using the `partial` keyword. The compiler will combine all the implementation from multiple `.cs` files when the program is compiled.

# Interfaces

An interface defines a contract. Any `class` that implements that contract must provide an implementation of the members defined in the `interface`.

It is like `abstract` class because all the methods which are declared inside the `interface` are `abstract` methods. It cannot have method body and cannot be instantiated.

It is used to achieve *multiple inheritance* which can't be achieved by class. It is used to achieve *fully abstraction* because it cannot have method body.

<br>

> Naming convention of interface is to prefix the name with I, example Person -> IPerson or Printer -> IPrinter

<br>

In the following example, class `ImplementationClass` must implement a method named `SampleMethod` that has no parameters and returns `void`.

```C#
interface ISampleInterface
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod()
    {
        // Method implementation.
    }

    static void Main()
    {
        // Declare an interface instance.
        ISampleInterface obj = new ImplementationClass();

        // Call the member.
        obj.SampleMethod();
    }
}
```

A class can also implement more than one interfaces, example

```C#
interface IFlyable {
    void Fly();
}

interface ISwimmable {
    void Swim();
}

interface IClimbable {
    void Climb();
}

class Swan : IFlyable, ISwimmable {
    void Fly () {
        // implementation of flying
    }

    void Swim () {
        // implementation of Swimming
    }
}

class ButterFly : IFlyable {
    void Fly () {
        // implementation of flying
    }
}

class Jaguar : IClimbable, ISwimmable {
    void Climb () {
        // implementation of climbing
    }

    void Swim () {
        // implementation of Swimming
    } 
}

static void Main()
{
    IFlyable[] flyables = new { new Swan(), new ButterFly() };
    foreach(IFlyable i in flyables) {
        i.Fly();
    }
}

```

### *End of session 10*

<br>