using Algorithms.Searching;
using Xunit;

namespace Algorithm.Tests;

public class BinarySearchTest
{
    private int[] _sortedNumbers;
    private string[] _sortedNames;

    public BinarySearchTest()
    {
        _sortedNumbers = new int[] { 12, 34, 56, 87, 125, 266, 433, 591, 826 };
        _sortedNames = new string[] { "Eduardo", "Joanna", "Joanna", "John", "Josh", "Juca", "Karlos", "Maria", "Thiago" };
    }

    [Theory()]
    [InlineData(87)]
    [InlineData(433)]
    [InlineData(56)]
    [InlineData(12)]
    public void Should_Return_IndexOfElement_When_Number_IsMatch(int number)
    {
        var result = BinarySearch<int>.Search(_sortedNumbers, number);

        Assert.Equal(result >= 0, true);
    }

    [Theory()]
    [InlineData(234)]
    [InlineData(1)]
    [InlineData(69)]
    [InlineData(1024)]
    public void Should_Return_MinusOne_When_Number_IsNotMatch(int number)
    {
        var result = BinarySearch<int>.Search(_sortedNumbers, number);

        Assert.Equal(result > 0, false);
    }

    [Theory()]
    [InlineData("Juca")]
    [InlineData("Karlos")]
    [InlineData("Josh")]
    [InlineData("Joanna")]
    public void Should_Return_IndexOfElement_When_Name_IsMatch(string name)
    {
        var result = BinarySearch<string>.Search(_sortedNames, name);

        Assert.Equal(result >= 0, true);
    }

    [Theory()]
    [InlineData("Kathia")]
    [InlineData("Anny")]
    [InlineData("Joseph")]
    [InlineData("Mariana")]
    public void Should_Return_MinusOne_When_Name_IsNotMatch(string name)
    {
        var result = BinarySearch<string>.Search(_sortedNames, name);

        Assert.Equal(result > 0, false);
    }
}