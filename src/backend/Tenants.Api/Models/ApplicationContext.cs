using System;
using Microsoft.EntityFrameworkCore;
using Tenants.Api.Models.Entities;

namespace Tenants.Api.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Tenant> Tenants { get; set; }
    }
}
