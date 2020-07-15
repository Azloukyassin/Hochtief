using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class Weather
    {
        public int id { get; set; }

        public string temp_time { get; set; }

        public string temp { get; set; }

        public string temp_condition {get;set;}

        public string datum {get; set;}
       
    }
}
