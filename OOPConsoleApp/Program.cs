using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace OOPConsoleApp
{
    public class Calculator
    {
        public int Sum(int a, int b) => a + b;
    }
    public class IndexingClass
    {
        public int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {
                    return array[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }
    }
    public abstract class ComputerPart
    {
        public abstract void Work();

    }
    public class Processor : ComputerPart
    {
        public override void Work()
        {

        }
    }
    public class MotherBoard : ComputerPart
    {
        public override void Work()
        {

        }
    }
    public class GraphicCard : ComputerPart
    {
        public override void Work()
        {

        }
    }
    public class Ak
    {
        private static int increasingCounter;

        public static int IncreasingCounter
        {
            get
            {
                return increasingCounter;
            }
            set
            {
                increasingCounter = value;
            }
        }
    }
    public class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    public static class intExtension
    {
        public static int GetNegative(this int source)
        {
            return source > 0 ? -source : source;
        }
        public static int GetPositive(this int source)
        {
            return source < 0 ? -source : source;
        }
    }
    public class Engine { }
    public class ElectricEngine : Engine { }
    public class GasEngine : Engine { }
    public class CarPart { }
    public class Battery : CarPart { }
    public class Differential : CarPart { }
    public class Wheel : CarPart { }

    public abstract class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine = default(TEngine);
        public abstract void ChangePart<TPart>(TPart newPart) where TPart : CarPart;
    }
    public class ElectricCar : Car<ElectricEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
    }
    public class GasCar : Car<GasEngine>
    {
        public override void ChangePart<TPart>(TPart newPart)
        {
            
        }
    }
    public class Record<T1, T2>
    {

        public T1 id;
        public T2 Value;
        DateTime Date;
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
            private string Description;
            public static int MaxValue;
            private int length;
            private int count;
            public int Value;
            public static string Parent;
            public static int DaysInWeek;
            static Obj()
            {
                Parent = "System.Object";
                DaysInWeek = 7;
                MaxValue = 2000;
            }
            public static void в۝Person〱WorkOffice〱Helper〱Class(int a)
            {

            }

            public static Obj operator +(Obj adder1, Obj adder2)
            {
                return new Obj { Value = adder1.Value + adder2.Value };
            }
            public static Obj operator -(Obj adder1, Obj adder2)
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
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;
            ;
            Console.WriteLine(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase("sdf sd")); //7
            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0
            Console.WriteLine("Hello, World!");
        }
    }
}
