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
    
    public partial class MBDEntities : DbContext
    {
        public MBDEntities()
            : base("name=MBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MDBLabour> MDBLabour { get; set; }
        public virtual DbSet<MDBSourceCompany> MDBSourceCompany { get; set; }
        public virtual DbSet<MDBSourceEquipment> MDBSourceEquipment { get; set; }
        public virtual DbSet<MDBSourceRole> MDBSourceRole { get; set; }
    }
}