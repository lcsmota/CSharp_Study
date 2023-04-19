using Algorithms.Searching;
using Xunit;

namespace Algorithm.Tests;

public class LinearSearchTest
{
    private int[] _numbers;
    private string[] _names;

    public LinearSearchTest()
    {
        _numbers = new int[] { 12, 34, 56, 87, 125, 66, 33 };
        _names = new string[] { "John", "Josh", "Maria", "Juca", "Karlos", "Eduardo" };
    }

    [Theory()]
    [InlineData(87)]
    [InlineData(33)]
    [InlineData(56)]
    [InlineData(12)]
    public void Should_Return_IndexOfElement_When_Number_IsMatch(int number)
    {
        var result = LinearSearch<int>.Search(_numbers, number);

        Assert.Equal(result >= 0, true);
    }

    [Theory()]
    [InlineData(87)]
    [InlineData(33)]
    [InlineData(56)]
    [InlineData(12)]
    public void Should_Return_IndexOfElement_When_Number_IsMatch_Recursively(int number)
    {
        var result = LinearSearch<int>.RecursiveSearch(_numbers, _numbers.Length, number);

        Assert.Equal(result >= 0, true);
    }


    [Theory()]
    [InlineData(234)]
    [InlineData(1)]
    [InlineData(69)]
    [InlineData(1024)]
    public void Should_Return_MinusOne_When_Number_IsNotMatch(int number)
    {
        var result = LinearSearch<int>.Search(_numbers, number);

        Assert.Equal(result > 0, false);
    }

    [Theory()]
    [InlineData(234)]
    [InlineData(1)]
    [InlineData(69)]
    [InlineData(1024)]
    public void Should_Return_MinusOne_When_Number_IsNotMatch_Recursively(int number)
    {
        var result = LinearSearch<int>.RecursiveSearch(_numbers, _numbers.Length, number);

        Assert.Equal(result > 0, false);
    }

    [Theory()]
    [InlineData("Juca")]
    [InlineData("Karlos")]
    [InlineData("Josh")]
    [InlineData("Maria")]
    public void Should_Return_IndexOfElement_When_Name_IsMatch(string name)
    {
        var result = LinearSearch<string>.Search(_names, name);

        Assert.Equal(result >= 0, true);
    }

    [Theory()]
    [InlineData("Juca")]
    [InlineData("Karlos")]
    [InlineData("Josh")]
    [InlineData("Maria")]
    public void Should_Return_IndexOfElement_When_Name_IsMatch_Recursively(string name)
    {
        var result = LinearSearch<string>.RecursiveSearch(_names, _names.Length, name);

        Assert.Equal(result >= 0, true);
    }

    [Theory()]
    [InlineData("Kathia")]
    [InlineData("Karllos")]
    [InlineData("Joseph")]
    [InlineData("Mariana")]
    public void Should_Return_MinusOne_When_Name_IsNotMatch(string name)
    {
        var result = LinearSearch<string>.Search(_names, name);

        Assert.Equal(result > 0, false);
    }

    [Theory()]
    [InlineData("Kathia")]
    [InlineData("Karllos")]
    [InlineData("Joseph")]
    [InlineData("Mariana")]
    public void Should_Return_MinusOne_When_Name_IsNotMatch_Recursively(string name)
    {
        var result = LinearSearch<string>.RecursiveSearch(_names, _names.Length, name);

        Assert.Equal(result > 0, false);
    }
}