using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SafeAutoKada.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrivingReport: ControllerBase
    {
      

        


        [HttpGet]
        public string Get()
        {
            return "Steve";
        }
         
    }
}
