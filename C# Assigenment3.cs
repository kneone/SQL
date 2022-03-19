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


//Designing and Building Classes using object-oriented principles
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person test = new Person();
            test.addAddress("1010 W University Ave");

            //test.getAddress();
            List<String> add = test.getAddress();
            //Console.WriteLine(add[0]);

            Student student = new Student();
            //Person test = new Person();
            student.addAddress("1010 W University Ave");

            //test.getAddress();
            List<String> add2 = student.getAddress();
            int age = student.calcAge("2000/01/01");
            Console.WriteLine(age);
            //Console.WriteLine(student.calcSalary(false));

            Instructor instructor = new Instructor();
            instructor.addAddress("1010 W Univeraawefawefsity Ave");
            List<String> add3 = instructor.getAddress();
            Console.WriteLine(add3[0]);
        }
    }
}

namespace ConsoleApp4
{
    internal class Course : ICourseService
    {
        List<Student> students = new List<Student>();

        public void addStudent(Student a)
        {
            students.Add(a);
        }
    }
}

namespace ConsoleApp4
{
    internal class Department : IDepartmentService
    {
        Instructor head;
        String schoolYear;
        double budget;
        List<Course> courses = new List<Course>();

        private void addCourse(Course course)
        {
            courses.Add(course);
        }

        public void getCourse()
        {
            courses.ToString();
        }

        private void setHead(Instructor instructor)
        {
            head = instructor;
        }

        public Instructor getHead()
        {
            return head;
        }
    }
}

namespace ConsoleApp4
{
    internal interface ICourseService
    {
        void addStudent(Student a);
    }
}

namespace ConsoleApp4
{
    internal class Instructor : Person 
    {
        string department;
        bool isHead;
        int year_of_experience;

        public void setDepartment(String department)
        {
            this.department = department;
        }

        public string getDepartment()
        {
            return department;
        }

        public void setHead(bool isHead)
        {
            isHead = isHead;
        }

        public bool getHead()
        {
            return isHead;
        }

        public int calcExperience(String joinDate)
        {
            String[] str = joinDate.Split("/");
            int year = Int32.Parse(str[0]);
            int month = Int32.Parse(str[1]);
            int day = Int32.Parse(str[2]);

            int age = 2022 - year;
            if (month > 3)
            {
                age -= 1;
            }
            this.year_of_experience = age;
            return age;
        }
    }
}

namespace ConsoleApp4
{
    internal interface IDepartmentService
    {
        //void addCourse(Course course);
        void getCourse();
        //void setHead(Instructor instructor);
        Instructor getHead();


    }
}

namespace ConsoleApp4
{
    internal interface IPersonService
    {
        int calcAge(String bday);
        decimal calcSalary(bool isHead);
        void addAddress(String address);
        List<String> getAddress();

    }
}

namespace ConsoleApp4
{
    internal interface IStudentService : IPersonService
    {
        void addCourse(Course course, String grade);
        double calcGPA();

    }
}

namespace ConsoleApp4
{
    internal class Person : IPersonService
    {
        
        List<String> Address = new List<String>();
        decimal salary;
        public int calcAge(String bday) {
            //String bday takes format YYYY/MM/DD
            String[] str = bday.Split("/");
            int year = Int32.Parse(str[0]);
            int month = Int32.Parse(str[1]);
            int day = Int32.Parse(str[2]);

            int age = 2022 - year;
            if (month > 3)
            {
               age -=1 ;
            }
            return age;
        }

        public decimal calcSalary(bool isHead)
        {
            
            if (isHead)
            {
                salary = 8000.00m;
            }
            else
            {
                salary = 8000.00m;
            }

            return salary;
        }

        public void addAddress(String address)
        {
            Address.Add(address);
        }

        public List<String> getAddress()
        {
            return Address;
        }
    }
}

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person test = new Person();
            test.addAddress("1010 W University Ave");

            //test.getAddress();
            List<String> add = test.getAddress();
            //Console.WriteLine(add[0]);

            Student student = new Student();
            //Person test = new Person();
            student.addAddress("1010 W University Ave");

            //test.getAddress();
            List<String> add2 = student.getAddress();
            int age = student.calcAge("2000/01/01");
            Console.WriteLine(age);
            //Console.WriteLine(student.calcSalary(false));

            Instructor instructor = new Instructor();
            instructor.addAddress("1010 W Univeraawefawefsity Ave");
            List<String> add3 = instructor.getAddress();
            Console.WriteLine(add3[0]);
        }
    }
}

namespace ConsoleApp4
{
    internal class Student : Person
    {
        List<Course> courses = new List<Course>();
        List<string> grades = new List<string>();
        double GPA;

        public void addCourse(Course course, String grade)
        {
            courses.Add(course);
            grades.Add(grade);
        }

        public double calcGPA()
        {
            double sum = 0;
            foreach (string grade in grades)
            {
                if(grade == "A")
                {
                    sum += 4.0;
                }else if(grade == "B")
                {
                    sum += 3.0;
                }else if(grade == "C")
                {
                    sum += 2.0;
                }else if(grade == "D")
                {
                    sum += 1.0;
                }
            }

            GPA = sum/grades.Count;
            return GPA;
        }

        public decimal calcSalary(bool isHead)
        {
            return 0m;
        }
    }
}


//7.Try creating the two classes below, and make asimple program to work with them, asdescribed below
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball red = new Ball(new Color(255, 51, 51), 50);
            red.Throw();
            Console.WriteLine(red.TimesThrow());

            Ball purple = new Ball(new Color(204, 204, 255), 100);
            purple.Throw();
            Console.WriteLine(purple.TimesThrow());
            purple.Pop();
            Console.WriteLine(purple.TimesThrow());
            purple.Throw();
            Console.WriteLine(purple.TimesThrow());
            purple.Throw();
            purple.Throw();
            Console.WriteLine(purple.TimesThrow());
        }
    }
}

// color method
namespace ConsoleApp5
{
    internal class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = 255;
        }
        public byte getRed()
        {
            return red;
        }
        public byte getGreen()
        {
            return green;
        }

        public byte getBlue()
        {
            return blue;
        }

        public byte getAlpha()
        {
            return alpha;
        }
        public void setRed(byte red)
        {
            this.red = red;
        }

        public void setGreen(byte green)
        {
            this.green=green;
        }
        public void setBlue(byte blue )
        {
            this.blue = blue;
        }
        public void setAlpha(byte alpha)
        {
            this.alpha = alpha;
        }
        public byte getGraySclae()
        {
            byte result = (byte)((red + green + blue) / 3);
            return result;
        }
        
    }
}

// ball methods
namespace ConsoleApp5
{
    internal class Ball
    {
        private Color color;
        private int size;
        private int times;
        
        public Ball(Color color, int size)
        {
            this.color = color;
            this.size = size;
            this.times = 0;
        }
        public void Pop()
        {
            size = 0;
        }
        public void Throw() 
        {

            if (size > 0)
            {
                times++;
            }

        }

        public int TimesThrow()
        {
            //Console.WriteLine();
            //Console.WriteLine(color + " ball has been thrown " + times +" times");
            return times;
             
        }
    }
}



