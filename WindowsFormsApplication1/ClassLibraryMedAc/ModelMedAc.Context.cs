﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryMedAc
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelMedAcContainer : DbContext
    {
        public ModelMedAcContainer()
            : base("name=ModelMedAcContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Utente> UtenteSet { get; set; }
        public virtual DbSet<Valores> ValoresSet { get; set; }
        public virtual DbSet<Alertas> AlertasSet { get; set; }
    }
}