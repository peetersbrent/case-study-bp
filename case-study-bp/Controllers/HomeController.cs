using case_study_bp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Contentful.Core;
using Contentful.Core.Search;
using Contentful.Core.Models;
using System.Xml.Linq;

namespace case_study.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IContentfulClient _client;

        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _client = client;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {

            var builder = QueryBuilder<VoetbalWedstrijd>.New.ContentTypeIs("voetbalwedstrijd");
            var wedstrijd = await _client.GetEntries(builder);
            return View(wedstrijd);
        }

        public async Task<IActionResult> History()
        {
            var builder = QueryBuilder<History>.New.ContentTypeIs("history");
            var history = await _client.GetEntries(builder);
            return View(history);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

