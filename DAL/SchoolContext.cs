﻿using EECoreTutorials.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EECoreTutorials.DAL
{
        public class SchoolContext : DbContext
        {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Person> Persons { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server = .\SqlExpress; Database = SchoolDB; Trusted_Connection = True; ");
            }

            //Example of modelBuilder
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                //With this configurations I force to colocate the primary key manually "Just to Person's entity"
                modelBuilder.Entity<Person>().Property(p => p.pesonId).HasColumnName("Id").HasDefaultValue(0).IsRequired();

                //shadow property
                modelBuilder.Entity<Person>().Property<String>("Ocupacion");
                modelBuilder.Entity<Person>().Property<int>("Edad");
            }

        
        }

    }


