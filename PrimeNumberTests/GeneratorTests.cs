using NUnit.Framework;
using PrimeNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberTests
{
    [TestFixture]
    public class GeneratorTests
    {
        [Test]
        public void Generate_CorrectCount()
        {
            //act
            var primes = Generator.Primes();

            //assert
            Assert.AreEqual(168, primes.Count());
        }

        [Test]
        [TestCase(0, 2)]
        [TestCase(1, 3)]
        [TestCase(2, 5)]
        [TestCase(165, 983)]
        [TestCase(166, 991)]
        [TestCase(167, 997)]
        public void Generate_CorrectMarginalValues(int position, int value)
        {
            //act
            var primes = Generator.Primes();

            //assert
            Assert.AreEqual(value.ToString(), primes[position]);
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(4)]
        [TestCase(10)]
        [TestCase(400)]
        [TestCase(999)]
        [TestCase(1000)]
        public void Generate_IncorrectVaules(int value)
        {
            //act
            var primes = Generator.Primes();

            //assert
            Assert.IsFalse(primes.Any(x => x.Equals(value)));
        }
    }
}
