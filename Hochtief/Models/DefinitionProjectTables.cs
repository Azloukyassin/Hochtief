using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class DefinitionProjectTables
    {
        public int id { get; set; }
        public string sptable { get; set; }
        public string accessTable { get; set; }
        public string SqlTable {get;set;}
    }
}
