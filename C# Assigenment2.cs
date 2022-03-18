
// 02  Arrays and Strings

//Test your Knowledge
//1.When to use String vs. StringBuilder in C# ?
//String：If a string is going to remain constant throughout the program
//StringBuilder：If a string can change

//2.What is the base class for all arrays in C#?
//array class

//3.How do you sort an array in C#?
//Array.Sort(arr);
//Array.Sort(arr, StringComparer.InvariantCulture);


//4.What property of an array object can be used to get the total number of elements in an array?
// length property

//5.Can you store multiple data types in System.Array?
//yes

//6.What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
//System.Array.CopyTo(): copy the elements in to another existing array
//System.Array.Clone(): create a new array contain all the elements


//Practice Arrays
//1Copying an Array

int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] arr2 = new int[arr1.Length];

for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = arr1[i];
}

Console.WriteLine("The first array is ");
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(+arr1[i] + ",");

}
Console.WriteLine();
Console.WriteLine("The second array is");
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + ",");
}

//2
var grocery = new List<string>();
grocery.Add("Rice");
grocery.Add("Chicken");
grocery.Add("Eggs");
grocery.Add("Milk");
Console.WriteLine("Here is the list");
for (int i = 0; i < grocery.Count; i++)
{
    Console.Write(grocery[i]);
    Console.WriteLine();
}
Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
string input = Console.ReadLine();
if (input == "--")
{
    grocery.Clear();
}
for (int i = 0; i < grocery.Count; i++)

{
    Console.Write(grocery[i]);
    Console.WriteLine();
}

var cities = new List<string>();
cities.Add("New York");
cities.Add("London");
cities.Add("Mumbai");
cities.Add("Chicago");
for (int i = 0; i < cities.Count; i++)
{
    Console.Write(cities[i] + ",");
}


//3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int startNum = 0;
            int endNum = 0;

            Console.WriteLine("Enter first number.");
            startNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number.");
            endNum = int.Parse(Console.ReadLine());

            var output = FindPrimesInRange(startNum, endNum);

        }
        static int[] FindPrimesInRange(int startNum, int endNum)
        {

            int[] arr = new int[0];
            int[] result = new int[arr.Length * 2];
            int count = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        // Console.WriteLine("j is: " + j);
                        //Console.WriteLine("i is: " + i);
                        //Console.WriteLine("count is: " +count);
                    }

                }
                // Console.WriteLine("count outside is: " + count);
                if (count == 2)
                {
                    //Console.WriteLine("in?");
                    //for (int k = 0; k < arr.Length; k++)
                    //{
                    //    result[k] = arr[k];
                    //}
                    //result[arr.Length + 1] = i;
                    arr = arr.Concat(new[] { i }).ToArray();
                }

            }
            //Console.WriteLine("starNum is: " + startNum);
            //Console.WriteLine("endNum is: " + endNum);
            Console.WriteLine("The primce numbers between " + startNum + " and " + endNum + " ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;
        }

    }
}


//4
int[] arr = new int[] { 3, 2, 4, -1 };

int[] arr = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();
int times = int.Parse(Console.ReadLine());
Console.Write("Input is :");
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + "  ");
}
Console.WriteLine();


int[] temp = new int[arr.Length];

for (int i = 0; i < arr.Length; i++)
{
    temp[i] = arr[i];
}


int[] result = new int[arr.Length];
for (int i = 1; i <= times; i++)
{

    int last = arr[arr.Length - 1];

    for (int j = arr.Length - 1; j > 0; j--)
    {
        arr[j] = arr[j - 1];
    }
    arr[0] = last;

    Console.Write("rotated" + i + "[] = ");
    for (int a = 0; a < arr.Length; a++)
    {
        Console.Write(arr[a] + "  ");
    }
    Console.WriteLine();


    for (int k = 0; k < arr.Length; k++)
    {
        result[k] = result[k] + arr[k];
    }
}
Console.Write("sum[] = ");
for (int a = 0; a < arr.Length; a++)
{
    Console.Write(result[a] + "  ");
}
Console.WriteLine();

//5

Console.WriteLine("Question 5 Enter array of integers:");
int[] arr = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();

int prev_num = arr[0];
int max_num = arr[0];
int max_count = 1;
int curr_count = 1;
for (int i = 1; i < arr.Length; i++)
{
    int curr_num = arr[i];

    if (prev_num == curr_num)
    {
        curr_count += 1;
    }
    else
    {
        if (curr_count > max_count)
        {
            max_count = curr_count;
            max_num = prev_num;
        }
        curr_count = 1;
    }
    prev_num = arr[i];
}
if (curr_count > max_count)
{
    max_count = curr_count;
    max_num = prev_num;
}
int[] res = new int[max_count];
for (int i = 0; i < max_count; i++)
{
    res[i] = max_num;
}
Console.WriteLine("The Output");
for (int i = 0; i < res.Length; i++)
{
    Console.Write(res[i] + " ");
}

//7
Console.WriteLine("Question 7 Enter sequence of numbers:");
int[] x = Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();


List<int> num = new List<int>();
List<int> count = new List<int>();

for (int i = 0; i < x.Length; i++)
{
    int curr_num = x[i];
    if (num.Contains(curr_num))
    {
        int curr_index = num.IndexOf(curr_num);
        count[curr_index] = count[curr_index] + 1;
    }
    else
    {
        num.Add(curr_num);
        count.Add(1);
    }
}
int max_count = 0;
int max_index = 0;
for (int j = 0; j < count.Count; j++)
{
    int curr_count = count[j];
    if (curr_count > max_count)
    {
        max_count = curr_count;
        max_index = j;
    }
}
List<int> max_index_list = new List<int>();


for (int j = 0; j < count.Count; j++)
{
    int curr_count = count[j];
    if (curr_count == max_count)
    {
        max_index_list.Add(j);
    }
}



if (max_index_list.Count == 1)
{

    int max_num_single = num[max_index];
    Console.WriteLine(" The number " + max_num_single + " is the most frequent (occurs " + max_count + " times)");

}
else
{
    int[] max_num = new int[max_index_list.Count];

    for (int j = 0; j < max_index_list.Count; j++)
    {
        max_num[j] = num[max_index_list[j]];
    }
    Console.Write("The numbers ");

    for (int j = 0; j < max_num.Length - 1; j++)
    {
        Console.Write(max_num[j] + ", ");
    }
    Console.Write(" and " + max_num[max_num.Length - 1]);
    Console.WriteLine(" have the same maximal frequence (each occurs " + max_count + " times). ");
    Console.WriteLine("The leftmost of them is " + max_num[0]);
}
Console.WriteLine();

//Practice Strings
//1
Console.WriteLine("Enter a word:");
string input = Console.ReadLine();
char[] result = input.ToCharArray();
string temp = String.Empty;

for (int i = result.Length - 1; i > -1; i--)
{
    temp = temp + result[i];
}
Console.WriteLine(temp);

//2
Console.WriteLine("Enter a word:");
string input = Console.ReadLine();
Console.WriteLine(String.Join(" ", input.Split('.', ' ').Reverse()).ToString());

//3
Console.WriteLine("Question 3 Entry Array:");
string str = Console.ReadLine();
char[] protocol = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ', '\t', '\0' };
string[] splitinp = str.Split(protocol);
string[] result = new string[0];
foreach (string s in splitinp)
{
    if (s.SequenceEqual(s.Reverse()) == true)
    {
        Array.Resize(ref result, result.Length + 1);
        result[result.Length - 1] = s;
    }

}

Array.Sort(result, StringComparer.InvariantCulture);
foreach (string s in result)
{
    Console.Write(s + ", ");
}
Console.WriteLine(" ");

//4
Console.WriteLine("Question 4 Enter URL:");
string str = Console.ReadLine();
String[] protocol = { "/", "://" };
String[] strlist = str.Split(protocol,
           StringSplitOptions.RemoveEmptyEntries);

int length = strlist.Length;
if (length == 1)
{
    Console.WriteLine("[protocol] = \"\"");
    Console.WriteLine($"[server] = {strlist[0]}");
    Console.WriteLine("[resource] = \"\"");
}
else if (length == 2)
{
    Console.WriteLine($"[protocol] = {strlist[0]}");
    Console.WriteLine($"[server] = {strlist[1]}");
    Console.WriteLine("[resource] = \"\"");
}
else if (length == 3)
{
    Console.WriteLine($"[protocol] = {strlist[0]}");
    Console.WriteLine($"[server] = {strlist[1]}");
    Console.WriteLine($"[resource] = {strlist[2]}");
}
