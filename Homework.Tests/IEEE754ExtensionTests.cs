﻿using NUnit.Framework;

namespace Homework.Tests
{
    [TestFixture]
    public class IEEE754ExtensionTests
    {
        [TestCase(-255.255, ExpectedResult = "1100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(255.255, ExpectedResult = "0100000001101111111010000010100011110101110000101000111101011100")]
        [TestCase(4294967295.0, ExpectedResult = "0100000111101111111111111111111111111111111000000000000000000000")]
        [TestCase(double.MinValue, ExpectedResult = "1111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.MaxValue, ExpectedResult = "0111111111101111111111111111111111111111111111111111111111111111")]
        [TestCase(double.Epsilon, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000001")]
        [TestCase(double.NaN, ExpectedResult = "1111111111111000000000000000000000000000000000000000000000000000")]
        [TestCase(double.NegativeInfinity, ExpectedResult = "1111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(double.PositiveInfinity, ExpectedResult = "0111111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(0.0, ExpectedResult = "0000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(-0.0, ExpectedResult = "1000000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(0.1238279, ExpectedResult = "0011111110111111101100110010111101101100110101010001010101110001")]
        [TestCase(0.8188472919, ExpectedResult = "0011111111101010001100111111111100111100011001000001111000001000")]
        [TestCase(19283791824, ExpectedResult = "0100001000010001111101011001110100111111010000000000000000000000")]
        [TestCase(-838528782, ExpectedResult = "1100000111001000111111010111011110000111000000000000000000000000")]
        public string ToIEEE754StringTest(double number)
        {
            return number.ToIEEE754String();
        }
    }
}