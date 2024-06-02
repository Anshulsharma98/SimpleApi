using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "Anshul", "Sharma" };
        }

        // GET: api/values/5
        public string Get(int id)
        {
            return "Anshul";
        }

  }
}