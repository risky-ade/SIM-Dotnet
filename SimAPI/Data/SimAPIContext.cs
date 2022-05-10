#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimAPI.Models;

    public class SimAPIContext : DbContext
    {
        public SimAPIContext (DbContextOptions<SimAPIContext> options)
            : base(options)
        {
        }

        public DbSet<SimAPI.Models.User> User { get; set; }
    }
