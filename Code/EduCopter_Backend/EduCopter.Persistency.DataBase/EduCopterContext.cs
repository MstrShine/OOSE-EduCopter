﻿using EduCopter.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace EduCopter.Persistency.DataBase
{
    public class EduCopterContext : DbContext
    {
        private readonly DbContextOptions _options;

        private readonly string _connectionString;

        public EduCopterContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("EduCopterContext");
            DisableEntityTracking();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (_options == null)
            {
                optionsBuilder.UseSqlServer(_connectionString);

                if (Debugger.IsAttached)
                {
                    optionsBuilder.EnableSensitiveDataLogging();
                }
            }
        }

        #region Tables

        public DbSet<Student> Students { get; set; }

        #endregion

        public virtual void DisableEntityTracking()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}