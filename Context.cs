using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations.History;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RSDP.Models
{

    public class OracleDbContext : DbContext
    {
        public DbSet<Account_Passenger> Account_Passengers { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<AccountList> AccountLists { get; set; }
        public DbSet<CostTable> CostTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.HasDefaultSchema("C##TESTUSER");
            modelBuilder.Entity<Passenger>()
                
        }
        
    }
}