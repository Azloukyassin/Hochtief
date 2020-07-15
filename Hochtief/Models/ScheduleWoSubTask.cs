using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class ScheduleWoSubTask
    {
        public int id {get; set;}
        public string TaskName {get; set;}
        public string LocL1 {get; set;}
        public string LocL2 {get;set;}
        public string LocL3 {get; set;}
        public string pdsL1 {get; set;}
        public string pdsL2 {get; set;}
        public string pdsL3 {get; set;}
        public string pdsL4 {get; set;}
        public string level {get; set;}
        public string path {get;set;}
        public string Master {get;set; }
        public string TaskOriginal {get; set; }
        public string pdsDescr {get;set;}
        public string Bautagesbericht {get;set;}
    }
}
