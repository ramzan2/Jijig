﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MollaevYaroshevski.DataFolder
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AreaOfKnowLedge> AreaOfKnowLedge { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAndAreaOfKnowLedge> BookAndAreaOfKnowLedge { get; set; }
        public virtual DbSet<BookAndAuthor> BookAndAuthor { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Instance> Instance { get; set; }
        public virtual DbSet<PublisherHouse> PublisherHouse { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }
        public virtual DbSet<ReaderCardFile> ReaderCardFile { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
