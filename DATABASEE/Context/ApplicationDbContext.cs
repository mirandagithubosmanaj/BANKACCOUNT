﻿using DATABASEE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASEE.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Për të përdorur tabelën "Deposits"
        //public DbSet<Deposits> Deposits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        

            modelBuilder.Entity<Deposits>();
            modelBuilder.Entity<Transfers>();
            modelBuilder.Entity<Users>();
            modelBuilder.Entity<UserRoles>();
            modelBuilder.Entity<Withdraws>();





        }
    }
}





    

