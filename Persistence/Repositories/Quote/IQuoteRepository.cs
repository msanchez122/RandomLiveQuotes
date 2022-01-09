using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;

namespace Persistence.Repositories.Quote
{
    public interface IQuoteRepository : IRepository<Domain.Models.Quote>
    {
        Domain.Models.Quote getRandomQuote();
    }
}
