﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelMvcProjeee.Models.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbOtelYeniEntities : DbContext
    {
        public DbOtelYeniEntities()
            : base("name=DbOtelYeniEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblHakkimda> TblHakkimda { get; set; }
        public virtual DbSet<Tbliletisim> Tbliletisim { get; set; }
        public virtual DbSet<TblMesaj> TblMesaj { get; set; }
        public virtual DbSet<TblYeniKayit> TblYeniKayit { get; set; }
        public virtual DbSet<TblMisafir> TblMisafir { get; set; }
        public virtual DbSet<TblRezervasyon> TblRezervasyon { get; set; }
        public virtual DbSet<TblOda> TblOda { get; set; }
        public virtual DbSet<TblOnRezervasyon> TblOnRezervasyon { get; set; }
        public virtual DbSet<TblMesaj2> TblMesaj2 { get; set; }
    }
}
