﻿using Application.Manager.Base;
using Domain.Models;
using Persistence.Repositories.Quote;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Manager
{
    public class QuoteManager : BaseManager
    { 
        private IQuoteRepository _repository;

        public QuoteManager()
        {
            _repository = new QuoteRepository(this.context);
        }

        public void create(Quote quote)
        {
            
        }

        public Quote getRandomQuote()
        {
            return new Quote();
        }

    }
}
