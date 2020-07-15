using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class Schedule
    { 
        [Key]
        public int id { get; set; }
        public int IDTask { get; set; }
        public string TaskName { get; set; }
        public string LocL1 { get; set; }
        public string LocL2 { get; set; }
        public string LocL3 { get; set; }
        public string pdsL1 { get; set; }
        public string pdsL2 { get; set; }
        public string pdsL3 { get; set; }
        public string pdsL4 { get; set; }
        public string pdsL5 { get; set; }
        public string Descr { get; set; }
        public string Level { get; set; }
        public string Resp { get; set; }
        public string path { get; set; }
        public string Master { get; set;}
        public string PdsID { get; set;}
        public string TaskOriginal { get; set;}
        public string pds02Descr { get; set;}
        public string FullDescr { get; set;}
        public string Bautagesbericht { get; set;}

    }
}
