using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Main.Models
{
    public class Chart
    {
        public string[] labels { get; set; }
        public List<Dataset> datasets { get; set; }
    }
   
}