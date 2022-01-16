using Application.Manager;
using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomLiveQuotes.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RandomLiveQuotes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuoteController : BaseController
    {
        private readonly ILogger<QuoteController> _logger;
        private readonly QuoteManager _manager;

        public QuoteController()
        {
            _manager = new QuoteManager();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Quote> Create(Quote quote)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Quote> getRandomQuestion()
        {
           var quote = _manager.getRandomQuote();
           return Ok(quote);
        }
    }
}
