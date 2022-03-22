//04 Generics
//Test your Knowledge

//1.Describe the problem generics address.
    //Generics solves the problems of having to use loosely typed objects.
    //It solves the problems of writing similar classes that only have type differences.

//2.How would you create a list of strings, using the generic List class?
    //	List<String> str = new Lis<String>();
    //List<T> l = new List<T>();

//3.How many generic type parameters does the Dictionary class have?
    //	Tkey
    //	Tvalue

//4.True/False. When a generic class has multiple type parameters, they must all match.
    //	False

//5.What method is used to add items to a List object?
    //	Add()

//6.Name two methods that cause items to be removed from a List.
    //	Remove(): remove the first from list.
    //	RemoveAt(): remove the element at the position.

//7.How do you indicate that a class has a generic type parameter?
    //	specifying a type parameter in an angle brackets after a type name

//8.True/False. Generic classes can only have one generic type parameter.
    //	False

//9.True/False. Generic type constraints limit what can be used for the generic type.
    //	True

//10.True/False. Constraints let you use the methods of the thing you are constraining to.
    //	True
    
//Practice working with Generics
//1.Create a custom Stack class  MyStack<T>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;

namespace ConsoleApp7
{
    class Q1
    {
        public class MyStack<T>
        {
            private Stack sta = new Stack();
            public int Count()
            {
                return sta.Count;
            }
            public T Pop()
            {
                return (T)sta.Pop();
            }

            public void Push(T num)
            {
                sta.Push(num);
            }
        }
        public static void Main(String[] args)
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Pop());
        }
    }
}

//2.Create a Generic List data structure  MyList<T>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Q2
    {
        public static void Main()
        {
            MyList<int> lst = new MyList<int>();

            lst.Add(1);
            lst.Add(2);
            lst.Add(5);
            lst.Add(12);
            lst.Add(18);
            Console.WriteLine("Remove " + lst.Remove(2));
            Console.WriteLine("Contain 12? " + lst.Contains(12));
            lst.InsertAt(20, 4);
            Console.WriteLine("The 4th position is " + lst.Find(4));
            Console.WriteLine("The list size before delete is " + lst.l.Count());
            lst.DeleteAt(4);
            Console.WriteLine("The list size after delete is " + lst.l.Count());
            lst.Clear();
            Console.WriteLine("The list size after clear is " + lst.l.Count());

        }
        public class MyList<T>
        {
            public List<T> l = new List<T>();

            public void Add(T element)
            {
                l.Add(element);
            }
            public T Remove(int index)
            {
                T element = l[index];
                l.RemoveAt(index);
                return element;

            }
            public bool Contains(T element)
            {
                return l.Contains(element);
            }
            public void Clear()
            {
                l.Clear();
            }
            public void InsertAt(T element, int index)
            {
                l.Insert(index, element);
            }
            public void DeleteAt(int index)
            {
                l.RemoveAt(index);
            }
            public T Find(int index)
            {
                return (T)l[index];
            }
        }

    }
}

//3.Implement a GenericRepository<T> class that implements IRepository<T> interface 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Q3
    {
        interface IRepository<T> where T : new()
        {
            public void Add(T item);
            public void Remove(T item);
            public void Save();
            public IEnumerable<T> GetAll();
            public T GetById(int id);
           
        }
        public static void Main()
        {
            GenericRepository<int> lst = new GenericRepository<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(5);
            lst.Add(10);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(lst.GetById(i));
            }
            lst.Remove(10);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(lst.GetById(i));
            }
            Console.WriteLine(lst.GetAll());
            lst.Save();

        }
        class GenericRepository<T>: IRepository<T> where T:new ()
        {
        
            private List<T> l;
            public GenericRepository()
            {
                l = new List<T>();
            }

            public void Add(T item)
            {
                l.Add(item);
            }
            public void Remove(T item)
            {
                l.Remove(item);
            }
            public void Save()
            {
                TextWriter tw = new StreamWriter("SavedLists.txt");
                tw.WriteLine(l);
                tw.Close();
            }
            public IEnumerable<T> GetAll()
            {
                IEnumerable<T> ts = l;
                return ts;

            }
            public T GetById(int id)
            {
                T result = l[id];
                return result;

            }
        }

    }
}
