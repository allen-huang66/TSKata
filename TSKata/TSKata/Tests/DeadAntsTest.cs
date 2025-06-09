using FluentAssertions;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class DeadAntsTest
{
    [TestCase("...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t", 3)]
    [TestCase("...ant...ant..nat.ant.t..ant...ant..ant..ant.ant.ant..t", 3)]
    [TestCase("ant anantt aantnt", 2)]
    [TestCase("ant.ant.t...ant", 1)]
    [TestCase("ant ant .... a nt", 1)]
    [TestCase("ant ant ant ant", 0)]
    [TestCase("", 0)]
    public void normal_case(string input, int expected)
    {
        var deadAnts = new DeadAnts(input);
        deadAnts.Cal();
        deadAnts.DeadAntsNums.Should().Be(expected);
    }
}