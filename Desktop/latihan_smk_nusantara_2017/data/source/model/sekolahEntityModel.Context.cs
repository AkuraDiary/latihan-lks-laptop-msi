﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace latihan_smk_nusantara_2017.data.source.model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_sekolahEntities : DbContext
    {
        public db_sekolahEntities()
            : base("name=db_sekolahEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<@class> classes { get; set; }
        public DbSet<detail_class> detail_class { get; set; }
        public DbSet<header_schedule> header_schedule { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<student_multi_schedule> student_multi_schedule { get; set; }
        public DbSet<subject> subjects { get; set; }
        public DbSet<user> users { get; set; }
    }
}