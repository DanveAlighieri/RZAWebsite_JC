using Microsoft.EntityFrameworkCore;
using RZAWebsite_JC;
using RZAWebsite_JC.Models;

namespace RZAWebsite_JC.Services
{
    public class AttractionService
    {
        private readonly TlS2300716RzaContext _context;
        public AttractionService(TlS2300716RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Attraction>> GetAttractionsAsync()
        {
            return await _context.Attractions.ToListAsync();
        }
}
}