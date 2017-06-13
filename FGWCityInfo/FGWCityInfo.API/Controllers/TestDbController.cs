using System;
using FGWCityInfo.API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FGWCityInfo.API.Controllers
{
    public class TestDbController : Controller
    {
        private CityInfoContext _ctx;

        public TestDbController(CityInfoContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }

    }
}
