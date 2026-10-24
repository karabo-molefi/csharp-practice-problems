# C# Practice Problems

Small coding problems for beginners, inspired by [CS50](https://pll.harvard.edu/course/cs50-introduction-computer-science). Each problem is a method
with a missing body. Your job is to fill it in and make the **unit tests** pass.

The tests tell you right away whether your solution works.

## How to use this repo

1. Click **Use this template** to get your own copy, then clone it.
2. Pick a problem in `Problems/Basics.cs` and replace the `throw` line with your code.
3. Run the tests. Keep going until everything is green.
4. Commit and push to see the tests run on GitHub.

## The problems

| Method | Task |
| --- | --- |
| `Greet()` | Read a name, print `Hello, <name>!` |
| `AddAndPrint(a, b)` | Print result |
| `SubtractAndPrint(a, b)` | Print result |
| `Larger(a, b)` | Return the bigger number |
| `Smaller(a, b)` | Return the smaller number |

Stuck? Try for a while first, then compare with a solution on the
[`solutions` branch](https://github.com/YOUR-USERNAME/YOUR-REPO/tree/solutions).

## How unit tests are used here

A unit test calls your method with a known input and checks that the result
matches the expected answer. This project uses [xUnit](https://xunit.net/) on
.NET 10.

- **Starter code** lives in `Problems/Basics.cs`. Every method starts as
  `throw new NotImplementedException();`. (To be replaced with own code)
- **Tests** live in `Problems.Tests/BasicsTest.cs`. Each problem has several
  test cases, including edge cases like negative numbers, equal values and
  empty text.
- **Red to green:** at the start, all tests fail (red). Write your solution and
  they turn green.

Here is what a test looks like. Each `[InlineData]` line is one test case
(two inputs, then the expected answer):

```csharp
[Theory]
[InlineData(1, 2, 2)]
[InlineData(5, 3, 5)]
[InlineData(-1, -7, -1)]
public void Larger_ReturnsTheBiggerNumber(int a, int b, int expected)
{
    Assert.Equal(expected, Basics.Larger(a, b));
}
```

Problems that print to the console are tested too. The test captures what your
code prints (and, for `Greet`, types in a name for it), then compares the output
to the expected text.

## Running the tests

**Visual Studio:** open `CodingProblems.slnx`, then go to Test > Test Explorer
and click **Run All Tests**.

**Terminal:** run `dotnet test` in the project folder.

**On GitHub:** every push runs the tests automatically. Check the **Actions**
tab to see a green check or a red cross.

Don't edit the test files. They are the rules of the game.
