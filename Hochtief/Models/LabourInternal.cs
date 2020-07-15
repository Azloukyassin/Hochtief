using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class LabourInternal
    {
        public int id { get; set; }
        public int itemno { get; set; }
        public int rowid { get; set;}
        public int formversion { get; set;}
        public string activity { get; set;}
        public double hoursActivity { get; set; }
        public string posht { get; set; }
    }
}
