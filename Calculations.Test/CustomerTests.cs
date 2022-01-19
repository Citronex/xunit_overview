using System;
using Xunit;
namespace Calculations.Test
{
    [Collection(("Customer"))]
    public class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
        //Asserting a Range of Values

        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = _customerFixture.Cust;
            Assert.NotNull(customer.Name);
            //not null OR empty
            Assert.False(string.IsNullOrEmpty(customer.Name));

        }
        [Fact]
        public void CheckLegitForDiscount()
        {
            var customer = _customerFixture.Cust;
            Assert.InRange(customer.Age, 25, 40);
        }

        [Fact]
        public void GetOrdersByNameNotNull()
        {
            var customer = _customerFixture.Cust;
            var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(null));
            Assert.Equal("Hola", exceptionDetails.Message);
        }

        [Fact]
        public void LoyalCustomerForOrderGreaterThan100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(101);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
            Assert.Equal(10, loyalCustomer.Discount);
        }
        
        
        

    }
}
