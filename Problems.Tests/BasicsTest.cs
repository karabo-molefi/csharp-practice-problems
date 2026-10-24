namespace Problems.Tests
{
    public class BasicsTest
    {
        [Theory]
        [InlineData("World", "Hello, World!")]
        [InlineData("Sam", "Hello, Sam!")]
        [InlineData("Ana Maria", "Hello, Ana Maria!")]
        [InlineData("", "Hello, !")]
        public void Greet_PrintsHelloWithTheName(string name, string expected)
        {
            var originalIn = Console.In;
            var originalOut = Console.Out;
            try
            {
                Console.SetIn(new StringReader(name + "\n"));
                var output = new StringWriter();
                Console.SetOut(output);

                Basics.Greet();

                Assert.Equal(expected, output.ToString().Trim());
            }
            finally
            {
                Console.SetIn(originalIn);
                Console.SetOut(originalOut);
            }
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 3, 5)]
        [InlineData(4, 4, 4)]
        [InlineData(-1, -7, -1)]
        public void Larger_ReturnsTheBiggerNumber(int a, int b, int expected)
        {
            int result = Basics.Larger(a, b);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 7, 1)]
        [InlineData(4, -1, -1)]
        [InlineData(9, 5, 5)]
        [InlineData(2, 2, 2)]

        public void Smaller_ReturnsTheSmallerNumber(int a, int b, int expected)
        {
            int result = Basics.Smaller(a, b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 3, "5")]
        [InlineData(-4, 10, "6")]
        [InlineData(0, 0, "0")]

        public void AddAndPrint_PrintsTheSum(int a, int b, string expected)
        {
            var originalOut = Console.Out;
            try
            {
                var output = new StringWriter();
                Console.SetOut(output);

                Basics.AddAndPrint(a, b);

                Assert.Equal(expected, output.ToString().Trim());
            }
            finally { Console.SetOut(originalOut); }
           
        }

        [Theory]
        [InlineData(2, 3, "-1")]
        [InlineData(10, 5, "5")]
        [InlineData(0, 0, "0")]

        public void SubtractAndPrint_PrintsTheDifference(int a, int b, string expected)
        {
            var originalOut = Console.Out;
            try
            {
                var output = new StringWriter();
                Console.SetOut(output);

                Basics.SubtractAndPrint(a, b);

                Assert.Equal(expected, output.ToString().Trim());
            }
            finally { Console.SetOut(originalOut); }
        }


    }
}
