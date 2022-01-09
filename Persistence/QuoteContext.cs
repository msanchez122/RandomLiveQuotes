using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Persistence
{
    public class QuoteContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<QuoteRequest> QuoteRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-MK8LK7C;Database=RandomLiveQuotes;Trusted_Connection=True;MultipleActiveResultSets=True;");

        }
    }
}
