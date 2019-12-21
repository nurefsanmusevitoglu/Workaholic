using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Workaholic.Models
{
    public class Job
    {
        public Job()
        {
            AppliedEmployees = new List<Employee>();
        }

        public int Id { get; set; }
        [Required]
        [DisplayName("Job Title")]
        public string JobTitle { get; set; }
        [Required]
        [DisplayName("Job Description")]
        public string JobDescription { get; set; }
        [Required]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }

        public Employer Employer { get; set; }
        public List<Employee> AppliedEmployees { get; set; }
    }
}