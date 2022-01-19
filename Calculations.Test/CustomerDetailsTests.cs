using Xunit;

namespace Calculations.Test
{   [Collection(("Customer"))]
    public class CustomerDetailsTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        [Fact]
        public void GetFullNae_GivenFirstAndLastName_ReturnFullName()
        {
            var customer = _customerFixture.Cust;
            Assert.Equal("Francisco Mejias", customer.GetFullName("Francisco", "Mejias"));
        }
    }
}