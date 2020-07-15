using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class MainField2BIM
    {
        public int id { get; set; }
        public int itemno { get; set; }
        public int formversion { get; set;}
        public double latitude { get; set;}
        public double longitude { get; set;}
        public string starttime { get; set; }
        public string completetime { get; set;}
        public string userfirstname { get; set;}
        public string userlastname { get; set;}
        public string projectDef { get; set;}
        public string headerPds01 { get; set;}
        public string headerPds02 { get; set;}
        public string headerPds03 { get; set;}
        public string headerPds04 { get; set;}
        public string reportID { get; set;}
        public string ReportDate { get;set;}
        public string ReportStartTime { get; set;}
        public string ReportEndTime { get; set; }
        public double ReportBreakTimeNumeric { get; set;}
        public string timeRang { get; set;}
        public int TimeHours { get; set;}
        public int ReportHours { get; set; }
        public string pds01 { get; set;}
        public string pds01Desc { get; set;}
        public string TempTime { get; set;}
        public string ApiKey { get; set;}


    }
}
