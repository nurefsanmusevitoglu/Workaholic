using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workaholic.Models
{
    public class Employee:User
    {
        public Employee() 
        {
            AppliedJobs = new List<Job>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Job> AppliedJobs { get; set; }
    }
}