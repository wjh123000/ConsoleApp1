
namespace ConsoleApp
{
    class Program
    {
        // ref 引用参数允许在方法中修改传入的参数值，并且这些修改会反映到调用方法的地方。
        // out 参数用于在方法中返回多个值，调用方法时不需要初始化 out 参数，但必须在方法中为其赋值。
        // in 只读参数，允许在方法中读取传入的参数值，但不能修改它们。
        static bool MyMethod(ref int number, out float result)
        {
            number = 100;
            result = 3.14f;
            return true;
        }

        static int GetSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int number = 0;
            float result;
            MyMethod(ref number, out result);

            Console.WriteLine($"Number: {number}, Result: {result}");

            Console.WriteLine($"Sum: {GetSum( 1, 2, 3, 4, 5)}");
        }
    }
}
