using RZAWebsite_JC.Models;
using Microsoft.EntityFrameworkCore;

namespace RZAWebsite_JC.Services
{
    public class OLD_CustomerService
    {
        private readonly TlS2300716RzaContext _context;
        public OLD_CustomerService(TlS2300716RzaContext context)
        {
            _context = context;
        }
    }
}
