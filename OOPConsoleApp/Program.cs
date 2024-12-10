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

            public Obj(string name, string ownerName, int objLength, int count)
            {
                this.name = name;
                owner = ownerName;
                length = objLength;
                this.count = count;
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



        static void Main(string[] args)
        {
            D d = new D();
            E e = new E();

            d.Display();
            ((A)e).Display();
            ((B)d).Display();
            ((A)d).Display();
            Console.WriteLine("Hello, World!");
        }
    }
}
