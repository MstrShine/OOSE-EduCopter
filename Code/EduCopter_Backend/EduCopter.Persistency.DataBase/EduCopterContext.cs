using EduCopter.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Game;
using EduCopter.Persistency.DataBase.Domain.Geography;
using EduCopter.Persistency.DataBase.Domain.Mission;
using EduCopter.Persistency.DataBase.Domain.School;
using EduCopter.Persistency.DataBase.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Reflection;

namespace EduCopter.Persistency.DataBase
{
    public class EduCopterContext : DbContext
    {
        private readonly string _connectionString;

        public EduCopterContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("EduCopterContext");
            DisableEntityTracking();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // all loose mapping classes get chosen from assembly and activated
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(EduCopterContext)));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);

            if (Debugger.IsAttached)
            {
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        #region Tables

        public DbSet<EFStudent> Students { get; set; }
        public DbSet<EFTeacher> Teachers { get; set; }
        public DbSet<EFAdministrator> Administrators { get; set; }
        public DbSet<EFCity> Cities { get; set; }
        public DbSet<EFCountry> Countries { get; set; }
        public DbSet<EFProvince> Provinces { get; set; }
        public DbSet<EFMission> Missions { get; set; }
        public DbSet<EFStudentMission> StudentMissions { get; set; }
        public DbSet<EFMissionCity> MissionCities { get; set; }
        public DbSet<EFClass> Classes { get; set; }
        public DbSet<EFMap> Maps { get; set; }
        public DbSet<EFSchool> Schools { get; set; }
        public DbSet<EFGame> Games { get; set; }
        public DbSet<EFGameCity> GameCities { get; set; }

        #endregion

        public virtual void DisableEntityTracking()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
    }
}