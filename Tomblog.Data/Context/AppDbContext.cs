using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomblog.DAL.Model;

namespace Tomblog.DAL.Context
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration _сonfiguration;
        public AppDbContext(DbContextOptions<AppDbContext> options, 
            IConfiguration configuration) : base(options)
        {
            _сonfiguration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(_сonfiguration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<User> Users { get; set; }
    }
}
