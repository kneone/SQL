//01 Introduction to C# and Data Types

//Understanding Data Types

//Test your Knowledge 

//1.What type would you choose for the following “numbers”? 
//A person’s telephone number: 
//	Srting
//A person’s height:byte
//	Int	
//A person’s age: byte
//	Int	
//A person’s gender (Male, Female, Prefer Not To Answer): 
//	String	
//A person’s salary: double
//	Decimal	
//A book’s ISBN: string

//A book’s price: double

//A book’s shipping weight: double

//A country’s population: uint

//The number of stars in the universe: ulong

//The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business): ushort


//2.What are the differences between value type and reference type variables?

//Value type stored in the stack
//1)	Directly contain their data
//2)	Each has its own copy of data
//3)	Operation on one cannot effect another
//Reference type variables are stored in the heap
//1)  Store references to their data (Known as objects)
//2)  Two reference variable can reference the same object
//3)  Operation on one can effect another

//What is boxing and unboxing?
//Boxing: convert value type to reference type
//Unboxing: convert reference type back to value type 

//3. What is meant by the terms managed resource and unmanaged resource in .NET
//Managed resource: are pure.NET code and managed by the runtime and are under its direct control
//Unmanaged resource:: not pure .NET code File handles, pinned memory, COM objects, database connections etc.

//4.	What’s the purpose of Garbage Collector in .NET?
//The garbage collector manages the allocation and release of memory for an application. For developers working with managed code,
//this means that you don't have to write code to perform memory management tasks.


//Playing with Console App
//Practice number sizes and ranges

//1
Console.WriteLine($"The number of bytes of sbyte is {sizeof(sbyte)}, the minimum value is: {sbyte.MinValue}, the maximun value is:{sbyte.MaxValue}");
Console.WriteLine($"The number of bytes of byte is {sizeof(byte)}, the minimum value is: {byte.MinValue}, the maximun value is:{byte.MaxValue}");
Console.WriteLine($"The number of bytes of short is {sizeof(short)}, the minimum value is: {short.MinValue}, the maximun value is:{short.MaxValue}");
Console.WriteLine($"The number of bytes of ushort is {sizeof(ushort)}, the minimum value is: {ushort.MinValue}, the maximun value is:{ushort.MaxValue}");
Console.WriteLine($"The number of bytes of int is {sizeof(int)}, the minimum value is: {int.MinValue}, the maximun value is:{int.MaxValue}");
Console.WriteLine($"The number of bytes of uint is {sizeof(uint)}, the minimum value is: {uint.MinValue}, the maximun value is:{uint.MaxValue}");
Console.WriteLine($"The number of bytes of long is {sizeof(long)}, the minimum value is: {long.MinValue}, the maximun value is:{long.MaxValue}");
Console.WriteLine($"The number of bytes of ulong is {sizeof(ulong)}, the minimum value is: {ulong.MinValue}, the maximun value is:{ulong.MaxValue}");
Console.WriteLine($"The number of bytes of float is {sizeof(float)}, the minimum value is: {float.MinValue}, the maximun value is:{float.MaxValue}");
Console.WriteLine($"The number of bytes of double is {sizeof(double)}, the minimum value is: {double.MinValue}, the maximun value is:{double.MaxValue}");
Console.WriteLine($"The number of bytes of decimal is {sizeof(decimal)}, the minimum value is: {decimal.MinValue}, the maximun value is:{decimal.MaxValue}");

//2
Console.WriteLine("Enter an integer number:");
int input = Convert.ToUInt16(Console.ReadLine());
int years = input * 100;
int days = (int)(years * 365.2425);
int hours = days * 24;
long minutes = hours * 60;
long seconds = minutes * 60;
long milliseconds = seconds * 1000;
decimal microseconds = milliseconds * 1000;
decimal nanoseconds = microseconds * 1000;
Console.WriteLine($"Input: {input}");
Console.WriteLine($"Output: {input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");



//int a = 10, b = 15;
//int product = a * b++;
//Console.WriteLine(product);
//Console.WriteLine(b);

//Controlling Flow and Converting Types 
//Test your Knowledge

//1.What happens when you divide an int variable by 0?
//DivideByZeroException is thrown 
//Error message: “division by constant zero”

//2.What happens when you divide a double variable by 0?
//The output is infinity.

//3.What happens when you overflow an int variable, that is, set it to a value beyond its range
//OverflowException is thrown

//4.What is the difference between x = y++; and x = ++y;?
//Y++: use first then change 
//++Y: change first then use 

//5.What is the difference between break, continue, and return when used inside a loop statement?

//Break: terminates the loop and transfers execution to the statement immediately following the loop
//Continue: breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop
//Return: exit the current method even if used in a while loop

//6.What are the three parts of a for statement and which of them are required?
//1)The initialization
//2)The condition
//3)The iteration

//7.What is the difference between the = and == operators?
//=: assign value
//==: is an operator, compare the reference identity

//8.Does the following statement compile? for ( ; true; )  
//Yes 

//9.What does the underscore _ represent in a switch expression? 
//Default value

//10.What interface must an object implement to be enumerated over by using the foreach statement ? 
//IEmumerable interface  

//Practice loops and operators

//1
for (int i = 0; i < 100; i++)
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

int max = 500; for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}
It 's an endless loop, since the range of byte is 0-255, and the max is 500



//2
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    for (int j = 0; j < a - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k < 2 * i; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine("");
}


//3

int correctNumber = new Random().Next(3) + 1;
Console.WriteLine(correctNumber);
Console.WriteLine("Enter a number");
int guessedNumber = int.Parse(Console.ReadLine());
if (guessedNumber < 1 || guessedNumber > 3)
{
    Console.WriteLine("Your answer is outside of the range of numbers");
}
else if (guessedNumber > correctNumber)
{
    Console.WriteLine("Your answer is higher");
}
else if (guessedNumber < correctNumber)
{
    Console.WriteLine("Your answer is lower");
}
else if (guessedNumber == correctNumber)
{
    Console.WriteLine("Right answer");
}


//4
String bday = "2000/01/01";
String[] str = bday.Split("/");
int year = Int32.Parse(str[0]);
int month = Int32.Parse(str[1]);
int day = Int32.Parse(str[2]);
int days = 0;
days = days + (2022 - year) * 365;

if (month < 3)
{
    days = days + (3 - month) * 30;
}
else if (month > 3)
{
    days = days - (month - 3) * 30;
}

if (day < 17)
{
    days = days + (17 - day);
}
else
{
    days = days - (day - 17);
}

Console.WriteLine(days);

//5
DateTimeOffset thisDate2 = DateTime.Now;
Console.WriteLine("The current date and time: {0:MM/dd/yy H:mm:ss zzz}",
                   thisDate2);
if (thisDate2.Hour >= 5 && thisDate2.Hour < 12)
{
    Console.WriteLine("Good Morning");
}
else if (thisDate2.Hour >= 12 && thisDate2.Hour < 17)
{
    Console.WriteLine("Good Afternoon");
}
else if (thisDate2.Hour >= 17 && thisDate2.Hour < 22)
{
    Console.WriteLine("Good Evening");
}
else
{
    Console.WriteLine("Good Night");
}

//6

int max = 24;
for (int i = 1; i < 5; i++)
{
    for (int j = 0; j <= max; j++)
    {
        int a = j % i;
        if (a == 0)
        {
            Console.Write(j + ",");
        }

    }
    Console.WriteLine(" ");

}
