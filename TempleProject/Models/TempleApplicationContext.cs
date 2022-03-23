using System;
using Microsoft.EntityFrameworkCore;

namespace TempleProject.Models
{
    public class TempleApplicationContext : DbContext
    {
        //Constructor
        public TempleApplicationContext(DbContextOptions<TempleApplicationContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)

        {

            mb.Entity<Time>().HasData(

                new Time
                {
                    TimeId = 1,
                    TimeSlot = "8:00AM - 9:00AM",
                    Day= "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 2,
                    TimeSlot = "9:00AM - 10:00AM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 3,
                    TimeSlot = "10:00AM - 11:00AM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 4,
                    TimeSlot = "11:00AM - 12:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 5,
                    TimeSlot = "12:00PM - 1:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 6,
                    TimeSlot = "1:00PM - 2:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 7,
                    TimeSlot = "2:00PM - 3:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 8,
                    TimeSlot = "3:00PM - 4:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 9,
                    TimeSlot = "4:00PM - 5:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 10,
                    TimeSlot = "5:00PM - 6:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 11,
                    TimeSlot = "6:00PM - 7:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },


                new Time
                {
                    TimeId = 12,
                    TimeSlot = "8:00PM - 9:00PM",
                    Day = "Monday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 13,
                    TimeSlot = "8:00AM - 9:00AM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 14,
                    TimeSlot = "9:00AM - 10:00AM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 15,
                    TimeSlot = "10:00AM - 11:00AM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 16,
                    TimeSlot = "11:00AM - 12:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 17,
                    TimeSlot = "12:00PM - 1:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 18,
                    TimeSlot = "1:00PM - 2:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 19,
                    TimeSlot = "2:00PM - 3:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 20,
                    TimeSlot = "3:00PM - 4:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 21,
                    TimeSlot = "4:00PM - 5:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 22,
                    TimeSlot = "5:00PM - 6:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 23,
                    TimeSlot = "6:00PM - 7:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },


                new Time
                {
                    TimeId = 24,
                    TimeSlot = "8:00PM - 9:00PM",
                    Day = "Tuesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 25,
                    TimeSlot = "8:00AM - 9:00AM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 26,
                    TimeSlot = "9:00AM - 10:00AM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 27,
                    TimeSlot = "10:00AM - 11:00AM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 28,
                    TimeSlot = "11:00AM - 12:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 29,
                    TimeSlot = "12:00PM - 1:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 30,
                    TimeSlot = "1:00PM - 2:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 31,
                    TimeSlot = "2:00PM - 3:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 32,
                    TimeSlot = "3:00PM - 4:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 33,
                    TimeSlot = "4:00PM - 5:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 34,
                    TimeSlot = "5:00PM - 6:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 35,
                    TimeSlot = "6:00PM - 7:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 36,
                    TimeSlot = "8:00PM - 9:00PM",
                    Day = "Wednesday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 37,
                    TimeSlot = "8:00AM - 9:00AM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 38,
                    TimeSlot = "9:00AM - 10:00AM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 39,
                    TimeSlot = "10:00AM - 11:00AM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 40,
                    TimeSlot = "11:00AM - 12:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 41,
                    TimeSlot = "12:00PM - 1:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 42,
                    TimeSlot = "1:00PM - 2:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 43,
                    TimeSlot = "2:00PM - 3:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 44,
                    TimeSlot = "3:00PM - 4:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 45,
                    TimeSlot = "4:00PM - 5:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 46,
                    TimeSlot = "5:00PM - 6:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 47,
                    TimeSlot = "6:00PM - 7:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 48,
                    TimeSlot = "8:00PM - 9:00PM",
                    Day = "Thursday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 49,
                    TimeSlot = "8:00AM - 9:00AM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 50,
                    TimeSlot = "9:00AM - 10:00AM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 51,
                    TimeSlot = "10:00AM - 11:00AM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 52,
                    TimeSlot = "11:00AM - 12:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 53,
                    TimeSlot = "12:00PM - 1:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 54,
                    TimeSlot = "1:00PM - 2:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 55,
                    TimeSlot = "2:00PM - 3:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 56,
                    TimeSlot = "3:00PM - 4:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 57,
                    TimeSlot = "4:00PM - 5:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 58,
                    TimeSlot = "5:00PM - 6:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 59,
                    TimeSlot = "6:00PM - 7:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 60,
                    TimeSlot = "8:00PM - 9:00PM",
                    Day = "Friday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 61,
                    TimeSlot = "8:00AM - 9:00AM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 62,
                    TimeSlot = "9:00AM - 10:00AM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 63,
                    TimeSlot = "10:00AM - 11:00AM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 64,
                    TimeSlot = "11:00AM - 12:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 65,
                    TimeSlot = "12:00PM - 1:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 66,
                    TimeSlot = "1:00PM - 2:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 67,
                    TimeSlot = "2:00PM - 3:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 68,
                    TimeSlot = "3:00PM - 4:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 69,
                    TimeSlot = "4:00PM - 5:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 70,
                    TimeSlot = "5:00PM - 6:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 71,
                    TimeSlot = "6:00PM - 7:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 72,
                    TimeSlot = "8:00PM - 9:00PM",
                    Day = "Saturday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 73,
                    TimeSlot = "8:00AM - 9:00AM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 74,
                    TimeSlot = "9:00AM - 10:00AM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 75,
                    TimeSlot = "10:00AM - 11:00AM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 76,
                    TimeSlot = "11:00AM - 12:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 77,
                    TimeSlot = "12:00PM - 1:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 78,
                    TimeSlot = "1:00PM - 2:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 79,
                    TimeSlot = "2:00PM - 3:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 80,
                    TimeSlot = "3:00PM - 4:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 81,
                    TimeSlot = "4:00PM - 5:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 82,
                    TimeSlot = "5:00PM - 6:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 83,
                    TimeSlot = "6:00PM - 7:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                },

                new Time
                {
                    TimeId = 84,
                    TimeSlot = "8:00PM - 9:00PM",
                    Day = "Sunday",
                    IsTaken = false,
                }
            );
        }
    }
}
