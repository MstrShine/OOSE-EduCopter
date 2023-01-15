﻿// <auto-generated />
using System;
using EduCopter.Persistency.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EduCopter.Persistency.DataBase.Migrations
{
    [DbContext(typeof(EduCopterContext))]
    partial class EduCopterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Game.EFGame", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MissionId");

                    b.HasIndex("StudentId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Game.EFGameCity", b =>
                {
                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.HasKey("CityId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("GameCity");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Geography.EFCity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Population")
                        .HasColumnType("bigint");

                    b.Property<Guid>("ProvinceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Geography.EFCountry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Geography.EFMap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Map");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Geography.EFProvince", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CountryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("MapId");

                    b.ToTable("Province");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Mission.EFMission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MapId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Mission");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Mission.EFMissionCity", b =>
                {
                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("MissionOrder")
                        .HasColumnType("int");

                    b.HasKey("CityId", "MissionId");

                    b.HasIndex("MissionId");

                    b.ToTable("MissionCity");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Mission.EFStudentMission", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MissionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "MissionId");

                    b.HasIndex("MissionId");

                    b.ToTable("StudentMission");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.School.EFClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.School.EFSchool", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Users.EFAdministrator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Users.EFStudent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Users.EFTeacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId")
                        .IsUnique();

                    b.HasIndex("SchoolId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Game.EFGame", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Mission.EFMission", null)
                        .WithMany()
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Users.EFStudent", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Game.EFGameCity", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFCity", null)
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Game.EFGame", null)
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Geography.EFCity", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFMap", null)
                        .WithMany()
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFProvince", null)
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Geography.EFCountry", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFMap", null)
                        .WithMany()
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Geography.EFProvince", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFCountry", null)
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFMap", null)
                        .WithMany()
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Mission.EFMission", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFMap", null)
                        .WithMany()
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Users.EFTeacher", null)
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Mission.EFMissionCity", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Geography.EFCity", null)
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Mission.EFMission", null)
                        .WithMany()
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Mission.EFStudentMission", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Mission.EFMission", null)
                        .WithMany()
                        .HasForeignKey("MissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.Users.EFStudent", null)
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.School.EFClass", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.School.EFSchool", null)
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Users.EFStudent", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.School.EFClass", null)
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.School.EFSchool", null)
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("EduCopter.Persistency.DataBase.Domain.Users.EFTeacher", b =>
                {
                    b.HasOne("EduCopter.Persistency.DataBase.Domain.School.EFClass", null)
                        .WithOne()
                        .HasForeignKey("EduCopter.Persistency.DataBase.Domain.Users.EFTeacher", "ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EduCopter.Persistency.DataBase.Domain.School.EFSchool", null)
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
