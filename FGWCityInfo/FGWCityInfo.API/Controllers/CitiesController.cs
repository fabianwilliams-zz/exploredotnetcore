using System;
using System.Collections.Generic;
using System.Linq;
using FGWCityInfo.API.Helper;
using Microsoft.AspNetCore.Mvc;

namespace FGWCityInfo.API.Controllers
{
    [Route("api/cities")]
    //[Route("api/[controller]")]
    public class CitiesController : Controller
    {
        [HttpGet("")]
        public IActionResult GetCities()
        {
            //return new JsonResult(new List<object>()
            //{
            //    new { id=1, Name="Washington DC"},
            //    new { id=2, Name="Laurel"}
            //});

            return Ok(CitiesDataStore.Current.Cities);
        }

		//[HttpGet("{id}")]
		//public JsonResult GetCIty(int id)
		//{
		//    return new JsonResult(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id));
		//}

		//will use IAction Result so i can show status code if nothing exists
		
        [HttpGet("{id}")]
		public IActionResult GetCIty(int id)
		{
            var myreturncity = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (myreturncity == null)
            {
                return NotFound();
            }
            return Ok(myreturncity);

		}

    }
}
