﻿// <auto-generated />
using System;
using HTT.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HTT.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HTT.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EmpId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HTT.Models.HealthTrack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ContactWithCovidPeople");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("LocationId");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool>("PreExistHealthIssue");

                    b.Property<string>("ResidentialAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("SampleDate");

                    b.Property<int>("Status");

                    b.Property<bool>("TravelOustSideInLast15Days");

                    b.Property<int>("ZoneId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("LocationId");

                    b.HasIndex("ZoneId");

                    b.ToTable("HealthTrack");
                });

            modelBuilder.Entity("HTT.Models.HealthTrackQuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HealthTrackId");

                    b.Property<int>("QuestionId");

                    b.Property<string>("value");

                    b.HasKey("Id");

                    b.HasIndex("HealthTrackId");

                    b.HasIndex("QuestionId");

                    b.ToTable("HealthTrackQuestionAnswer");
                });

            modelBuilder.Entity("HTT.Models.HealthTrackSymptom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HealthTrackId");

                    b.Property<int>("SymptomId");

                    b.Property<bool>("value");

                    b.HasKey("Id");

                    b.HasIndex("HealthTrackId");

                    b.HasIndex("SymptomId");

                    b.ToTable("HealthTrackSymptom");
                });

            modelBuilder.Entity("HTT.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Order");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tricity (CHD/PKL/Mohali)",
                            Order = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Outside Tricity",
                            Order = 2,
                            Status = 0
                        });
                });

            modelBuilder.Entity("HTT.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Order");

                    b.Property<int>("Status");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Question");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Please give a count of family members in your house?",
                            Order = 1,
                            Status = 0,
                            Type = "Input"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Is any Of them under 5 years or over 65 years in age?",
                            Order = 2,
                            Status = 0,
                            Type = "CheckBox"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Has any Of them presented Covid-19 related symptoms recently?",
                            Order = 3,
                            Status = 0,
                            Type = "CheckBox"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Has any Of them had any recent travel — abroad, inter-state or inter or district ? ",
                            Order = 4,
                            Status = 0,
                            Type = "CheckBox"
                        });
                });

            modelBuilder.Entity("HTT.Models.Symptom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Order");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Symptom");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fever",
                            Order = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shortness Of Breath",
                            Order = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dry Cough",
                            Order = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Running Nose",
                            Order = 4,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Sore Throat",
                            Order = 5,
                            Status = 0
                        });
                });

            modelBuilder.Entity("HTT.Models.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Order");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Zone");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Containment Zone",
                            Order = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Red Zone",
                            Order = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Green Zone",
                            Order = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Orange Zone",
                            Order = 4,
                            Status = 0
                        });
                });

            modelBuilder.Entity("HTT.Models.HealthTrack", b =>
                {
                    b.HasOne("HTT.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HTT.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HTT.Models.Zone", "Zone")
                        .WithMany()
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTT.Models.HealthTrackQuestionAnswer", b =>
                {
                    b.HasOne("HTT.Models.HealthTrack", "HealthTrack")
                        .WithMany()
                        .HasForeignKey("HealthTrackId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HTT.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HTT.Models.HealthTrackSymptom", b =>
                {
                    b.HasOne("HTT.Models.HealthTrack", "HealthTrack")
                        .WithMany()
                        .HasForeignKey("HealthTrackId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HTT.Models.Symptom", "Symptom")
                        .WithMany()
                        .HasForeignKey("SymptomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
