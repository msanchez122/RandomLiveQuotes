using System;
using System.Collections.Generic;
using System.Text;
using Application.Manager.Base;
using Domain.Models;
using Persistence.Repositories.QuoteRequest;

namespace Application.Manager
{
    public class QuoteRequestManager : BaseManager
    {
        private IQuoteRequestRepository _repository;
        public void create(QuoteRequest quoteRequest)
        {

        }
        public void approve(int id)
        {

        }
        public void refuse(int id)
        {

        }
        public void validate(QuoteRequest quoteRequest)
        {

        }
    }
}
