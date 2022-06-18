### *Session 11*

# Collectons in C#

C# collection types are designed to store, manage and manipulate collection of similar data more efficiently. Data manipulation includes adding, removing, finding, and inserting data in the collection. Collection types implement the following common functionality: 

* Adding and inserting items to a collection
* Removing items from a collection
* Finding, sorting, searching items
* Replacing items
* Copy and clone collections and items
* Capacity and Count properties to find the capacity of the collection and number of items in the collection

One of the most commonly used collection in C# is `List`.

## List
List is a collection which allows us to add items dynamically and the capacity of the collection grows as it is added. Unlike arrays where their size must be known in prior, the List can be declared and added items later as needed. The type of this collection can be passed within the symbol `< >`.

<br>

> You must import the namespace to use List in the program, `using System.Collections.Generic;`

<br>

Example:
```C#
List<int> myList = new List<int>(); // this list is defined to contain only values of type integers.
myList.Add(100);
myList.Add(200);
myList.Add(300);
myList.Add(400);

myList.Add("A String!?"); // Gives an error for this.
```

#### Looping through the collection

We can iterate through collection using index based for loop or we can use `foreach`.

Example:

```C#
for (var index = 0; index < myList.Count; index++) // using Count
{
    Console.Write(myList[index] + " "); // access using index (like array)
}

OR

foreach (var value in myList)
{
    Console.Write(value + " ");
}
```

We can use the `List` to contain collection of classes as well, example:

```C#
List<Shape> allShapes = new List<Shape>();
allShapes.Add(new Shape());
allShapes.Add(new Rectangle()); // assume Rectangle is derived from Shape class
allShapes.Add(new Triangle()); // assume Triangle is derived from Shape class
```

We can perform the same `foreach` loop for the above `allShapes` List too.

## Dictionary

Dictionary is also a Generic List which is used commonly in many cases. As the name implies it is used to store collection of dictionary values with the combination of `key` and `value`. A `key` must be unique and we can use the key to quick find the value easily.

Example:
```C#
Dictionary<int, string> dct = new Dictionary<string, Shape>();
dct.Add("circle", new Circle());
dct.Add("square", new Square());
dct.Add("rectangle", new Rectangle());
dct.Add("triangle", new Triangle());

foreach (KeyValuePair<int, string> kvp in dct)
{
    Response.Write(kvp.Key + " " + kvp.Value); // .Key will get the key, .Value will retrieve the value
}

Triangle myTriangle = dct["triangle"];
```


### *End of session 11*

<br>