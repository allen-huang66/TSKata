using FluentAssertions;
using TSKata.TSKata.Core;

namespace TSKata.TSKata.Tests;

public class AnagramDetectionTest
{
    [TestCase("foefet", "toffee", true)]
    [TestCase("", "", true)]
    [TestCase("aa", "aab", false)]
    [TestCase("ac", "bb", false)]
    [TestCase("abab", "cdcd", false)]
    [TestCase("aab", "bba", false)]
    [TestCase("foefet", "toffee", true)]
    [TestCase("dumble", "bumble", false)]
    [TestCase("ound", "round", false)]
    [TestCase("apple", "pale", false)]
    public void normal_case_anagram(string a, string b, bool expected)
    {
        var anagramDetection = new AnagramDetection(a, b);
        var detect = anagramDetection.IsAnagram();
        detect.Should().Be(expected);
    }

    [TestCase("foefet", "Toffee", true)]
    [TestCase("Buckethead", "DeathCubeK", true)]
    [TestCase("Twoo", "Woot", true)]
    public void case_insensitive_anagram(string a, string b, bool expected)
    {
        var anagramDetection = new AnagramDetection(a, b);
        var detect = anagramDetection.IsAnagram();
        detect.Should().Be(expected);
    }

    [TestCase("Twoo123", "Woot", false)]
    public void diff_length_anagram(string a, string b, bool expected)
    {
        var anagramDetection = new AnagramDetection(a, b);
        var detect = anagramDetection.IsAnagram();
        detect.Should().Be(expected);
    }
}