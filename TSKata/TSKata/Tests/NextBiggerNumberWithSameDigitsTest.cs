using FluentAssertions;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class NextBiggerNumberWithSameDigitsTest
{
    private readonly NextBiggerNumberWithSameDigits _nextBiggerNumberWithSameDigits = new();

    [TestCase(12, 21)]
    [TestCase(513, 531)]
    [TestCase(2017, 2071)]
    [TestCase(12543, 13245)]
    [TestCase(10987654321, 11023456789)]
    public void normal_case(long input, long expected)
    {
        var nextBiggerNumber = _nextBiggerNumberWithSameDigits.GetNextBiggerNumber(input);
        nextBiggerNumber.Should().Be(expected);
    }

    [TestCase(9, -1)]
    [TestCase(111, -1)]
    [TestCase(531, -1)]
    [TestCase(9876543210, -1)]
    public void when_cannot_be_arranged_to_bigger_number_return_minus_one(long input, long expected)
    {
        var nextBiggerNumber = _nextBiggerNumberWithSameDigits.GetNextBiggerNumber(input);
        nextBiggerNumber.Should().Be(expected);
    }
}