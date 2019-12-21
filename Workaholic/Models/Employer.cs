using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workaholic.Models
{
    public class Employer:User
    {
        public Employer() 
        {
            PostedJobs = new List<Job>();
        }

        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        public string About { get; set; }

        public List<Job> PostedJobs { get; set; }
    }
}