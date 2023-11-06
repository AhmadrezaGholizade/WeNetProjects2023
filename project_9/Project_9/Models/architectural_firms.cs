using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_9.Models
{
    public class architectural_firms
    {
        // Firm's Attributes
        public int ID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Founder { get; set; }
        public string Country { get; set; }
        public List<string> Projects { get; set; }
        public string ContactInfo { get; set; }
    }
}