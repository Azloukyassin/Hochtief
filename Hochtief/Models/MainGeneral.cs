using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class MainGeneral
    {
        public int id { get; set; }
        public int itemno {get;set;}
        public int rowid { get; set;}
        public int formversion { get; set;}
        public string taskname { get; set;}
        public string usemail { get; set;}
        public string bautagebuchAutoPolier { get; set;}
        public string reportID { get; set;}
        public string ReportDate { get; set; }
        public string ReportStartTime { get; set;}
        public string ReportEndTime { get; set; }
        public double ReportBreakTimeNum { get; set;}
        public double ReportHours { get; set;}
        public string FreigabeDate { get; set;}
        public string FreigabeAutor { get; set; }
        public string FreigabeDate1 { get; set;}
        public string genehmigungAutor { get; set;}



    }
}
