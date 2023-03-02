
using PowerCollections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PowerCollections.Stack<int> stack = new PowerCollections.Stack<int>();  
            Console.WriteLine(stack.Capacity);
           
        }
    }
}