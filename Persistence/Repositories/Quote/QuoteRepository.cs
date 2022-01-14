using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistence.Repositories.Quote
{
    public class QuoteRepository : Repository<Domain.Models.Quote>, IQuoteRepository
    {
        public QuoteRepository(QuoteContext context) : base(context)
        {

        }


        public Domain.Models.Quote getRandomQuote()
        {
            var idList = _context.Set<Domain.Models.Quote>().Select(x => x.Id).ToList();
            var id = new Random().Next(idList.Min(), idList.Max());
            return _context.Set<Domain.Models.Quote>().Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
