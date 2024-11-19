using Microsoft.EntityFrameworkCore;
using RZAWebsite_JC;
using RZAWebsite_JC.Models;


namespace RZAWebsite_JC.Services
{
    public class TicketService
    {
        private readonly TlS2300716RzaContext _context;
        public TicketService(TlS2300716RzaContext Context)
        {
            _context = Context;
        }
        public async Task<List<Ticket>> GetTicketsAsync()
        {
            return await _context.Tickets.ToListAsync();
        }
        public async Task AddTicketAsync(Ticket newTicket)
        {
            await _context.Tickets.AddAsync(newTicket);
            await _context.SaveChangesAsync();
        }
    }
}