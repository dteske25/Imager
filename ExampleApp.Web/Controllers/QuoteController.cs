using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleApp.Core.Engines;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleApp.Web.Controllers
{
    [Route("api/Quote")]
    public class QuoteController : Controller
    {
        private readonly IQuoteEngine _quoteEngine;

        public QuoteController(IQuoteEngine quoteEngine)
        {
            _quoteEngine = quoteEngine;
        }
        
    }
}