using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http;
using System.Diagnostics;

namespace WebAppMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
public class ValuesController : Controller
    {
        List<Source> sources = new List<Source>(2)
        { new Source {id = 1, title = " BitStamp", endpoint = "https://www.bitstamp.net/api/v2/ticker/btcusd/" },
          new Source {id = 2, title = " Bitfinex", endpoint = "https://api.bitfinex.com/v1/pubticker/btcusd" },
        };

        static Source s = new Source();

        private readonly IHttpClientFactory _httpClientFactory;

        [HttpGet]
        public IEnumerable<Source> GetSources()
        {
            return sources;
        }
    }
}
