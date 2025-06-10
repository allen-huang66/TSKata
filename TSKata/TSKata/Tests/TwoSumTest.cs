using FluentAssertions;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class TwoSumTest
{
    [TestCase(new[] { 2, 7, 11, 15 }, new[] { 0, 1 }, 9)]
    [TestCase(new[] { 2, 7, 11, 15 }, new[] { 0, 1 }, 9)]
    [TestCase(new[] { 3, 2, 4 }, new[] { 1, 2 }, 6)]
    [TestCase(new[] { 3, 3 }, new[] { 0, 1 }, 6)]
    public void when_given_normal_case(int[] nums, int[] expected, int target)
    {
        var twoSum = new TwoSum(nums, target);
        var ints = twoSum.Ans();
        ints.Should().BeEquivalentTo(expected);
    }

    [Test]
    public void when_no_answer_should_return_empty_array()
    {
        var nums = new[] { 2, 7, 11, 15 };
        var target = 10;

        var twoSum = new TwoSum(nums, target);
        var ints = twoSum.Ans();

        ints.Should().BeEquivalentTo(new int[] { });
    }

    [Test]
    public void when_element_less_than_2_should_return_empty_array()
    {
        var nums = new[] { 2 };
        var target = 2;

        var twoSum = new TwoSum(nums, target);
        var ints = twoSum.Ans();

        ints.Should().BeEquivalentTo(new int[] { });
    }
}