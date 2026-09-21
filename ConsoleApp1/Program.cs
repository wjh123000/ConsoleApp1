namespace ConsoleApp
{

    class Person
    {

        public Person()
        {
            this.age = 0;
            this.name = "Unknown";
        }

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int age;
        public string name;


        public static int maxage = 150;//类的静态字段，通过类名访问

    }


    class Program
    {
        static void Greet()
        {
            Console.WriteLine("Hello, World!");
        }

        static void Get() => Console.WriteLine("Get method called");


        static void Main()
        {

            //var i = 0;
            //var f = 3.219749812;


            //int age = 20;

            //decimal price = 19.99m;

            //int a = 1;
            //int b = 2;
            //int ret = a + b;

            //Console.WriteLine($"{a} + {b} = {ret}");


            //Person p = new Person();
            //p.age = 30;
            //p.name = "John";
            //Person q = new Person();
            //q.age = 3;
            //q.name = "Tom";

            //Console.WriteLine($"Person p: {p.name,10}, age: {p.age}");
            //Console.WriteLine($"Person q: {q.name,-10}, age: {q.age}");


            //Console.WriteLine($"Max age: {Person.maxage}");

            //Greet();
            //Get();


            //int[] array = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(array.Length);

            //int[,] arr =
            //{
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};

            //Console.WriteLine(arr[1, 2]);
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.GetLength(0));//一共多少行
            //Console.WriteLine(arr.GetLength(1));//一共多少列

            //try
            //{
            //    int[] arr2 = { 1, 2, 3 };
            //    Console.WriteLine(arr2[3]);
            //}
            //catch(IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Index out of range: {ex.Message}");

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");
            //}


            //try
            //{
            //    int result = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"Parsed result: {result}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Format exception: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");

            //}


            int[] arr2 = { 1, 2, 3 };

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }


            List<int> list = new() { 1, 2, 3, 4, 5 };

        }
    }
}
