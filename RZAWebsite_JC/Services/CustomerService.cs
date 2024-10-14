using RZAWebsite_JC.Models;
using Microsoft.EntityFrameworkCore;

namespace RZAWebsite_JC.Services
{
    public class CustomerService
    {
        private readonly TlS2300716RzaContext _context;
        public CustomerService(TlS2300716RzaContext context)
        {
            _context = context;
        }
    }
}
