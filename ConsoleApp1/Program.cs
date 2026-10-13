
namespace ConsoleApp
{
    /*

    class Student
    {
        public const double PI = 3.14159;

        public Student(string name)
        {
            //Age = age;
            Name = name;
        }


        private int age;
        //自动生成的属性
        //init 关键字用于初始化属性的值，只能在对象初始化时设置，之后不能修改。
        public string Name { get; init; }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value > 150)
                {
                    throw new ArgumentException();
                }
                age=value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Student stu1 = new Student("Alice");
            // stu1.Age = 20;
            // stu1.Name = "Alice";

            Student Tom = new Student("Tom")
            {
                Age = 25,
                Name = "tom"
            };


            stu1.DisplayInfo();

        }
    }
    */

    public delegate int MyDelegate(int x, int y);

    class Calculator
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            MyDelegate del = Calculator.Add;
            Calculator calc = new Calculator();

            del += calc.Subtract;
        }
    }
}
