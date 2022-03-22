﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleProject.Models;

namespace TempleProject.Migrations
{
    [DbContext(typeof(TempleApplicationContext))]
    [Migration("20220322005154_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("TempleProject.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(15);

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentID");

                    b.ToTable("responses");
                });
#pragma warning restore 612, 618
        }
    }
}