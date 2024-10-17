using RZAWebsite_JC;
using Microsoft.EntityFrameworkCore;
using RZAWebsite_JC.Models;

namespace RZAWebsite_JC.Services
{
    public class CustomerService
    {
        private readonly TlS2300716RzaContext _context;
        public CustomerService(TlS2300716RzaContext context)
        {
            _context = context;
        }
        public async Task AddCustomerAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

    }
}
