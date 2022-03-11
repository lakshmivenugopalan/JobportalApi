using job_portal.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace job_portal.Core
{   


    public class JobServices : IJobServices
    {
        private readonly IMongoCollection<Job> _jobs;

    public JobServices(IDbClient dbClient)
        {
          _jobs= dbClient.GetJobCollection();
        }

        public Job AddJob(Job job)
        {
            _jobs.InsertOne(job);
            return job;
        }

        public List<Job> GetJobs()
        {

            return _jobs.Find(job => true).ToList(); 
        }
    }
}
