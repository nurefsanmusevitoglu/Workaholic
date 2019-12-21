using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Workaholic.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Allday { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime FinishTime { get; set; }
    }
}