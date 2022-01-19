
using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Calculations.Test
{

    public class CalculatorFixture : IDisposable
    {
        public Calculator Calc => new Calculator();
        public void Dispose()
        {
            //Clean
        }
    }
    public class CalculatorTest: IClassFixture<CalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly CalculatorFixture _calculatorFixture;
        private readonly MemoryStream memoryStream;

        public CalculatorTest(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
        {
            _testOutputHelper = testOutputHelper;
            _calculatorFixture = calculatorFixture;
            _testOutputHelper.WriteLine("Constructor");

            memoryStream = new MemoryStream();

        }
        
        [Fact]
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            _testOutputHelper.WriteLine("Add Given Two Int Values Returns Int");
            var calc = _calculatorFixture.Calc;
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenTwoIntValues_ReturnsDouble()
        {
            //var calc = new Calculator();
            _testOutputHelper.WriteLine("Add Double Given Two Int Values Returns Double");
            var calc = _calculatorFixture.Calc;
            var result = calc.AddDouble(1.2, 3.6);
            Assert.Equal(4.8, result, 1);
        }

        public void Dispose()
        {
            memoryStream.Close();
        }
    }
}
