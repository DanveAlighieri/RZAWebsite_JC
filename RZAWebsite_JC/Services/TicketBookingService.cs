﻿using Microsoft.EntityFrameworkCore;
using RZAWebsite_JC.Models;

namespace RZAWebsite_JC.Services
{
    public class TicketbookingService
    {
        private readonly TlS2300716RzaContext _context;
        public TicketbookingService(TlS2300716RzaContext context)
        {
            _context = context;
        }
        public async Task<List<Ticketbooking>> GetTicketbookingsAsync()
        {
            return await _context.Ticketbookings.ToListAsync();
        }
        public async Task AddTicketbookingAsync(Ticketbooking newTicketbooking)
        {
            await _context.Ticketbookings.AddAsync(newTicketbooking);
            await _context.SaveChangesAsync();
        }
    }
}