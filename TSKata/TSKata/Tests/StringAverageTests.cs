using FluentAssertions;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class StringAverageTests
{
    private readonly StringAverage _stringAverage = new()
    {
        Input = string.Empty
    };

    [Test]
    public void given_normal_input_return_average()
    {
        GivenStringAverageInput("zero nine five two");

        AverageShouldBe("four");
    }

    [Test]
    public void given_empty_return_na()
    {
        GivenStringAverageInput(string.Empty);

        AverageShouldBe("n/a");
    }

    [Test]
    public void given_number_large_than_nine_return_na()
    {
        GivenStringAverageInput("zero nine five two ten");

        AverageShouldBe("n/a");
    }

    [Test]
    public void given_number_include_uppercase_return_normal()
    {
        GivenStringAverageInput("zERO nine FIVE Two");

        AverageShouldBe("four");
    }

    [Test]
    public void given_one_number_return_number_diretly()
    {
        GivenStringAverageInput("nine");

        AverageShouldBe("nine");
    }

    [Test]
    public void input_include_non_numeric_return_na()
    {
        GivenStringAverageInput("nine hello world");

        AverageShouldBe("n/a");
    }

    [TestCase("one two three")]
    [TestCase("one two four")]
    public void result_always_floored(string input)
    {
        GivenStringAverageInput(input);

        AverageShouldBe("two");
    }

    private void AverageShouldBe(string expected)
    {
        _stringAverage.CalculateFlooredAverage().Should().Be(expected);
    }

    private void GivenStringAverageInput(string input)
    {
        _stringAverage.Input = input;
    }
}