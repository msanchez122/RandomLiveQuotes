using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Repositories.QuoteRequest.cs
{
    public interface IQuoteRequestRepository : IRepository<Domain.Models.QuoteRequest>
    {
        void Approve(int id);
        void Refuse(int id);
    }
}
