using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Repositories.QuoteRequest.cs
{
    public class QuoteRequestRepository : Repository<Domain.Models.QuoteRequest>, IQuoteRequestRepository
    {
        public QuoteRequestRepository(QuoteContext context) : base(context)
        {
        }
        public void Approve(int id)
        {
            var quoteRequest = _context.QuoteRequests.Find(id);
            quoteRequest.Status = Domain.Models.QuoteRequest.STATUS_APPROVED;
            _context.SaveChanges();
        }

        public void Refuse(int id)
        {
            var quoteRequest = _context.QuoteRequests.Find(id);
            quoteRequest.Status = Domain.Models.QuoteRequest.STATUS_REJECTED;
            _context.SaveChanges();
        }
    }
}
