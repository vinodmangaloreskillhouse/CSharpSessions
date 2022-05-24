### *Session 4*

## Implicitly typed variable

In C#, variables must be declared with the data type. These are called explicitly typed variables.

Example:
int i = 100;// explicitly typed variable

### Var Keyword
C# 3.0 introduced var keyword to declare method level variables without specifying a data type explicitly.

var j = 100; // implicitly typed local variable

The compiler will infer the type of a variable from the expression on the right side of the = operator. Above, var will be compiled as int.

var can be used to declare any built-in data type or a user-defined type or an anonymous type variable. The following example shows C# compiler infers type based on the value:

**Practice Exercise:**

```c#
static void Main(string[] args)
{
    var i = 10;
    Console.WriteLine("Type of i is {0}", i.GetType());

    var str = "Hello World!!";
    Console.WriteLine("Type of str is {0}", str.GetType());

    var dbl = 100.50d;
    Console.WriteLine("Type of dbl is {0}", dbl.GetType());

    var isValid = true;
    Console.WriteLine("Type of isValid is {0}", isValid.GetType());

    var ano = new { name = "Steve" };
    Console.WriteLine("Type of ano is {0}", ano.GetType());

    var arr = new[] { 1, 10, 20, 30 };
    Console.WriteLine("Type of arr is {0}", arr.GetType());

    var file = new FileInfo("MyFile");
    Console.WriteLine("Type of file is {0}", file.GetType());

}
```

> Note: Implicitly-typed variables must be initialized at the time of declaration; otherwise C# compiler would give an error: Implicitly-typed variables must be initialized.
var i; // Compile-time error: Implicitly-typed variables must be initialized
i = 100;


# C# Operators

Operators are the foundation of any programming language. Operators allow us to perform different kinds of operations on operands, example int x = 5 + 5 OR string greeting = "Hello" + "world".

In C#, operators Can be categorized based upon their different functionality:

Arithmetic operator:
The arithmetic operators perform arithmetic operations on all the numeric type operands such as sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.

<table>
<thead>
<tr>
<th>Operator</th><th>Name</th><th>Description</th><th>Example</th>
</tr>
</thead>
<tbody>
<tr>
<td>+</td><td>Addition</td><td>Computes the sum of left and right operands.</td><td>int x = 5 + 5;</td>
</tr>
<tr>
<td>-</td><td>Substraction</td><td>Subtract the right operand from the left operand</td><td>int x = 5 - 1;</td>
</tr>
<tr>
<td>*</td><td>Multiplication</td><td>Multiply left and right operand.</td><td>int x = 5 * 1;</td>
</tr>
<tr>
<td>/</td><td>Division</td><td>Divides the left operand by the right operand.</td><td>int x = 10 / 2;</td>
</tr>
<tr>
<td>%</td><td>Remainder</td><td>Computes the remainder after dividing its left operand by its right operand.</td><td>int x = 5 % 2;</td>
</tr>
<tr>
<td>++</td><td>Unary increment</td><td>Unary increment ++ operator increases its operand by 1.</td><td>x++;</td>
</tr>
<tr>
<td>--</td><td>Unary decrement</td><td>Unary decrement -- operator decreases its operand by 1.</td><td>x--;</td>
</tr>
<tr>
<td>+</td><td>Unary plus</td><td>Returns the value of operand.</td><td>int five = +5</td>
</tr>
<tr>
<td>-</td><td>	Unary minus</td><td>Computes the numeric negation of its operand.</td><td>int minusFive = -5;</td>
</tr>
</tbody>
</table>

## Relational Operators:
Following table shows all the relational operators supported by C#. Assume variable A holds 10 and variable B holds 20, then −

<table class="demo">
	<thead>
	<tr>
		<th>Operator</th>
		<th>Description</th>
		<th>Example</th>
	</tr>
	</thead>
	<tbody>
	<tr>
		<td>==</td>
		<td>Checks if the values of two operands are equal or not, if yes then condition becomes true.</td>
		<td>(A == B) is not true.</td>
	</tr>
	<tr>
		<td>!=</td>
		<td>Checks if the values of two operands are equal or not, if values are not equal then condition becomes true.</td>
		<td>(A != B) is true.</td>
	</tr>
	<tr>
		<td>&gt;</td>
		<td>Checks if the value of left operand is greater than the value of right operand, if yes then condition becomes true.</td>
		<td>(A &gt; B) is not true.</td>
	</tr>
	<tr>
		<td>&lt;</td>
		<td>Checks if the value of left operand is less than the value of right operand, if yes then condition becomes true.</td>
		<td>(A &lt; B) is true.</td>
	</tr>
	<tr>
		<td>&gt;=</td>
		<td>Checks if the value of left operand is greater than or equal to the value of right operand, if yes then condition becomes true.</td>
		<td>(A &gt;= B) is not true.</td>
	</tr>
	<tr>
		<td>&lt;=</td>
		<td>Checks if the value of left operand is less than or equal to the value of right operand, if yes then condition becomes true.</td>
		<td>(A &lt;= B) is true.</td>
	</tr>
	<tbody>
</table>

## Logical Operators

Following table shows all the logical operators supported by C#. Assume variable A holds Boolean value true and variable B holds Boolean value false, then −

<table>
		<thead>
			<tr>
				<th>Operator<br></th>
				<th>Description</th>
				<th>Example</th>
			</tr>
		</thead>
		<tbody>
			<tr>
				<td>&amp;&amp;</td>
				<td>Called Logical AND operator. If both the operands are non zero then condition becomes true.&</td>
				<td>(A &amp;&amp; B) is false.</td>
			</tr>
			<tr>
				<td>||</td>
				<td>Called Logical OR Operator. If any of the two operands is non zero then condition becomes true.</td>
				<td>(A || B) is true.</td>
			</tr>
			<tr>
				<td>!</td>
				<td>Called Logical NOT Operator. Use to reverses the logical state of its operand. If a condition is true then Logical NOT operator will make false.</td>
				<td>!(A &amp;&amp; B) is true.</td>
			</tr>
		</tbody>
	</table>


## Assignment Operators
C# also supports standard assignment operators like `=`, `+=`, `-=`, `*=`, `/=` and `%=` etc.

**Practice Exercise**

```c#
using System;
namespace SkillHouse {					
	public class Program
	{
		public static void Main()
		{
			int x = 100;
			int y = 200;

			string userChoice = Console.ReadLine('Press 1 for addition, 2 for substraction');

			if (userChoice == "1") { // comparision operator used here ==
				int result = x + y; // assignment and arithmetic operators used here, = and +
			} else {
				int result = x - y; // assignment and arithmetic operator used here.
			}

			bool nightMode = true;
			bool language = 'C#'

			string theme = isNightMode == true && language == 'C#' ? 'C-Sharp-Night-Theme.css' : 'C-Sharp-Normal-Theme.css'; // Logical AND and Conditional operator ? : are used here.
		}
	}
}
```

## ✅ Tasks
✅ Write a C# program to find a given number is Odd or Even. The logic could be to perform % (mod) operation on the given number by 2 and check if the result is zero, ex: i % 2 == 0 is Even number otherwise Odd number.

✅ Write a C# program to perform different arithmetic operation like Add, Subtract, Multiply and Division operation on any two number.

✅ Write a C# program to perform following operations in a Car.

1.  Read the Car Name, Milage, Current Speed at which car is moving, Is it raining? Etc from the user
2. If current speed is equal 60, display a message in console saying “Safe Drive..! Well done”. If current speed is greater than 60 but lesser than 80, display message saying “Be focused please…!”. If the current speed is greater than 80, display “Careful…Slow Down…”. If the speed is lesser than 60, display saying “You can speed up little bit..!”.
If it is raining, display a message saying “Switching on the Wiper” else display “Wiper is switched off”

✅ Create a new Console application in Visual Studio and language as C# and write a program to declare and initialize variables of different data types. Example: Declare variables to represent attributes of an Employee like EmployeeId, FullName, Age, IsMarried, Salary (float / double), Address, PhoneNumber.

<br>

### *End of session 4*

<br>

### [Session 5](./session5.md)