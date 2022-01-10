using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MLT.Models;

namespace MLT.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MLT.Models.Aircraft> Aircraft { get; set; }
        public DbSet<MLT.Models.FlightPath> FlightPath { get; set; }
    }
}
