using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class MainAdditionalWorks
    {
        public int id { get; set; }
        public int itemno { get; set; }
        public int rowid { get; set; }
        public int eventCategory { get; set; }
        public string pds01 { get; set; }
        public string pds02 { get; set; }
        public string additionalWorksPds04 { get; set; }
        public string additionalWorksPds05 { get; set; }
        public string additionalWorksPds06 { get; set; }
        public string additionalWorksActivity { get; set; }
        public string eventHours { get; set; }
        public string additionalWorksTxt { get; set; }
    }
}
