﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FCDataEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBFClubsEntities : DbContext
    {
        public DBFClubsEntities()
            : base("name=DBFClubsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClubHasTitle> ClubHasTitles { get; set; }
        public virtual DbSet<Club> Clubs { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Federation> Federations { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<PlayerHasTitle> PlayerHasTitles { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
    }
}