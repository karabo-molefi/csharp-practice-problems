namespace Problems.Tests
{
    public class BasicsTest
    {
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
    }
}
