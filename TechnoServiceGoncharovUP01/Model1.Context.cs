﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnoServiceGoncharovUP01
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        private static Entities _context;
        public Entities()
            : base("name=Entities")
        {
        }

        public static Entities GetContext()
        {
            if (_context == null) _context = new Entities();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<FaultType> FaultType { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Priority> Priority { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<RequestLog> RequestLog { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Technician> Technician { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
