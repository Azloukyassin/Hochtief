using BigApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {
        }
        public DbSet<TestTabelle> testTabelle {get; set;}
        public DbSet<SourceRole> Source_Roles {get; set;}
        public DbSet<SourceCompany> sourceCompanies {get; set;}
        public DbSet<Weather> Weather {get; set;}
        public DbSet<LabourInternal> LabourInt {get; set;}
       //public DbSet<Labour> labours {get;set;}
        public DbSet<SourceEquipment> sourceEquipment {get; set;}
       //public DbSet<SourceLabour> sourceLabours { get; set;}
     //   public DbSet<SourceStaff> sourceStaffs {get;set;} 
    }
}
