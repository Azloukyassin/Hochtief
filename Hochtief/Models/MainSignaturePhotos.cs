using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class MainSignaturePhotos
    {
        public int id {get; set;}
        public int ReportID {get; set;}
        public string SignaturePhoto {get; set;}
        public string SignedDate {get; set;}
    }
}
