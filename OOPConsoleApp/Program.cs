namespace OOPConsoleApp
{
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
                // ...
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
