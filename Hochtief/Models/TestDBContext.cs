using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hochtief.Models
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options):base(options)
        {
        }
        public DbSet<TestTabelle> testTabelle { get; set; }
        public DbSet<SourceRole> Source_Roles { get; set; }
        public DbSet<SourceCompany> sourceCompanies { get; set; }
        public DbSet<Weather> Weather {get; set;}
        public DbSet<DefinitionPDSLevel> definitionPDSLevels {get; set;}
        public DbSet<MainActivity> MainActivities {get; set;}
        public DbSet<MainActivitySubTasks> mainActivitySubTasks { get; set; }
        public DbSet<MainAdditionalWorks> mainAdditionalWorks { get; set; }
        public DbSet<MainEquipment> MainEquipment {get; set;}
        public DbSet<MainField2BIM> mainField2BIMs {get; set;}
        public DbSet<MainGeneral> mainGenerals {get;set;}
        public DbSet<MainPhotos> mainPhotos {get;set; }
        public DbSet<MainSignaturePhotos> mainSignaturePhotos { get; set; }
        public DbSet<Pds> pds {get;set;}
        public DbSet<Schedule> schedules {get;set;}
        public DbSet<LabourInternal> LabourInt {get;set;} 
        public DbSet<pdsJBJ> pdsJBJs {get; set;}
        public DbSet<DefinitionProjectTables> dtables {get;set;}
        public DbSet<ScheduleWoSubTask> scheduleWoSubs {get;set;}
        public DbSet<ConstructionDailyPhoto> constructionDailyPhotos { get; set; }

        /*public static implicit operator TestDBContext(ConstructionDailyPhoto v)
        {
            throw new NotImplementedException();
        }*/
    }
}
