using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class Pds
    {  
        [Key]
        public int id { get; set; }
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
        public string Resp  { get; set; }
        public string path  { get; set; }
        public string Master { get; set; }


    }
}
