﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MohamedAzloukSandboxEntities8 : DbContext
    {
        public MohamedAzloukSandboxEntities8()
            : base("name=MohamedAzloukSandboxEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<A40Labour> A40Labour { get; set; }
        public virtual DbSet<A40SourceCompany> A40SourceCompany { get; set; }
        public virtual DbSet<A40SourceEquipment> A40SourceEquipment { get; set; }
        public virtual DbSet<A40SourceRole> A40SourceRole { get; set; }
        public virtual DbSet<ICELabour> ICELabour { get; set; }
        public virtual DbSet<ICESourceCompany> ICESourceCompany { get; set; }
        public virtual DbSet<ICESourceEquipment> ICESourceEquipment { get; set; }
        public virtual DbSet<ICESourceRole> ICESourceRole { get; set; }
        public virtual DbSet<MDBLabour> MDBLabour { get; set; }
        public virtual DbSet<MDBSourceCompany> MDBSourceCompany { get; set; }
        public virtual DbSet<MDBSourceEquipment> MDBSourceEquipment { get; set; }
        public virtual DbSet<MDBSourceRole> MDBSourceRole { get; set; }
        public virtual DbSet<U3Labour> U3Labour { get; set; }
        public virtual DbSet<U3SourceCompany> U3SourceCompany { get; set; }
        public virtual DbSet<U3SourceEquipment> U3SourceEquipment { get; set; }
        public virtual DbSet<U3SourceRole> U3SourceRole { get; set; }
    }
}
