namespace Problems
{
    public class Basics
    {
        // Read a name from the user, then print: Hello, <name>!
        // example output: "Hello, Jane!"
        public static void Greet()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        // ADD a and b, then print the result.
        public static void AddAndPrint(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        // SUBTRACT a and b, then print the result.
        public static void SubtractAndPrint(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        // Return the BIGGEST number between a and b
        public static int Larger(int a, int b)
        {
            return Math.Max(a, b);
        }

        // Return the SMALLEST number between a and b
        public static int Smaller(int a, int b)
        {
            return Math.Min(a, b);
        }


    }
}
