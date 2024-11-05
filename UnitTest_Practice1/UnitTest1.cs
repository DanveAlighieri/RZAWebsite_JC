using Microsoft.EntityFrameworkCore;
using RZAWebsite_JC.Models;
using RZAWebsite_JC.Services;

namespace UnitTest_Practice1
{
    public class Tests
    {
        private TlS2300716RzaContext _context;
        private CustomerService _customerService;


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
            Customer tempcCustomer = new Customer()
            {
                Username = "admin",
                Password = "admin"
            };
            await _customerService.AddCustomerAsync(tempcCustomer);
            var result = await _context.Customers.FirstOrDefaultAsync(
                c => c.Username == "admin");
            Assert.IsNotNull(result);
        }
        [TearDown]
        public void TearDown() 
        {
            _context.Dispose();
        }
    }
}