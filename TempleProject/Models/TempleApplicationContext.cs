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
    }
}
