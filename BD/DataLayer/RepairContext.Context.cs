﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RepairContext : DbContext
    {
        public RepairContext()
            : base("name=RepairContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivitiesTypesDictionary> ActivitiesTypesDictionaries { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Object> Objects { get; set; }
        public virtual DbSet<ObjectType> ObjectTypes { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
}
