using FluentAssertions;
using FluentAssertions.Primitives;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class ContainsDuplicate2Test
{
    private ContainsDuplicate2 _containsDuplicate2;

    [SetUp]
    public void SetUp()
    {
        _containsDuplicate2 = new ContainsDuplicate2();
    }

    [TestCase(new int[] { 1, 2, 3, 1 }, 3, true)]
    [TestCase(new int[] { 1, 0, 1, 1 }, 1, true)] 
    [TestCase(new int[] { 1, 2, 3, 1, 2, 3 }, 2, false)] 
    [TestCase(new int[] { 1, 2, 3, 1 }, 3, true)]
    [TestCase(new int[] { 1, 2, 3, 1 }, 2, false)]
    [TestCase(new int[] { }, 1, false)]
    [TestCase(new int[] { 99, 99 }, 0, false)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 10, false)]
    [TestCase(new int[] { 1, 2, 3, 1, 2, 3 }, 3, true)]
    public void normal_case(int[] input, int k, bool expected)
    {
        var isDuplicate = _containsDuplicate2.IsDuplicate(input, k);
        ShouldBe(expected, isDuplicate);
    }

    private static void ShouldBe(bool expected, bool isDuplicate)
    {
        isDuplicate.Should().Be(expected);
    }
}