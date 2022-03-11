using job_portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_portal.Core
{
  public  interface IJobServices
    {

        List<Job> GetJobs();
        Job AddJob(Job job);

    }
}
