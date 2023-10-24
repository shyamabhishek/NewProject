using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Contex
{
    public class AICDbContext : DbContext
    {
        
        public AICDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Policy> Policy { get; set; }
        public DbSet<Insurance_Claim> Ensurance_Claim { get; set; }
        public DbSet<Admin_Details> Admin_Details { get; set; }
        
    }
}

