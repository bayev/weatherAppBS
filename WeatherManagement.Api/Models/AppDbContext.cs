using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherManagement.Models;

namespace weatherAppBS.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherData>().HasData(new WeatherData
            {
                Id = 1,
                Date = DateTime.Today,
                Location = "Inne",
                Temp = 23.3M,
                Humid = 42

            });
        }

        public DbSet<WeatherData> WeatherData { get; set; }
    }
}
