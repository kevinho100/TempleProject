﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleProject.Models;

namespace TempleProject.Migrations
{
    [DbContext(typeof(TempleApplicationContext))]
    partial class TempleApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<int>("TimeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppointmentID");

                    b.HasIndex("TimeId");

                    b.ToTable("responses");
                });

            modelBuilder.Entity("TempleProject.Models.Time", b =>
                {
                    b.Property<int>("TimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsTaken")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TimeSlot")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TimeId");

                    b.ToTable("times");

                    b.HasData(
                        new
                        {
                            TimeId = 1,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "8:00AM - 9:00AM"
                        },
                        new
                        {
                            TimeId = 2,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "9:00AM - 10:00AM"
                        },
                        new
                        {
                            TimeId = 3,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "10:00AM - 11:00AM"
                        },
                        new
                        {
                            TimeId = 4,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "11:00AM - 12:00PM"
                        },
                        new
                        {
                            TimeId = 5,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "12:00PM - 1:00PM"
                        },
                        new
                        {
                            TimeId = 6,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "1:00PM - 2:00PM"
                        },
                        new
                        {
                            TimeId = 7,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "2:00PM - 3:00PM"
                        },
                        new
                        {
                            TimeId = 8,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "3:00PM - 4:00PM"
                        },
                        new
                        {
                            TimeId = 9,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "4:00PM - 5:00PM"
                        },
                        new
                        {
                            TimeId = 10,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "5:00PM - 6:00PM"
                        },
                        new
                        {
                            TimeId = 11,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "6:00PM - 7:00PM"
                        },
                        new
                        {
                            TimeId = 12,
                            Day = "Monday",
                            IsTaken = false,
                            TimeSlot = "8:00PM - 9:00PM"
                        },
                        new
                        {
                            TimeId = 13,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "8:00AM - 9:00AM"
                        },
                        new
                        {
                            TimeId = 14,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "9:00AM - 10:00AM"
                        },
                        new
                        {
                            TimeId = 15,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "10:00AM - 11:00AM"
                        },
                        new
                        {
                            TimeId = 16,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "11:00AM - 12:00PM"
                        },
                        new
                        {
                            TimeId = 17,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "12:00PM - 1:00PM"
                        },
                        new
                        {
                            TimeId = 18,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "1:00PM - 2:00PM"
                        },
                        new
                        {
                            TimeId = 19,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "2:00PM - 3:00PM"
                        },
                        new
                        {
                            TimeId = 20,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "3:00PM - 4:00PM"
                        },
                        new
                        {
                            TimeId = 21,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "4:00PM - 5:00PM"
                        },
                        new
                        {
                            TimeId = 22,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "5:00PM - 6:00PM"
                        },
                        new
                        {
                            TimeId = 23,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "6:00PM - 7:00PM"
                        },
                        new
                        {
                            TimeId = 24,
                            Day = "Tuesday",
                            IsTaken = false,
                            TimeSlot = "8:00PM - 9:00PM"
                        },
                        new
                        {
                            TimeId = 25,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "8:00AM - 9:00AM"
                        },
                        new
                        {
                            TimeId = 26,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "9:00AM - 10:00AM"
                        },
                        new
                        {
                            TimeId = 27,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "10:00AM - 11:00AM"
                        },
                        new
                        {
                            TimeId = 28,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "11:00AM - 12:00PM"
                        },
                        new
                        {
                            TimeId = 29,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "12:00PM - 1:00PM"
                        },
                        new
                        {
                            TimeId = 30,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "1:00PM - 2:00PM"
                        },
                        new
                        {
                            TimeId = 31,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "2:00PM - 3:00PM"
                        },
                        new
                        {
                            TimeId = 32,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "3:00PM - 4:00PM"
                        },
                        new
                        {
                            TimeId = 33,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "4:00PM - 5:00PM"
                        },
                        new
                        {
                            TimeId = 34,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "5:00PM - 6:00PM"
                        },
                        new
                        {
                            TimeId = 35,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "6:00PM - 7:00PM"
                        },
                        new
                        {
                            TimeId = 36,
                            Day = "Wednesday",
                            IsTaken = false,
                            TimeSlot = "8:00PM - 9:00PM"
                        },
                        new
                        {
                            TimeId = 37,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "8:00AM - 9:00AM"
                        },
                        new
                        {
                            TimeId = 38,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "9:00AM - 10:00AM"
                        },
                        new
                        {
                            TimeId = 39,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "10:00AM - 11:00AM"
                        },
                        new
                        {
                            TimeId = 40,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "11:00AM - 12:00PM"
                        },
                        new
                        {
                            TimeId = 41,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "12:00PM - 1:00PM"
                        },
                        new
                        {
                            TimeId = 42,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "1:00PM - 2:00PM"
                        },
                        new
                        {
                            TimeId = 43,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "2:00PM - 3:00PM"
                        },
                        new
                        {
                            TimeId = 44,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "3:00PM - 4:00PM"
                        },
                        new
                        {
                            TimeId = 45,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "4:00PM - 5:00PM"
                        },
                        new
                        {
                            TimeId = 46,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "5:00PM - 6:00PM"
                        },
                        new
                        {
                            TimeId = 47,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "6:00PM - 7:00PM"
                        },
                        new
                        {
                            TimeId = 48,
                            Day = "Thursday",
                            IsTaken = false,
                            TimeSlot = "8:00PM - 9:00PM"
                        },
                        new
                        {
                            TimeId = 49,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "8:00AM - 9:00AM"
                        },
                        new
                        {
                            TimeId = 50,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "9:00AM - 10:00AM"
                        },
                        new
                        {
                            TimeId = 51,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "10:00AM - 11:00AM"
                        },
                        new
                        {
                            TimeId = 52,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "11:00AM - 12:00PM"
                        },
                        new
                        {
                            TimeId = 53,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "12:00PM - 1:00PM"
                        },
                        new
                        {
                            TimeId = 54,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "1:00PM - 2:00PM"
                        },
                        new
                        {
                            TimeId = 55,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "2:00PM - 3:00PM"
                        },
                        new
                        {
                            TimeId = 56,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "3:00PM - 4:00PM"
                        },
                        new
                        {
                            TimeId = 57,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "4:00PM - 5:00PM"
                        },
                        new
                        {
                            TimeId = 58,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "5:00PM - 6:00PM"
                        },
                        new
                        {
                            TimeId = 59,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "6:00PM - 7:00PM"
                        },
                        new
                        {
                            TimeId = 60,
                            Day = "Friday",
                            IsTaken = false,
                            TimeSlot = "8:00PM - 9:00PM"
                        },
                        new
                        {
                            TimeId = 61,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "8:00AM - 9:00AM"
                        },
                        new
                        {
                            TimeId = 62,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "9:00AM - 10:00AM"
                        },
                        new
                        {
                            TimeId = 63,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "10:00AM - 11:00AM"
                        },
                        new
                        {
                            TimeId = 64,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "11:00AM - 12:00PM"
                        },
                        new
                        {
                            TimeId = 65,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "12:00PM - 1:00PM"
                        },
                        new
                        {
                            TimeId = 66,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "1:00PM - 2:00PM"
                        },
                        new
                        {
                            TimeId = 67,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "2:00PM - 3:00PM"
                        },
                        new
                        {
                            TimeId = 68,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "3:00PM - 4:00PM"
                        },
                        new
                        {
                            TimeId = 69,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "4:00PM - 5:00PM"
                        },
                        new
                        {
                            TimeId = 70,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "5:00PM - 6:00PM"
                        },
                        new
                        {
                            TimeId = 71,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "6:00PM - 7:00PM"
                        },
                        new
                        {
                            TimeId = 72,
                            Day = "Saturday",
                            IsTaken = false,
                            TimeSlot = "8:00PM - 9:00PM"
                        },
                        new
                        {
                            TimeId = 73,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "8:00AM - 9:00AM"
                        },
                        new
                        {
                            TimeId = 74,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "9:00AM - 10:00AM"
                        },
                        new
                        {
                            TimeId = 75,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "10:00AM - 11:00AM"
                        },
                        new
                        {
                            TimeId = 76,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "11:00AM - 12:00PM"
                        },
                        new
                        {
                            TimeId = 77,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "12:00PM - 1:00PM"
                        },
                        new
                        {
                            TimeId = 78,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "1:00PM - 2:00PM"
                        },
                        new
                        {
                            TimeId = 79,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "2:00PM - 3:00PM"
                        },
                        new
                        {
                            TimeId = 80,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "3:00PM - 4:00PM"
                        },
                        new
                        {
                            TimeId = 81,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "4:00PM - 5:00PM"
                        },
                        new
                        {
                            TimeId = 82,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "5:00PM - 6:00PM"
                        },
                        new
                        {
                            TimeId = 83,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "6:00PM - 7:00PM"
                        },
                        new
                        {
                            TimeId = 84,
                            Day = "Sunday",
                            IsTaken = false,
                            TimeSlot = "8:00PM - 9:00PM"
                        });
                });

            modelBuilder.Entity("TempleProject.Models.ApplicationResponse", b =>
                {
                    b.HasOne("TempleProject.Models.Time", "Time")
                        .WithMany()
                        .HasForeignKey("TimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
