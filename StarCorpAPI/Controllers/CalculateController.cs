using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarCorp.Business;

namespace StarCorpAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculateController : ControllerBase
    {
        // GET: api/Calculate
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Not Implemented"};
        }

        [HttpPost]
        public string Post(int value)
        {
            Calculate calc = new Calculate();

            var result = calc.Calculation(value);

            return result;
        }

    }
}
