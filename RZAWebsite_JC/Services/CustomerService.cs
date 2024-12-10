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

        public async Task<Customer> LogIn(Customer customer)
        {
            return await _context.Customers.FirstOrDefaultAsync(
                c => c.Username == customer.Username &&
                c.Password == customer.Password);
        }


        //this is modifies the customers password
        public async Task ChangePasswordAsync(int customerId, string hashedOldPassword, string hashedNewPassword) 
        {
            Customer? customer = await _context.Customers.SingleOrDefaultAsync(
                c => c.CustomerId == customerId && c.Password == hashedOldPassword);
            try
            {
                customer.Password = hashedNewPassword;
                await _context.SaveChangesAsync();
                if (customer != null)
                {
                    customer.Password = hashedNewPassword;
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
