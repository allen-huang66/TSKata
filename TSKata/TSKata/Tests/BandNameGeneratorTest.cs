using FluentAssertions;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class BandNameGeneratorTest
{
    [TestCase("dolphin", "The Dolphin")]
    [TestCase("knife", "The Knife")]
    [TestCase("bed", "The Bed")]
    public void when_first_and_last_char_diff(string input, string expected)
    {
        var decrypt = BandNameGenerator.Decrypt(input);
        decrypt.Should().Be(expected);
    }

    [TestCase("alaska", "Alaskalaska")]
    [TestCase("tart", "Tartart")]
    [TestCase("sandles", "Sandlesandles")]
    public void when_first_and_last_char_same(string input, string expected)
    {
        var decrypt = BandNameGenerator.Decrypt(input);
        decrypt.Should().Be(expected);
    }
}