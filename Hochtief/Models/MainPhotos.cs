using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class MainPhotos
    {
        public int id { get; set;}
        public int itemno { get; set;}
        public string taskname { get; set;}
        public string reportID { get; set;}
        public DateTime ReportDate { get; set;}
        //Foto nachbarbeiten 
        public string fotosActivitySelection {get;set;}
    }
}
