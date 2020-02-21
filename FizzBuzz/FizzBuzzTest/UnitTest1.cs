using NUnit.Framework;
using FizzBuzProject;
using FizzBuzProject.Controllers;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Moq;
using FizzBuzProject.Models;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFizzBuzz()
        {
            FizzBuzz fizzBuzz = new FizzBuzz(50);
            string result = fizzBuzz.fizzBuzz(2);
            string resultado = "2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz, 16, 17, Fizz, 19, Buzz, Fizz, 22, 23, Fizz, Buzz, 26, Fizz, 28, 29, FizzBuzz, 31, 32, Fizz, 34, Buzz, Fizz, 37, 38, Fizz, Buzz, 41, Fizz, 43, 44, FizzBuzz, 46, 47, Fizz, 49";
            Assert.AreEqual(resultado, result);
            Assert.Pass();
        }
    }
}