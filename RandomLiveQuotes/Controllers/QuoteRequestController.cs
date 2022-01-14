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
    public class QuoteRequestController : BaseController
    {
        private readonly ILogger<QuoteRequestController> _logger;



    }
}
