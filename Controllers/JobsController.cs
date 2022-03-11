using job_portal.Core;
using job_portal.Model;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_portal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    public class JobsController : ControllerBase
    {


        private readonly IJobServices _jobServices;

        public JobsController(IJobServices jobServices)
        {
            _jobServices = jobServices;
        }
        [HttpGet]
      
        public IActionResult GetJobs()
        {
            return Ok(_jobServices.GetJobs());
        }
        [HttpPost]
        public IActionResult AddJob(Job job) 
        {
            _jobServices.AddJob(job);
            return Ok(job);
        
        }

    }
    }
