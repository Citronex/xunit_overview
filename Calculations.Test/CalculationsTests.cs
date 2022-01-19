using Xunit;
using System.Collections.Generic;
namespace Calculations.Test
{
    public class CalculationsTests
    {
        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoesNotIncludeZero()
        {
            var calc = new Calculations();
            Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboIncludes13()
        {
            var calc = new Calculations();
            Assert.Contains(13, calc.FiboNumbers);
        }

        [Fact]
        [Trait("Category", "Fibo")]
        public void FiboDoenNotIncludes4()
        {
            var calc = new Calculations();
            Assert.DoesNotContain(4, calc.FiboNumbers);
        }

        [Fact]
        public void CheckCollection()
        {
            var expectedCollection = new List<int>() { 1, 1, 2, 3, 5, 8, 13 };
            var calc = new Calculations();
            Assert.Equal(expectedCollection, calc.FiboNumbers);
        }

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            var calc = new Calculations();
            var result = calc.IsOdd(3);
            Assert.True(result);
        }
        
        [Fact]
        public void IsOdd_GiveEvenValue_ReturnsFalse()
        {
            var calc = new Calculations();
            var result = calc.IsOdd(2);
            Assert.False(result);
        }

        //using inline data
        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            var calc = new Calculations();
            Assert.Equal(expected, calc.IsOdd(value));
        }
        
        //sharing test data
        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEvenSharedTestData(int value, bool expected)
        {
            var calc = new Calculations();
            Assert.Equal(expected, calc.IsOdd(value));
        }
        
        //passing parameters to unit test from external resource
        [Theory]
        [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
        public void IsOdd_TestOddAndEvenSharedExternalData(int value, bool expected)
        {
            var calc = new Calculations();
            Assert.Equal(expected, calc.IsOdd(value));
        }
        
        //passing test data across multiple unit test methods with custom attributes
        [Theory]
        [IsOddOrEvenData]
        public void IsOdd_TestOddAndEvenSharedCustomAttribute(int value, bool expected)
        {
            var calc = new Calculations();
            Assert.Equal(expected, calc.IsOdd(value));
        }
    }
}
