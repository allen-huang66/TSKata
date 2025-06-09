using FluentAssertions;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class CountingDuplicatesTest
{
    [TestCase("abcde", 0)]
    [TestCase("aabbcde", 2)]
    [TestCase("aabBcde", 2)]
    [TestCase("indivisibility", 1)]
    [TestCase("Indivisibilities", 2)]
    [TestCase("aA11", 2)]
    [TestCase("ABBA", 2)]
    public void normal_test_case(string input, int expected)
    {
        var countingDuplicates = new CountingDuplicates(input);
        var calResult = countingDuplicates.Cal();
        calResult.Should().Be(expected);
    }
}