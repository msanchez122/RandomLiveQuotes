using Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Manager.Base
{
    public class BaseManager 
    {
        protected QuoteContext context;

        public BaseManager()
        {
            context = new QuoteContext();
        }
    }
}
