using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace OOPConsoleApp
{
    public class Calculator
    {
        public int Sum(int a, int b) => a + b;
    }
    internal class Program
    {
        class Employee
        {
            public string Name;
            public int Age;
            public int Salary;
        }
        class ProjectManager : Employee
        {
            private string ProjectName;
        }
        class Developer : Employee
        {
            private string ProgrammingLanguage;
        }
        class Food
        {

        }
        class Vegetable : Food
        {

        }
        class Fruit : Food
        {

        }
        class Apple : Fruit
        {

        }
        class Banana : Fruit
        {

        }
        class Pear : Fruit
        {

        }
        class Potato : Vegetable
        {

        }
        class Carrot : Vegetable
        {

        }
        class Obj
        {
            private string name;
            private string owner;
            private int length;
            private int count;
            public int Value;

            public static Obj operator + (Obj adder1, Obj adder2)
            {
                return new Obj { Value = adder1.Value + adder2.Value };
            }
            public static Obj operator - (Obj adder1, Obj adder2)
            {
                return new Obj { Value = adder1.Value - adder2.Value };
            }
        }
        class BaseClass
        {
            protected string Name;
            public virtual int Counter { get; set; }
            public virtual void Display()
            {
                Console.WriteLine("Метод класса BaseClass");
            }

            public BaseClass(string name)
            {
                Name = name;
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;
            private int counter;
            public override int Counter
            {
                get => counter;
                set
                {
                    if (counter > 0)
                    {
                        counter = value;
                    }
                }
            }

            public override void Display()
            {
                base.Display();
                Console.WriteLine("Метод класса DerivedClass");
            }
            public DerivedClass(string Desription, string name) : base(Desription)
            {
            }
            public DerivedClass(string Desription, string name, int counter) : this(Desription, name)
            {
            }
        }
        public class A
        {
            public virtual void Display() => Console.WriteLine("A");
        }
        public class B : A
        {
            public new void Display() => Console.WriteLine("B");
        }
        public class C : A
        {
            public override void Display() => Console.WriteLine("C");
        }
        public class D : B
        {
            public new void Display() => Console.WriteLine("D");
        }
        public class E : C
        {
            public new void Display() => Console.WriteLine("E");
        }
        class Vector
        {
            public int X;
            public int Y;
            public static Vector operator +(Vector a)
            {
                return new Vector
                {
                    X = a.X,
                    Y = a.Y
                };
            }
            public static Vector operator +(Vector a, (int X, int Y) b)
            {
                Console.WriteLine(typeof(B));
                return new Vector
                {
                    X = a.X + b.X,
                    Y = a.Y + b.Y
                };
            }
        }


        static void Main(string[] args)
        {
            Vector a = new Vector { X = 3, Y = 5 };
            Vector b = new Vector { X = 7, Y = 13 };

            Vector c = a + (3, 4);

            var d = (3, 5);

            Console.WriteLine($"{c.X}, {c.Y}");
            Console.WriteLine("Hello, World!");
        }
    }
}
