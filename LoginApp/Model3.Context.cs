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
    using LoginApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class MohamedAzloukSandboxTest : DbContext
    {
        public MohamedAzloukSandboxTest()
            : base("name=MohamedAzloukSandboxTest")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public virtual DbSet<Labourtest> Labourtest { get; set; }
        public virtual DbSet<SourceCompanyTest> SourceCompanyTest { get; set; }
        public virtual DbSet<SourceEquipmenttest> SourceEquipmenttest { get; set; }
        public virtual DbSet<SourceRolTest> SourceRolTest { get; set; }
        
    }
}
