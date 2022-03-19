//03 Object - Oriented Programming
//Test your knowledge
//1.	What are the six combinations of access modifier keywords and what do they do?
//Public: Access is not restricted
//Private: Access is limited to the contain type
//Protected: Access is limited to the containing class or types derived from the containing class.
//Internal: Access is limited to the current assembly.
//Protected Internal: Access is limited to the current assembly or types derived from the containing class.
//Private Protected: Access is limited to the containing class or types derived from the containing class within the current assembly.

//2.	What is the difference between the static, const, and read only keywords when applied to a type member?
//a)	Static: need a field to be a property of a type, and not a property of an instance of that type
//b)	Const: value will never change
//c)	Read only: unsure of whether the value will change, but don’t want it changed by other classes

//3.	What does a constructor do?
//gets automatically invoked whenever an instance of the class is created

//4.Why is the partial keyword useful
//partial keyword indicates that other parts of the class, struct, or interface can be defined in the namespace

//5.	What is a tuple?
//A tuple is a data structure that contains a sequence of elements of different data types

//6.	What does the C# record keyword do?
//define a reference type that provides built-in functionality for encapsulating data

//7.	What does overloading and overriding mean?
//a)	Overloading: is the ability to have multiple methods within the same class with the same name, but with different parameters
//b)	Overriding: is known as compile-time(or static) polymorphism because each of the different overloaded methods is resolved when the application is compiled

//8.	What is the difference between a field and a property?
//a)	Filed: variable of any type that is declared directly in the class
//b)	property is a member that provides a flexible mechanism to read, write or compute the value of a private field.

//9.	How do you make a method parameter optional?
//Params Keyword

//10.	What is an interface and how is it different from abstract class?
//Interface: is a type definition similar to a class, except that it purely represents a contract between an object and its user
//Difference:
//Interface only allows you to define functionality, not implement it
//Abstract class allows you to create functionality that subclasses can implement or override

//11.What accessibility level are members of an interface?
//    Private by default 

//12.True/False.Polymorphism allows derived classes to provide different implementations of the same method.
//   True

//13.True/False.The override keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
//  True

//14.True/False.The new keyword is used to indicate that a method in a derived class is providing its own implementation of a method.
//   False

//15.True/False.Abstract methods can be used in anormal(non-abstract) class.
//	False

//16.True/False.Normal(non-abstract) methods can be used in an abstract class.
//	True

//17.True/False.Derived classes can override methods that were virtual in the base class.
//	True

//18.True/False.Derived classes can override methods that were abstract in the base class.
//	True

//19.True/False.In a derived class, you can override a method that was neither virtual non abstract in the base class.
//	False

//20.True/False.A class that implements an interface does not have to provide an implementation for all of the members of the interface.
//	False

//21.True/False.A class that implements an interfaces allowed to have other members that aren’t defined in the interface.
//	True

//22.True/False.A class can have more than one base class.
//	False

//23.True/False.A class can implement more than one interface
//    True
